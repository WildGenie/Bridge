using System.Collections;
using System.Security.Permissions;
using System.Runtime.Serialization;

namespace System.Security {

    public class PermissionSet : ICollection, IDeserializationCallback {
        public PermissionSet( PermissionState state ) { }
        public PermissionSet( PermissionSet permSet ) { }
        public PermissionSet() { }

        public virtual int Count => default( int );

        public virtual bool IsSynchronized => default( bool );

        public virtual bool IsReadOnly => default( bool );

        public virtual object SyncRoot => default( object );

        public IPermission AddPermission( IPermission perm ) {
            return default( IPermission );
        }

        public void Assert() { }

        public virtual PermissionSet Copy() {
            return default( PermissionSet );
        }

        public virtual void CopyTo( Array array, int index ) { }
        public void Demand() { }
        public void Deny() { }
        public virtual void FromXml( SecurityElement et ) { }

        public IEnumerator GetEnumerator() {
            return default( IEnumerator );
        }

        public bool IsSubsetOf( PermissionSet target ) {
            return default( bool );
        }

        public void PermitOnly() { }

        public bool ContainsNonCodeAccessPermissions() {
            return default( bool );
        }

        public static byte[] ConvertPermissionSet( string inFormat, byte[] inData, string outFormat ) {
            return default( byte[] );
        }

        public IPermission GetPermission( Type permClass ) {
            return default( IPermission );
        }

        public PermissionSet Intersect( PermissionSet other ) {
            return default( PermissionSet );
        }

        public bool IsEmpty() {
            return default( bool );
        }

        public bool IsUnrestricted() {
            return default( bool );
        }

        public IPermission RemovePermission( Type permClass ) {
            return default( IPermission );
        }

        public IPermission SetPermission( IPermission perm ) {
            return default( IPermission );
        }

        public override string ToString() {
            return default( string );
        }

        public virtual SecurityElement ToXml() {
            return default( SecurityElement );
        }

        public PermissionSet Union( PermissionSet other ) {
            return default( PermissionSet );
        }

        public override bool Equals( object obj ) {
            return default( bool );
        }

        public override int GetHashCode() {
            return default( int );
        }

        public static void RevertAssert() { }
        void IDeserializationCallback.OnDeserialization( object sender ) { }
    }

}
