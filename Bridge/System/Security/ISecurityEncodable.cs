using System.Runtime.InteropServices;

namespace System.Security {

    public interface ISecurityEncodable {
        SecurityElement ToXml();
        void FromXml( SecurityElement e );
    }

}