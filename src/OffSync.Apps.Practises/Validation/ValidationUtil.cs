using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OffSync.Apps.Practises.Validation
{
    public static class ValidationUtil
    {
        public static void Validate(
            object value)
        {
            var context = BuildContext(value);

            Validator.ValidateObject(
                value,
                context,
                true);
        }

        public static bool TryValidate(
            object value,
            out ICollection<ValidationResult> results)
        {
            results = new List<ValidationResult>();

            if (value == null)
            {
                results.Add(
                    new ValidationResult(
                        $"{nameof(value)} must not be null"));

                return false;
            }

            var context = BuildContext(value);

            return Validator.TryValidateObject(
                value,
                context,
                results);
        }

        #region Helpers
        private static ValidationContext BuildContext(
            object value)
        {
            return new ValidationContext(
               value,
               serviceProvider: null,
               items: null);
        }
        #endregion
    }
}
