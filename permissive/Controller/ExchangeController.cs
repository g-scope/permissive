using Permissive.Data;
using Permissive.Generator;

namespace Permissive.Controller {
    public class ExchangeController {
        private readonly Guid id = Guid.NewGuid();
        private ExchangeData exchange_data;

        public ExchangeData GetExchangeData() {
            return exchange_data;
        }

        public bool IsAuthorized() {
            return exchange_data.IsAuthorized();
        }

        public string GetDataAsString() {
            return exchange_data.GetDataAsString();
        }

        public byte[] GetData() {
            return exchange_data.GetData();
        }

        public void UpdateAuthorized(bool authorized) {
            if (authorized) {
                exchange_data.GrantAuthorization();
            } else {
                exchange_data.DenyAuthorization();
            }
        }

        public bool PublishData(byte[] SecretData, params byte[] DefaultData) {
            return exchange_data.PublishData(
                SecretData: SecretData,
                DefaultData: DefaultData
            );
        }

        public ExchangeController(params byte[] DefaultData) {
            exchange_data = ExchangeGenerator.CreateExchangeData(
                DefaultData: DefaultData
            );
        }
    }
}