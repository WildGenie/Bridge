using System.Collections.Generic;
using System.Collections.ObjectModel;
using Bridge;

namespace System.Collections.Generic {

    public static class ListExtensions {
        public static void ForEach<T>( this List<T> list, Action<T> action ) {
            foreach ( var a in list ) {
                action( a );
            }
        }

        public static bool TrueForAll<T>( this List<T> list, Predicate<T> match ) {
            foreach ( var a in list ) {
                if ( !match( a ) ) {
                    return false;
                }
            }

            return true;
        }

        public static int FindIndex<T>( this List<T> list, Predicate<T> match ) {
            for ( var i = 0; i < list.Count; i++ ) {
                if ( match( list[ i ] ) ) {
                    return i;
                }
            }

            return -1;
        }

        public static bool Exists<T>( this List<T> list, Predicate<T> match ) {
            foreach ( var a in list ) {
                if ( match( a ) ) {
                    return true;
                }
            }

            return false;
        }

        public static T Find<T>( this List<T> list, Predicate<T> match ) {
            foreach ( var a in list ) {
                if ( match( a ) ) {
                    return a;
                }
            }

            return default( T );
        }

        public static ReadOnlyCollection<T> AsReadOnly<T>( this List<T> list ) {
            return Script.Get<ReadOnlyCollection<T>>( "list" );
        }
    }

}