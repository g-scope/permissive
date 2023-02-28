using Permissive.Data;
using Permissive.Generator;

namespace Permissive.Controller {
    public class ExchangeController {
        public readonly Guid id = Guid.NewGuid();
        private ExchangeData exchange_data = ExchangeGenerator.CreateExchangeData();

        public void authorize_exchange() {
            exchange_data.update_client_authorized(true);
            exchange_data.update_guard_authorized(true);
        }

        public bool publish_data(byte[] data) {
            return exchange_data.assign_data(
                data: data
            );
        }

        public ExchangeData get_exchange_data() {
            return exchange_data;
        }

        public byte[] get_data() {
            return exchange_data.get_data();
        }
    }
}