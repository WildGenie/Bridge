using System;
using Bridge.Luna.Utils;

namespace System.IO {

    public class FileInfo {
        public FileInfo() { }

        public FileInfo( string path ) { }

        public void Delete() {
            Debug.WarnNotImplementedMethod( nameof( Delete ) );
        }
    }

}
