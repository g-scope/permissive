namespace Permissive.Data {
    public class ExchangeData {
        private readonly Guid id = Guid.NewGuid();
        private bool authorized = false;
        private bool data_retrieved = false;

        private byte[] exchange_data = new byte[] {};
        private byte[] default_data = new byte[] {};

        public void GrantAuthorization() {
            authorized = true;
        }


        public void DenyAuthorization() {
            authorized = false;
        }

        public bool PublishData(byte[] SecretData, params byte[] DefaultData) {
            if(data_retrieved is false) { 

                exchange_data = SecretData; 
                data_retrieved = true;

                if (DefaultData.Length != 0) {
                    default_data = DefaultData;
                }

                return true;
            }
            return false;
        }

        public Guid GetId() {
            return id;
        }

        public bool IsDataPublished() {
            return data_retrieved;
        }

        public bool IsAuthorized() {
            return authorized;
        }

        public byte[] GetData() {
            if (IsAuthorized()) {
                return exchange_data;
            }
            return default_data;
        }

        public string GetDataAsString() {
            if (IsAuthorized()) {
                return System.Text.Encoding.ASCII.GetString(
                    exchange_data
                );
            }
            return System.Text.Encoding.ASCII.GetString(
                default_data
            );
        }

        public ExchangeData(params byte[] DefaultData) {
            default_data = DefaultData;
        }
    }
}