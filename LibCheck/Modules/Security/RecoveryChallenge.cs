using Newtonsoft.Json;

namespace LibCheck.Modules.Security {
    internal class RecoveryChallenge : IDisposable {
        [JsonIgnore]
        private bool disposedValue;

        [JsonProperty]
        internal required string Salt { get; set; }

        [JsonProperty]
        internal required string Challenge { get; set; }

        protected virtual void Dispose(bool disposing) {
            if (!disposedValue) {
                if (disposing) {
                    Salt = "";
                    Challenge = "";
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
