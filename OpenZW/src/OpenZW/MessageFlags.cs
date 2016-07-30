namespace OpenZW
{
    public enum MessageFlags : byte
    {
        /// <summary>
        /// No flags apply to the message
        /// </summary>
        None = 0x00,

        /// <summary>
        /// Indicates that the message has MultiChannel encapsulation
        /// </summary>
        MultiChannel = 0x01,

        /// <summary>
        /// Indicates the the message has MultiInstance encapsulation
        /// </summary>
        MultiInstance = 0x02
    }
}
