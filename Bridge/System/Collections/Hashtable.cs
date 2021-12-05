using System;
using Bridge;
using System.Collections.Generic;

namespace System.Collections {

    /// <summary>
    /// Hashtable.
    /// </summary>
    public class Hashtable : Dictionary<object, object> {
        #region Compatibility fixes

        [ Init( InitPosition.After ) ]
        public static void FixGetMethod() {
            Script.Write(
                " System.Collections.Hashtable.prototype.get = function (key) { var entry = this.findEntry(key); return entry ? entry.value : null; } " );
        }

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Collections.Hashtable"/> class.
        /// </summary>
        /// <param name="capacity">Capacity.</param>
        public Hashtable( int capacity ) : base( capacity ) { }

        public Hashtable( IDictionary<object, object> dictionary ) : base( dictionary ) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Collections.Hashtable"/> class.
        /// </summary>
        public Hashtable() : base() { }

        /// <summary>
        /// Contains the specified key.
        /// </summary>
        /// <param name="key">Key.</param>
        public bool Contains( object key ) {
            return ContainsKey( key );
        }

        /// <summary>
        /// Clone this instance.
        /// </summary>
        public Hashtable Clone() {
            var clone = new Hashtable();

            foreach ( var kvp in this ) {
                clone[ kvp.Key ] = kvp.Value;
            }

            return clone;
        }
    }

}