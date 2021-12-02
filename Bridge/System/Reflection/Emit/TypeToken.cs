namespace System.Reflection.Emit {

    public struct TypeToken {
        public static readonly TypeToken Empty;

        public int Token => default( int );

        public override bool Equals( object obj ) {
            return default( bool );
        }

        public bool Equals( TypeToken obj ) {
            return default( bool );
        }

        public static bool operator ==( TypeToken a, TypeToken b ) {
            return default( bool );
        }

        public static bool operator !=( TypeToken a, TypeToken b ) {
            return default( bool );
        }

        public override int GetHashCode() {
            return default( int );
        }

        public void InvokableEvent( object target, string methodName ) { }
    }

}
