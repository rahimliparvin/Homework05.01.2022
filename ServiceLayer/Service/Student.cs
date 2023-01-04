using ServiceLayer.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class Student : IStudent
    {
        public int GetCountByStudent()
        {
            throw new NotImplementedException();
        }

        public Student[] GetStudentAddress(string address)
        {
            throw new NotImplementedException();
        }

        public double GetStudentAverageByAges()
        {
            throw new NotImplementedException();
        }

        public Student[] GetStudentEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Student[] GetStudentIdenticalName(string name)
        {
            throw new NotImplementedException();
        }

        public Student[] GetStudentNameSurname(string name, string surname)
        {
            throw new NotImplementedException();
        }
    }
}

//      //  private Student[] GetAll()
//     /// <summary>
//     ///   {
//     /// </summary>
//            Student s1 = new Student
//            {
//                Id = 1,
//                Name = "BBB",
//            }
//        }
//    }
//}
