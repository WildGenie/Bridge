using System;
using Bridge.Luna.Utils;

namespace System.IO {

    public class Directory {
        public static bool Exists( string path ) {
            Debug.WarnNotImplementedMethod( nameof( Exists ), typeof( string ) );
            return default( bool );
        }

        public static void Delete( string path ) {
            Debug.WarnNotImplementedMethod( nameof( Delete ), typeof( string ) );
        }

        public static DirectoryInfo CreateDirectory( string path ) {
            Debug.WarnNotImplementedMethod( nameof( CreateDirectory ), typeof( string ) );
            return default( DirectoryInfo );
        }

        public static string[] GetFiles( string path, string searchPattern ) {
            Debug.WarnNotImplementedMethod( nameof( GetFiles ), typeof( string ), typeof( string ) );
            return new string[] { };
        }
    }

}
