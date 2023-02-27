using Permissive.Data;

namespace Permissive.Generator {
    public class ClientGenerator {
        public static ClientData CreateClientData(string ip, int port = 0) {
            return new ClientData(
                ip: ip,
                port: port
            );
        }
    }
}