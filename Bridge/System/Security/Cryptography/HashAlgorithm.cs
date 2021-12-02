using System;
using Bridge.Luna.Utils;

namespace System.Security.Cryptography {

    public class HashAlgorithm : IDisposable {
        public void Dispose() { }

        public byte[] ComputeHash( byte[] buffer )
        {
            Debug.WarnNotImplementedMethod( nameof( ComputeHash ), typeof( byte[] ) );
            return new byte[] { };
        }
    }

}
