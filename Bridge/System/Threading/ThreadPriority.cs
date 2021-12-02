namespace System.Threading {

    /// <summary>Specifies the scheduling priority of a <see cref="T:System.Threading.Thread" />.</summary>
    [ Serializable ]
    public enum ThreadPriority {
        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled after threads with any other priority.</summary>
        Lowest,

        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled after threads with <see langword="Normal" /> priority and before those with <see langword="Lowest" /> priority.</summary>
        BelowNormal,

        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled after threads with <see langword="AboveNormal" /> priority and before those with <see langword="BelowNormal" /> priority. Threads have <see langword="Normal" /> priority by default.</summary>
        Normal,

        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled after threads with <see langword="Highest" /> priority and before those with <see langword="Normal" /> priority.</summary>
        AboveNormal,

        /// <summary>The <see cref="T:System.Threading.Thread" /> can be scheduled before threads with any other priority.</summary>
        Highest
    }

}