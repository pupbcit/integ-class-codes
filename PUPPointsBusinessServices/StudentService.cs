using PUPPointsDataServices;

namespace PUPPointsBusinessServices
{
    public class StudentService
    {
        public bool VerifyStudent(string studentNumber)
        {
            //add more validation
            StudentDataService dataService = new StudentDataService();
            var result = dataService.GetStudent(studentNumber);

            return result.studentNumber != null ? true : false;
        }
    }
}
