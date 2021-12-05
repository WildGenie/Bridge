using Bridge;

namespace System {

    [ Serializable ]
    public class NotSupportedMethodException : SystemException {
        [ Template( "new System.NotSupportedException.$ctor1(" + Bridge.Luna.Utils.Debug.NotSupportedMethodTemplate + ")" ) ]
        public NotSupportedMethodException( string methodName, params Type[] paramTypes ) : base( "" ) { }
    }

}