using System;

namespace System.Collections.ObjectModel {

    public abstract class KeyedCollection<TKey, TItem> : Collection<TItem> {
        public KeyedCollection() { }

        protected abstract TKey GetKeyForItem( TItem item );

        public bool Contains( TKey key ) {
            Bridge.Luna.Utils.Debug.WarnNotImplementedMethod( nameof( Contains ), typeof( TKey ) );
            return false;
        }
    }

}