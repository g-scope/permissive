namespace Permissive.Validator {
    public class ClientValidator {
        public static bool IsPortValid(int port) {
            if (port is 0) {
                return false;
            }
            return true;
        }

        public static bool IsIPValid(string ip) {
            // TODO
            // Create general handling of IP validation later.
            return true;
        }
    }
}