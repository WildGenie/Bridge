namespace System.Reflection {

    public enum PropertyAttributes {
        None = 0,
        SpecialName = 512, // 0x00000200
        ReservedMask = 62464, // 0x0000F400
        RTSpecialName = 1024, // 0x00000400
        HasDefault = 4096, // 0x00001000
        Reserved2 = 8192, // 0x00002000
        Reserved3 = 16384, // 0x00004000
        Reserved4 = 32768 // 0x00008000
    }

}
