using System;

namespace System {

    public static class PropertyInfoExtensions {
        public static Reflection.MethodInfo GetGetMethod( this Reflection.PropertyInfo pi ) {
            return pi.GetMethod;
        }

        public static Reflection.MethodInfo GetSetMethod( this Reflection.PropertyInfo pi ) {
            return pi.SetMethod;
        }
    }

}
