using Bridge;

namespace System {

    [ Serializable ]
    public class NotImplementedMethodException : SystemException {
        [ Template( "new System.NotSupportedException.$ctor1(" + Bridge.Luna.Utils.Debug.NotImplementedMethodTemplate + ")" ) ]
        public NotImplementedMethodException( string methodName, params Type[] paramTypes ) : base( "" ) { }
    }

}