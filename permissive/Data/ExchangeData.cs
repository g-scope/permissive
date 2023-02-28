namespace Permissive.Data {
    public class ExchangeData {
        private readonly Guid id = Guid.NewGuid();
        private bool client_authorized = false;
        private bool guard_authorized = false;
        private protected List<Byte> target_data = new List<Byte>();

        public void assign_data(List<Byte> data) {
            target_data = data;
        }

        public void update_client_authorized(bool authorized) {
            client_authorized = authorized;
        }

        public void update_guard_authorized(bool authorized) {
            guard_authorized = authorized;
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

        public List<Byte> get_data() {
            if (is_client_authorized() && is_guard_authorized()) {
                return target_data;
            }
            return new List<Byte>();
        }
    }
}