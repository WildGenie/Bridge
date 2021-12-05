using System;

namespace Bridge.Luna.Utils {

    public class Debug {
        public const string NotImplementedMethodTemplate =
            "DEVELOP ? `The method \"${ this.$$fullname.split( '.' ).pop() }.{methodName:raw}(${ ( {paramTypes} || [] ).map( t => t.$$name.split( '.' ).pop() ).join( ', ' ) })\" is not implemented` : UnityEngine.Debug.NotImplementedMessage";

        public const string NotImplementedAccessorTemplate =
            "DEVELOP ? `The accessor \"${ this.$$fullname.split( '.' ).pop() }.{propName:raw}.${ {getAccessor} ? \"get\" : \"set\" }\" is not implemented` : UnityEngine.Debug.NotImplementedMessage";

        public const string NotSupportedMethodTemplate =
            "DEVELOP ? `The method \"${ this.$$fullname.split( '.' ).pop() }.{methodName:raw}(${ ( {paramTypes} || [] ).map( t => t.$$name.split( '.' ).pop() ).join( ', ' ) })\" is not supported` : UnityEngine.Debug.NotSupportedMessage";

        public const string NotSupportedAccessorTemplate =
            "DEVELOP ? `The accessor \"${ this.$$fullname.split( '.' ).pop() }.{propName:raw}.${ {getAccessor} ? \"get\" : \"set\" }\" is not supported` : UnityEngine.Debug.NotSupportedMessage";


        [ Template( "UnityEngine.Debug.Log(" + NotImplementedMethodTemplate + ")" ) ]
        internal static void LogNotImplementedMethod( string methodName, params Type[] paramTypes ) { }

        [ Template( "UnityEngine.Debug.LogWarning(" + NotImplementedMethodTemplate + ")" ) ]
        internal static void WarnNotImplementedMethod( string methodName, params Type[] paramTypes ) { }

        [ Template( "UnityEngine.Debug.LogError(" + NotImplementedMethodTemplate + ")" ) ]
        internal static void ErrorNotImplementedMethod( string methodName, params Type[] paramTypes ) { }

        [ Template( "UnityEngine.Debug.Log(" + NotSupportedMethodTemplate + ")" ) ]
        internal static void LogNotSupportedMethod( string methodName, params Type[] paramTypes ) { }

        [ Template( "UnityEngine.Debug.LogWarning(" + NotSupportedMethodTemplate + ")" ) ]
        internal static void WarnNotSupportedMethod( string methodName, params Type[] paramTypes ) { }

        [ Template( "UnityEngine.Debug.LogError(" + NotSupportedMethodTemplate + ")" ) ]
        internal static void ErrorNotSupportedMethod( string methodName, params Type[] paramTypes ) { }

        [ Template( "UnityEngine.Debug.Log(" + NotImplementedAccessorTemplate + ")" ) ]
        internal static void LogNotImplementedAccessor( string propName, bool getAccessor = true ) { }

        [ Template( "UnityEngine.Debug.LogWarning(" + NotImplementedAccessorTemplate + ")" ) ]
        internal static void WarnNotImplementedAccessor( string propName, bool getAccessor = true ) { }

        [ Template( "UnityEngine.Debug.LogError(" + NotImplementedAccessorTemplate + ")" ) ]
        internal static void ErrorNotImplementedAccessor( string propName, bool getAccessor = true ) { }

        [ Template( "UnityEngine.Debug.Log(" + NotSupportedAccessorTemplate + ")" ) ]
        internal static void LogNotSupportedAccessor( string propName, bool getAccessor = true ) { }

        [ Template( "UnityEngine.Debug.LogWarning(" + NotSupportedAccessorTemplate + ")" ) ]
        internal static void WarnNotSupportedAccessor( string propName, bool getAccessor = true ) { }

        [ Template( "UnityEngine.Debug.LogError(" + NotSupportedAccessorTemplate + ")" ) ]
        internal static void ErrorNotSupportedAccessor( string propName, bool getAccessor = true ) { }
    }

}
