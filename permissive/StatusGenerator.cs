using Permissive.Data;

namespace Permissive.Generator {
    public class StatusGenerator {
        public static StatusData CreateStatusData(int status = 0, string message = "") {
            return new StatusData(
                status: status,
                message: message
            );
        }
    }
}