using PUPPointsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUPPointsDataServices
{
    //We will use in memory dummy data 
    public class StudentDataService
    {
        List<Student> dummyStudents = new List<Student>();

        public StudentDataService()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {
            Point defaultPoints = new Point 
            {
                value = 100,
                category = "new member rewards"
            };

            Student student1 = new Student
            {
                studentNumber = "BN-00066-2011",
                points = defaultPoints
            };

            Student student2 = new Student
            {
                studentNumber = "BN-00066-2012",
                points = defaultPoints
            };

            Student student3 = new Student
            {
                studentNumber = "BN-00066-2013",
                points = defaultPoints
            };

            dummyStudents.Add(student1);
            dummyStudents.Add(student2);
            dummyStudents.Add(student3);
        }

        //Return Student data if student number is found else return null or empty student data
        public Student GetStudent(string studentNumber)
        {
            Student foundStudent = new Student();

            foreach (var dummy in dummyStudents)
            {
                if (studentNumber == dummy.studentNumber)
                {
                    foundStudent = dummy;
                }
            }

            return foundStudent;
        }

    }
}
