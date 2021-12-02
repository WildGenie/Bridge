using System.Text.RegularExpressions;
using Bridge.Luna.Utils;

namespace System.IO {

    public class Path {
        public static string Combine( string path1, string path2 ) {
            // if path1 == "" then C# doesn't add slash, but if path1 is whitespace => result is " \paths2"
            if ( string.IsNullOrEmpty( path1 ) ) {
                return path2;
            }

            if ( path1.EndsWith( "/" ) && path2.StartsWith( "/" ) ) {
                path2.Remove( 0 );
            } else if ( !path1.EndsWith( "/" ) && !path2.StartsWith( "/" ) ) {
                return path1 + "/" + path2;
            }

            return path1 + path2;
        }

        /// <summary>Returns the file name of the specified path string without the extension.</summary>
        /// <param name="path">The path of the file. </param>
        /// <returns>The string returned by <see cref="M:System.IO.Path.GetFileName(System.String)" />, minus the last period (.) and all characters following it.</returns>
        public static string GetFileNameWithoutExtension( string path ) {
            return string.IsNullOrWhiteSpace( path )
                ? path
                : new Regex( "\\.[^/\\\\.]+$" ).Replace( path, string.Empty );
        }

        public static string GetDirectoryName( string path ) {
            Debug.WarnNotImplementedMethod( nameof( GetDirectoryName ), typeof( string ) );
            return default( string );
        }

        public static string GetExtension( string rawPath ) {
            var path = rawPath.Trim();
            var match = string.IsNullOrWhiteSpace( path )
                ? null
                : new Regex( "\\.\\w+$" ).Match( path );

            return match?.ToString();
        }
    }

}
