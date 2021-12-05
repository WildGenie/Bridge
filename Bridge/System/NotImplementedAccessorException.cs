using Bridge;

namespace System {

    [ Serializable ]
    public class NotImplementedAccessorException : SystemException {
        [ Template( "new System.NotSupportedException.$ctor1(" + Bridge.Luna.Utils.Debug.NotImplementedAccessorTemplate + ")" ) ]
        public NotImplementedAccessorException( string propName, bool getAccessor = true ) : base( "" ) { }
    }

}