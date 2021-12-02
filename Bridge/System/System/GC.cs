using System;
using Bridge.Luna.Utils;

namespace System {

    public class GC {
        public static void Collect() {
            Debug.WarnNotImplementedMethod( nameof( Collect ) );
        }

        public static void SuppressFinalize( object obj ) {
            Debug.WarnNotImplementedMethod( nameof( SuppressFinalize ), typeof( object ) );
        }

        public static long GetTotalMemory( bool forceFullCollection )
        {
            Debug.WarnNotImplementedMethod( nameof( GetTotalMemory ), typeof( bool ) );
            return 0;
        }

        public static int CollectionCount( int generation )
        {
            Debug.WarnNotImplementedMethod( nameof( CollectionCount ), typeof( int ) );
            return 0;
        }
    }

}
