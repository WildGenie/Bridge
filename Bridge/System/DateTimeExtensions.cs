using System;
using Bridge;

namespace System {

    public static class DateTimeExtensions {
        public static long ToFileTimeUtc( this DateTime dateTime ) {
            return Script.Get<long>( "dateTime.getTime()" );
        }
    }

}
