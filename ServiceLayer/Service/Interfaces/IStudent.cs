using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Interfaces
{
    public interface IStudent
    {
        int GetCountByStudent();
        double GetStudentAverageByAges();
        public Student[] GetStudentEmail(string  email);
        public Student[] GetStudentAddress(string address);
        public Student[] GetStudentNameSurname(string name,string surname);
        public Student[] GetStudentIdenticalName(string name);
    }
}
