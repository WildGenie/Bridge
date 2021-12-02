namespace System.Reflection {

    public class ManifestResourceInfo {
        private Assembly _containingAssembly;
        private string _containingFileName;
        private ResourceLocation _resourceLocation;

        public ManifestResourceInfo( Assembly containingAssembly, string containingFileName,
            ResourceLocation resourceLocation ) {
            _containingAssembly = containingAssembly;
            _containingFileName = containingFileName;
            _resourceLocation = resourceLocation;
        }

        public virtual Assembly ReferencedAssembly => _containingAssembly;

        public virtual string FileName => _containingFileName;

        public virtual ResourceLocation ResourceLocation => _resourceLocation;
    }

}
