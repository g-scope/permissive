using Permissive.Data;

namespace Permissive.Generator {
    public class RequestGenerator {
        public static RequestData CreateRequestData(string name, string type) {
            return new RequestData(
                name: name,
                type: type
            );
        }
    }
}