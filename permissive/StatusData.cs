using Permissive.Validator;

namespace Permissive.Data {
    public class StatusData {
        private readonly Guid id = Guid.NewGuid();
        private string status_message = "";
        private int status_code = 0;

        public int get_code() {
            return status_code;
        }

        public string get_message() {
            return status_message;
        }

        public (int status, string message) get_status() {
            return (status: status_code, message: status_message);
        }

        public void set_status(int status, string message = "") {
            status_code = status;

            if (StatusValidator.IsStatusMessageValid(message)) {
                status_message = message;
            }
        }

        public StatusData(int status = 0, string message = "") {
            set_status(
                status: status,
                message: message
            );
            
        }
    }
}