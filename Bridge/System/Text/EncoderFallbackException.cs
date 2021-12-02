using System;

namespace System.Text {

    public class EncoderFallbackException : Exception {
        public EncoderFallbackException() { }

        public EncoderFallbackException( string message ) : base( message ) { }
    }

}