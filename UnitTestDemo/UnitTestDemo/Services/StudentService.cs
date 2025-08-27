namespace UnitTestDemo.Services
{
    public class StudentService
    {
        public string GetFullName(string firstName, string lastName)
        {
            return $"{firstName} {lastName}";
        }

        public bool IsPassedTheExam(int mark)
        {
            if (mark >= 75) 
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }
        }

        public int GetStudentId(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email Should Be Required");
            }

            return 10;
        }
    }
}
