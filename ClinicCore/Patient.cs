namespace ClinicCore
{
    public class Patient
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }

        public int CalculateAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;

            if (BirthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}