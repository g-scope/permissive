namespace Permissive.Validator {
    public class StatusValidator {
        public static bool IsStatusCodeValid(int status) {
            if (status == 0) {
                return false;
            }
            return true;
        }

        public static bool IsStatusMessageValid(string message) {
            if (message == "") {
                return false;
            }
            return true;
        }
    }
}