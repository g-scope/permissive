namespace Permissive.Data {
    public class ClientData {
        private readonly Guid id = Guid.NewGuid();
        private List<RequestData> requests = new List<RequestData>();

        public RequestData get_request(bool pop = false) {
            if (requests.Count is 0) {
                // TODO
                // Create handle for having no requests available.
            }

            return requests[0];
        }

        public bool next_request() {
            // TODO
            // html summary that next_request will not delete last request.
            if (requests.Count is 1) {
                return false;
            }

            requests.RemoveAt(0);

            return true;
        }

        public void add_request(RequestData request) {
            requests.Add(request);
        }

        public Guid get_id() {
            return id;
        }
    }
}