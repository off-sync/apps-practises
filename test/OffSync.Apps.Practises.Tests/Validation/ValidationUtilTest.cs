using System.ComponentModel.DataAnnotations;

using NUnit.Framework;

using OffSync.Apps.Practises.Validation;

namespace OffSync.Apps.Practises.Tests.Validation
{
    [TestFixture]
    public class ValidationUtilTest
    {
        [Test]
        public void ValidateShouldThrowExceptionOnNullValue()
        {
            Assert.That(
                () => ValidationUtil.Validate(null),
                Throws.ArgumentNullException);

            Assert.That(
                ValidationUtil.TryValidate(
                    null,
                    out _),
                Is.False);
        }

        [Test]
        public void ValidateShouldThrowExceptionOnMissingRequiredProperty()
        {
            var value = new ValidationModel();

            Assert.That(
                () => ValidationUtil.Validate(value),
                Throws.TypeOf<ValidationException>());

            Assert.That(
                ValidationUtil.TryValidate(
                    value,
                    out _),
                Is.False);
        }

        [Test]
        public void ValidateShouldAcceptValidModel()
        {
            var value = new ValidationModel()
            {
                Name = "name",
            };

            ValidationUtil.Validate(value);
            Assert.That(
                ValidationUtil.TryValidate(
                    value,
                    out _),
                Is.True);
        }
    }
}
