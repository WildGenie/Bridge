using System;

namespace Bridge.Luna.Utils
{
    public class Debug
    {
        public const string NotImplementedMethodTemplate =
            "DEVELOP ? `The method \"${ this.$$fullname.split( '.' ).pop() }.{methodName:raw}(${ ( {paramTypes} || [] ).map( t => t.$$name.split( '.' ).pop() ).join( ', ' ) })\" is not implemented` : UnityEngine.Debug.NotImplementedMessage";
        [ Template( "UnityEngine.Debug.LogWarning(" + NotImplementedMethodTemplate + ")" ) ]
        internal static void WarnNotImplementedMethod( string methodName, params Type[] paramTypes ) { }
    }
}