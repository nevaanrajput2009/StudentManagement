using Microsoft.AspNetCore.Mvc;
using UI.WebAPI.Model;

namespace UI.WebAPI.Controllers
{
    [ApiController]
    [Route("student")]
    public class StudentController : ControllerBase
    { 
        private static readonly StudentSummary[] StudentNames = new StudentSummary[]
        {
            new StudentSummary { RollNumber=1,FirstName="Saurabh",LastName="Rajput",Gender="Male" },
            new StudentSummary { RollNumber=2,FirstName="Anant",LastName="Kumar",Gender="Male" },
            new StudentSummary { RollNumber=3,FirstName="AA",LastName="111",Gender="FeMale" },
            new StudentSummary { RollNumber=4,FirstName="BB",LastName="Demo2",Gender="FeMale" },
            new StudentSummary { RollNumber=5,FirstName="CC",LastName="Demo3",Gender="Male" },
        };

        [HttpGet]
        public IEnumerable<StudentSummary> GetStudentList()
        {
            return StudentNames;
        }

        [HttpPost]
        public StudentSummary CreateStudent(StudentSummary student)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{rollNumber}")]
        public StudentSummary GetStudent(int rollNumber)
        {
            return StudentNames.First(x => x.RollNumber == rollNumber);
        }
    }
}