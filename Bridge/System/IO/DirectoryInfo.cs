using System;
using Bridge.Luna.Utils;

namespace System.IO {

    public class DirectoryInfo {
        public DirectoryInfo() { }

        public DirectoryInfo( string path ) { }

        public FileInfo[] GetFiles() {
            return new FileInfo[] { };
        }

        public DirectoryInfo[] GetDirectories() {
            return new DirectoryInfo[] { };
        }

        public void Delete( bool recursive = false ) {
            Debug.WarnNotImplementedMethod( nameof( Delete ), typeof( bool ) );
        }
    }

}
