using Permissive.Generator;
using Permissive.Validator;

namespace Permissive.Data {
    public class ClientData {
        private readonly Guid id = Guid.NewGuid();
        private StatusData status = StatusGenerator.CreateStatusData();
        private string client_base_ip = "";
        private string client_full_ip = "";
        private int client_port = 0;

        public StatusData get_status() {
            return status;
        }

        public string get_ip(bool with_port = false) {
            if (with_port) {
                return client_full_ip;
            }
            return client_base_ip;
        }

        public int get_port() {
            return client_port;
        }

        public ClientData(string ip, int port = 0) {
            client_base_ip = ip;

            if (ClientValidator.IsPortValid(port)) {
                client_port = port;
                client_full_ip = client_base_ip + ":" + port;
            } else {
                client_full_ip = client_base_ip;
            }
        }
    }
}