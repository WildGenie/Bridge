using System;

namespace System {

    public static class CharExtensions {
        internal const char HIGH_SURROGATE_START = '\ud800';
        internal const char HIGH_SURROGATE_END = '\udbff';
        internal const char LOW_SURROGATE_START = '\udc00';
        internal const char LOW_SURROGATE_END = '\udfff';
        internal const int UNICODE_PLANE01_START = 0x10000;

        public static int ConvertToUtf32( char highSurrogate, char lowSurrogate ) {
            return ( highSurrogate - HIGH_SURROGATE_START ) * 0x400 + ( lowSurrogate - LOW_SURROGATE_START ) +
                   UNICODE_PLANE01_START;
        }
    }

}
