//-----------------------------------------------------------------------------
//
//	Copyright (c) 2016 Will Graham <wgraham@getministra.com>
//
//	SOFTWARE NOTICE AND LICENSE
//
//	This file is part of OpenZW.NET
//
//	OpenZW.NET is free software: you can redistribute it and/or modify
//	it under the terms of the GNU Lesser General Public License as published
//	by the Free Software Foundation, either version 3 of the License,
//	or (at your option) any later version.
//
//	OpenZW.NET is distributed in the hope that it will be useful,
//	but WITHOUT ANY WARRANTY; without even the implied warranty of
//	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//	GNU Lesser General Public License for more details.
//
//	You should have received a copy of the GNU Lesser General Public License
//	along with OpenZW.NET.  If not, see <http://www.gnu.org/licenses/>.
//
//-----------------------------------------------------------------------------

namespace OpenZW
{
    /// <summary>
    /// Represents a Z-Wave Message.
    /// </summary>
    public class Message
    {
        private MessageFlags flags;
        private bool isMessagePackaged;
        private int length;
        private byte[] buffer = new byte[256];

        public Message(byte targetNodeId, byte type, byte function, bool callbackRequired, bool replyRequired, byte expectedReply = 0, byte expectedCommandClassId = 0)
        {
            this.buffer[0] = Constants.SOF;
            this.buffer[1] = 0;
            this.buffer[2] = type;
            this.buffer[3] = function;
        }

        public void PrepareForSend()
        {
            if (this.isMessagePackaged)
            {
                return;
            }

            if ((this.flags & MessageFlags.MultiChannel) == MessageFlags.MultiChannel)
            {
                this.EncapsulateInMultiChannel();
            }
            else if ((this.flags & MessageFlags.MultiInstance) == MessageFlags.MultiInstance)
            {

            }
        }

        private void Append(byte byteToAppend)
        {
            this.buffer[this.length++] = byteToAppend;
        }

        private void EncapsulateInMultiChannel()
        {

        }

        private void EncapsulateInMultiInstance()
        {

        }
    }
}
