namespace System.Reflection {

    public enum FieldAttributes {
        FieldAccessMask = 7,
        PrivateScope = 0,
        Private = 1,
        FamANDAssem = 2,
        Assembly = FamANDAssem | Private, // 0x00000003
        Family = 4,
        FamORAssem = Family | Private, // 0x00000005
        Public = Family | FamANDAssem, // 0x00000006
        Static = 16, // 0x00000010
        InitOnly = 32, // 0x00000020
        Literal = 64, // 0x00000040
        NotSerialized = 128, // 0x00000080
        SpecialName = 512, // 0x00000200
        PinvokeImpl = 8192, // 0x00002000
        ReservedMask = 38144, // 0x00009500
        RTSpecialName = 1024, // 0x00000400
        HasFieldMarshal = 4096, // 0x00001000
        HasDefault = 32768, // 0x00008000
        HasFieldRVA = 256 // 0x00000100
    }

}
