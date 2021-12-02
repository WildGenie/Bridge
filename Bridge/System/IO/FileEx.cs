using System;
using Bridge.Luna.Utils;

namespace System.IO {

    public class FileEx {
        public static FileStream Create( string path )
        {
            Debug.WarnNotImplementedMethod( nameof( Create ), typeof( string ) );
            return null;
        }

        public static void Delete( string path ) {
            Debug.WarnNotImplementedMethod( nameof( Delete ), typeof( string ) );
        }

        public static void WriteAllBytes( string path, byte[] bytes ) {
            Debug.WarnNotImplementedMethod( nameof( WriteAllBytes ), typeof( string ), typeof( byte[] ) );
        }

        public static bool Exists( string path )
        {
            Debug.WarnNotImplementedMethod( nameof( Exists ), typeof( string ) );
            return false;
        }

        public static FileAttributes GetAttributes( string path )
        {
            Debug.WarnNotImplementedMethod( nameof( GetAttributes ), typeof( string ) );
            return (FileAttributes) 0;
        }

        public static void WriteAllText( string path, string contents ) {
            Debug.WarnNotImplementedMethod( nameof( WriteAllText ), typeof( string ), typeof( string ) );
        }

        public static string ReadAllText( string path )
        {
            Debug.WarnNotImplementedMethod( nameof( ReadAllText ), typeof( string ) );
            return null;
        }
    }

}
