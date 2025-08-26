namespace UnitTestDemo.Services
{
    public class StudentService
    {
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }
    }
}
