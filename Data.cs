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
        StopDrawing,    // Round's over, stop drawing
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
                this.strName = Encoding.UTF8.GetString(data, 12, nameLen);
            else
                this.strName = null;

            //This checks for a null message field
            if (msgLen > 0)
                this.strMessage = Encoding.UTF8.GetString(data, 12 + nameLen, msgLen);
            else
                this.strMessage = null;
        }

        private void DrawingPacket(byte[] data)
        {
            this.cmdCommand = (Command)BitConverter.ToInt32(data, 0);

            this.size = BitConverter.ToInt32(data, 4);

            this.shape = BitConverter.ToInt32(data, 8);

            this.color = Color.FromArgb(data[12], data[16], data[20]);

            this.p1.X = BitConverter.ToInt32(data, 24);
            this.p1.Y = BitConverter.ToInt32(data, 28);

            int nameLen = BitConverter.ToInt32(data, 32);

            if (nameLen > 0)
                this.strName = Encoding.UTF8.GetString(data, 36, nameLen);
            else
                this.strName = null;
        }

        public byte[] DrawingToByte()
        {
            List<byte> result = new List<byte>();

            //First four are for the Command
            result.AddRange(BitConverter.GetBytes((int)cmdCommand));
            result.AddRange(BitConverter.GetBytes(size));
            result.AddRange(BitConverter.GetBytes(shape));
            result.AddRange(BitConverter.GetBytes((int)color.R));
            result.AddRange(BitConverter.GetBytes((int)color.G));
            result.AddRange(BitConverter.GetBytes((int)color.B));
            result.AddRange(BitConverter.GetBytes(p1.X));
            result.AddRange(BitConverter.GetBytes(p1.Y));

            //Add the length of the name
            if (strName != null)
                result.AddRange(BitConverter.GetBytes(strName.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));
            //Add the name
            if (strName != null)
                result.AddRange(Encoding.UTF8.GetBytes(strName));

            return result.ToArray();
        }


        //Converts the Data structure into an array of bytes
        public byte[] ToByte()
        {
            List<byte> result = new List<byte>();

            //First four are for the Command
            result.AddRange(BitConverter.GetBytes((int)cmdCommand));

            //Add the length of the name
            if (strName != null)
                result.AddRange(BitConverter.GetBytes(strName.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            //Length of the message
            if (strMessage != null)
                result.AddRange(BitConverter.GetBytes(strMessage.Length));
            else
                result.AddRange(BitConverter.GetBytes(0));

            //Add the name
            if (strName != null)
                result.AddRange(Encoding.UTF8.GetBytes(strName));

            //And, lastly we add the message text to our array of bytes
            if (strMessage != null)
                result.AddRange(Encoding.UTF8.GetBytes(strMessage));

            return result.ToArray();
        }
    }
}
