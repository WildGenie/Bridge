namespace System.Reflection {

    public static class TypeExtensions {
        public static ConstructorInfo[] GetConstructors( this Type type, BindingFlags bindingFlags ) {
            return type.GetConstructors();
        }
    }

}
