namespace System {

    public class WeakReference {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.WeakReference"/> class.
        /// </summary>
        /// <param name="target">Target.</param>
        /// <param name="trackResurrection">If set to <c>true</c> track resurrection.</param>
        public WeakReference( object target, bool trackResurrection ) {
            Target = target;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.WeakReference"/> class.
        /// </summary>
        /// <param name="target">Target.</param>
        public WeakReference( object target ) {
            Target = target;
        }

        /// <summary>
        /// Gets or sets the target.
        /// </summary>
        /// <value>The target.</value>
        public virtual object Target { get; set; }
    }

}
