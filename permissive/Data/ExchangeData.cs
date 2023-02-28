namespace Permissive.Data {
    public class ExchangeData {
        private readonly Guid id = Guid.NewGuid();
        private bool client_authorized = false;
        private bool guard_authorized = false;
        private bool data_assigned = false;
        private byte[] target_data = new byte[] {};

        public void update_client_authorized(bool authorized) {
            client_authorized = authorized;
        }

        public void update_guard_authorized(bool authorized) {
            guard_authorized = authorized;
        }

        public bool assign_data(byte[] data) {
            if (data_assigned is false) {
                target_data = data;
                data_assigned = true;
                return true;
            }
            return false;
        }

        public bool is_exchange_authorized() {
            return is_client_authorized() && is_guard_authorized();
        }

        public bool is_client_authorized() {
            return client_authorized;
        }

        public bool is_guard_authorized() {
            return guard_authorized;
        }

        public Guid get_id() {
            return id;
        }

        public byte[] get_data() {
            if (is_exchange_authorized()) {
                return target_data;
            }
            return new byte[] {};
        }
    }
}