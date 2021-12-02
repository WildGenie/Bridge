namespace System.Runtime.InteropServices {

    public enum UnmanagedType {
        Bool = 2,
        I1 = 3,
        U1 = 4,
        I2 = 5,
        U2 = 6,
        I4 = 7,
        U4 = 8,
        I8 = 9,
        U8 = 10, // 0x0000000A
        R4 = 11, // 0x0000000B
        R8 = 12, // 0x0000000C
        Currency = 15, // 0x0000000F
        BStr = 19, // 0x00000013
        LPStr = 20, // 0x00000014
        LPWStr = 21, // 0x00000015
        LPTStr = 22, // 0x00000016
        ByValTStr = 23, // 0x00000017
        IUnknown = 25, // 0x00000019
        IDispatch = 26, // 0x0000001A
        Struct = 27, // 0x0000001B
        Interface = 28, // 0x0000001C
        SafeArray = 29, // 0x0000001D
        ByValArray = 30, // 0x0000001E
        SysInt = 31, // 0x0000001F
        SysUInt = 32, // 0x00000020
        VBByRefStr = 34, // 0x00000022
        AnsiBStr = 35, // 0x00000023
        TBStr = 36, // 0x00000024
        VariantBool = 37, // 0x00000025
        FunctionPtr = 38, // 0x00000026
        AsAny = 40, // 0x00000028
        LPArray = 42, // 0x0000002A
        LPStruct = 43, // 0x0000002B
        CustomMarshaler = 44, // 0x0000002C
        Error = 45, // 0x0000002D
        IInspectable = 46, // 0x0000002E
        HString = 47, // 0x0000002F
        LPUTF8Str = 48 // 0x00000030
    }

}
