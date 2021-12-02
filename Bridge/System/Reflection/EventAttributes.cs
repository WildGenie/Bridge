namespace System.Reflection {

    public enum EventAttributes {
        None = 0,
        SpecialName = 512, // 0x00000200
        ReservedMask = 1024, // 0x00000400
        RTSpecialName = ReservedMask // 0x00000400
    }

}
