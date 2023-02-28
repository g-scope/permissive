using Permissive.Data;

namespace Permissive.Generator {
    public class ExchangeGenerator {
        public static ExchangeData CreateExchangeData(params byte[] DefaultData) {
            return new ExchangeData(
                DefaultData: DefaultData
            );
        }
    }
}