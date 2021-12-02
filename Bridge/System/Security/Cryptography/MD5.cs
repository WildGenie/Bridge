using System;
using Bridge.Luna.Utils;

namespace System.Security.Cryptography {

    public class MD5 : HashAlgorithm {
        protected MD5() { }

        public static MD5 Create()
        {
            Debug.WarnNotImplementedMethod( nameof( Create ) );
            return null;
        }
    }

}
