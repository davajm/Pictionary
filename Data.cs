using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pictionary
{
    public enum Command
    {
        Login,          // Login to server
        Logout,         // Logout of the server
        Message,        // Send message (used for chatting)
        List,           // Get a list of all the users in the game
        Ready,          // Indicates that user is ready for a new game
        StartGame,      // Indicates the start of the game
        StopGame,       // Stops game
        StartDrawing,   // Indicates the user that's currently drawing
        ChooseWord,     // Round's over, stop drawing
        CorrectGuess,   // Indicate correct guess of the word being drawn
        RoundOver,      // Indicates that current round is over
        GameOver,       // Indicates that the game is over
        NewStroke,      // Initiate a new stroke
        Stroke,         // Continue on current stroke
        EraseStroke,    // Erase last stroke
        Fill,           // Fill
        Clear,          // Clear board
        Null            // No command
    }


    public class Data  
    {
        /* Normal packet*/
        public string strName;      // Name by which the client logs into the room
        public string strMessage;   // Message text
        public Command cmdCommand;  // Command type (see above)

        /* Drawing packet */
        public Color color;                // Color for drawing
        public Point p1;                   // Point (position) for drawing
        public int size;                   // Size of brush/pen
        public int shape;                  // Shape of brush/pen

        public Data()
        {
            this.cmdCommand = Command.Null;
            this.strMessage = null;
            this.strName = null;
        }

        public Data(byte[] data, bool isDrawPacket)
        {
            if (isDrawPacket)
            {
                DrawingPacket(data);
            }
            else
            {
                MessagePacket(data);
            }
        }
        /* Convert from bytes to readable message packet */ 
        public void MessagePacket(byte[] data)
        {
            //The first four bytes are for the Command
            this.cmdCommand = (Command)BitConverter.ToInt32(data, 0);

            //The next four store the length of the name
            int nameLen = BitConverter.ToInt32(data, 4);

            //The next four store the length of the message
            int msgLen = BitConverter.ToInt32(data, 8);

            //This check makes sure that strName has been passed in the array of bytes
            if (nameLen > 0)
                this.strName = Encoding.GetEncoding(1252).GetString(data, 12, nameLen);
            else
                this.strName = null;

            //This checks for a null message field
            if (msgLen > 0)
                this.strMessage = Encoding.GetEncoding(1252).GetString(data, 12 + nameLen, msgLen);
            else
                this.strMessage = null;
        }

        /* Convert from bytes to readable drawing packet */
        private void DrawingPacket(byte[] data)
        {
            // Command
            this.cmdCommand = (Command)BitConverter.ToInt32(data, 0);

            // Drawing stuff
            this.size = BitConverter.ToInt32(data, 4);
            this.shape = BitConverter.ToInt32(data, 8);
            this.color = Color.FromArgb(data[12], data[16], data[20]);
            this.p1.X = BitConverter.ToInt32(data, 24);
            this.p1.Y = BitConverter.ToInt32(data, 28);

            // Username length
            int nameLen = BitConverter.ToInt32(data, 32);

            // Username
            if (nameLen > 0)
                this.strName = Encoding.GetEncoding(1252).GetString(data, 36, nameLen);
            else
                this.strName = null;
        }

        /* Convert drawing packet to an array of bytes */ 
        public byte[] DrawingToByte()
        {
            List<byte> result = new List<byte>();

            // Command
            result.AddRange(BitConverter.GetBytes((int)cmdCommand));

            // Stuff for drawing
            result.AddRange(BitConverter.GetBytes(size));
            result.AddRange(BitConverter.GetBytes(shape));
            result.AddRange(BitConverter.GetBytes((int)color.R));
            result.AddRange(BitConverter.GetBytes((int)color.G));
            result.AddRange(BitConverter.GetBytes((int)color.B));
            result.AddRange(BitConverter.GetBytes(p1.X));
            result.AddRange(BitConverter.GetBytes(p1.Y));

            // Length of username
            if (strName != null)
                result.AddRange(BitConverter.GetBytes(strName.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));
            // Username
            if (strName != null)
                result.AddRange(Encoding.GetEncoding(1252).GetBytes(strName));

            return result.ToArray();
        }

        /* Convert normal (message) packets to an array of bytes */ 
        public byte[] ToByte()
        {
            List<byte> result = new List<byte>();

            // Command
            result.AddRange(BitConverter.GetBytes((int)cmdCommand));

            // Username length
            if (strName != null)
                result.AddRange(BitConverter.GetBytes(strName.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            // Message length
            if (strMessage != null)
                result.AddRange(BitConverter.GetBytes(strMessage.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            // Username
            if (strName != null)
                result.AddRange(Encoding.GetEncoding(1252).GetBytes(strName));

            // Message
            if (strMessage != null)
                result.AddRange(Encoding.GetEncoding(1252).GetBytes(strMessage));

            return result.ToArray();
        }
    }
}
