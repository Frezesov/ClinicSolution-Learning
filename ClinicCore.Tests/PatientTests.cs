using Xunit;
using ClinicCore;
using System;

namespace ClinicCore.Tests
{
    public class PatientTests
    {
        [Fact]
        public void CalculateAge_ShouldReturnCorrectAge_WhenBirthdayPassed()
        {
            var patient = new Patient
            {
                BirthDate = DateTime.Today.AddYears(-20)
            };

            int age = patient.CalculateAge();

            Assert.Equal(20, age);
        }

        [Fact]
        public void CalculateAge_ShouldReturnOneYearLess_WhenBirthdayIsTomorrow()
        {
            var patient = new Patient
            {
                BirthDate = DateTime.Today.AddYears(-20).AddDays(1)
            };

            int result = patient.CalculateAge();

            Assert.Equal(19, result);
        }
    }
}
