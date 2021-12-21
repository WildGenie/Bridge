using System.Runtime.InteropServices;

namespace System.Security {

    public interface IPermission {
        IPermission Copy();

        IPermission Intersect( IPermission target );

        IPermission Union( IPermission target );

        bool IsSubsetOf( IPermission target );

        void Demand();
    }

}