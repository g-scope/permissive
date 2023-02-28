using Permissive.Data;
using Permissive.Controller;

namespace Permissive.Generator {
    public class ExchangeGenerator {
        public static ExchangeData CreateExchangeData() {
            return new ExchangeData();
        }

        public static ExchangeController CreateExchangeController() {
            return new ExchangeController();
        }
    }
}