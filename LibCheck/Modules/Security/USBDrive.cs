using Newtonsoft.Json;

namespace LibCheck.Modules.Security {
    internal class USBDrive : IDisposable {
        [JsonIgnore]
        private bool disposedValue;

        [JsonIgnore]
        internal bool IsDisposed { get => disposedValue; }

        [JsonProperty]
        internal required string DriveName { get; set; }

        [JsonProperty]
        internal required string Guid { get; set; }

        [JsonProperty]
        internal required string Salt { get; set; }

        [JsonProperty]
        internal required string Hash { get; set; }


        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    DriveName = string.Empty;
                    Salt = string.Empty;
                    Hash = string.Empty;
                    Guid = string.Empty;
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
