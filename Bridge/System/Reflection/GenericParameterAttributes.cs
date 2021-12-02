namespace System.Reflection {

    public enum GenericParameterAttributes {
        None = 0,
        VarianceMask = 3,
        Covariant = 1,
        Contravariant = 2,
        SpecialConstraintMask = 28, // 0x0000001C
        ReferenceTypeConstraint = 4,
        NotNullableValueTypeConstraint = 8,
        DefaultConstructorConstraint = 16 // 0x00000010
    }

}
