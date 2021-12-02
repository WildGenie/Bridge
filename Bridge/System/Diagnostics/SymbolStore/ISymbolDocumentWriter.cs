namespace System.Diagnostics.SymbolStore {

    public interface ISymbolDocumentWriter {
        void SetSource( byte[] source );

        void SetCheckSum( Guid algorithmId, byte[] checkSum );
    }

}