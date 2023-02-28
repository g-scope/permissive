using Permissive.Data;
using Permissive.Controller;

namespace Permissive.Generator {
    public class ExchangeGenerator {
        public static ExchangeData CreateExchangeData(params byte[] DefaultData) {
            return new ExchangeData(
                DefaultData: DefaultData
            );
        }

        public static ExchangeController CreateExchangeController(params byte[] DefaultData) {
            return new ExchangeController(
                DefaultData: DefaultData
            );
        }
    }
}