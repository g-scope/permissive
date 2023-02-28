namespace Permissive.Data {
    public class RequestData {
        private readonly Guid id = Guid.NewGuid();
        private string request_name = "";
        private string request_type = "";

        public string get_type() {
            return request_type;
        }

        public string get_name() {
            return request_name;
        }

        public Guid get_id() {
            return id;
        }

        public RequestData(string name = "unknown", string type = "unknown") {
            request_type = type;
            request_name = name;
        }
    }
}