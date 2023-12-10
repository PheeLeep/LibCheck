using Newtonsoft.Json;

namespace LibCheck.Modules.Security {
    internal class LibrarianToken : IDisposable {
        [JsonIgnore]
        private bool disposedValue;

        [JsonIgnore]
        internal bool IsDisposed { get => disposedValue; }

        [JsonProperty]
        internal required string Username { get; set; }
        [JsonProperty]
        internal required string Salt { get; set; }
        [JsonProperty]
        internal required string Hash { get; set; }
        [JsonProperty]
        internal required string SQLCipherDBKeySalt { get; set; }
        [JsonProperty]
        internal required string SQLCipherDBKey { get; set; }


        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    Username = string.Empty;
                    Salt = string.Empty;
                    Hash = string.Empty;
                    SQLCipherDBKey = string.Empty;
                    SQLCipherDBKeySalt = string.Empty;
                }

                disposedValue = true;
            }
        }

        public void Dispose() {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
