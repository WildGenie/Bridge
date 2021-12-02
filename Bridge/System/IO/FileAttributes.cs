using System;

namespace System.IO {

    public enum FileAttributes {
        Archive = 32,
        Compressed = 2048,
        Device = 64,
        Directory = 16,
        Encrypted = 16384,
        Hidden = 2,
        Normal = 128,
        NotContentIndexed = 8192,
        Offline = 4096,
        ReadOnly = 1,
        ReparsePoint = 1024,
        SparseFile = 512,
        System = 4,
        Temporary = 256
    }

}
