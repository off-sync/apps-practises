using System.ComponentModel.DataAnnotations;

namespace OffSync.Apps.Practises.Tests.Validation
{
    public class ValidationModel
    {
        [Required]
        public string Name { get; set; }
    }
}
