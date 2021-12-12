using System;

namespace System {

    public static class StringExtensions {
        public static string ToUpperInvariant( this string s ) {
            return s.ToUpper();
        }

        public static string ToLowerInvariant( this string s ) {
            return s.ToLower();
        }

        public static bool StartsWith( this string s, string value, StringComparison stringComparison ) {
            return s.StartsWith( value );
        }

        public static bool EndsWith( this string s, string value, StringComparison stringComparison ) {
            return s.EndsWith( value );
        }
    }

}
