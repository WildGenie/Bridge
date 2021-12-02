using System.Runtime.InteropServices;

namespace System.Reflection {

    public enum MethodAttributes {
        MemberAccessMask = 7,
        PrivateScope = 0,
        Private = 1,
        FamANDAssem = 2,
        Assembly = FamANDAssem | Private, // 0x00000003
        Family = 4,
        FamORAssem = Family | Private, // 0x00000005
        Public = Family | FamANDAssem, // 0x00000006
        Static = 16, // 0x00000010
        Final = 32, // 0x00000020
        Virtual = 64, // 0x00000040
        HideBySig = 128, // 0x00000080
        CheckAccessOnOverride = 512, // 0x00000200
        VtableLayoutMask = 256, // 0x00000100
        ReuseSlot = 0,
        NewSlot = VtableLayoutMask, // 0x00000100
        Abstract = 1024, // 0x00000400
        SpecialName = 2048, // 0x00000800
        PinvokeImpl = 8192, // 0x00002000
        UnmanagedExport = 8,
        RTSpecialName = 4096, // 0x00001000
        ReservedMask = 53248, // 0x0000D000
        HasSecurity = 16384, // 0x00004000
        RequireSecObject = 32768 // 0x00008000
    }

}
