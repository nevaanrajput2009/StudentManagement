using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using UI.Web.Helpers;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    [UserAuthorizationActionFilter]
    public class StudentController : Controller
    {
        private readonly IConfiguration Configuration;
        public StudentController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IActionResult List()
        {
            var studentList = new List<StudentModel>();

            string connString = Configuration.GetConnectionString("Myconnection");
            var _sqlConnection = new SqlConnection(connString);
            var _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;

            _sqlCommand.Connection.Open();
            _sqlCommand.CommandText = "sp_GetAllStudent";
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            // Call Read before accessing data.
            while (reader.Read())
            {
                var studentModel = new StudentModel();
                studentModel.StudentId = reader.GetInt32("StudentId");
                studentModel.RollNumber = reader.GetInt32("RollNum");
                studentModel.FirstName = reader.GetString("Name");
                studentModel.LastName = reader.GetString("LastName");
                studentModel.Gender = reader.GetString("Gender");
                studentList.Add(studentModel);
            }

            // Call Close when done reading.
            reader.Close();

            _sqlCommand.Connection.Close();
            return View(studentList);  
        }

        public IActionResult Create()
        {
            var model = new StudentModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(StudentModel model)
        {
            try
            {
                string connString = Configuration.GetConnectionString("Myconnection");
                var _sqlConnection = new SqlConnection(connString);
                var _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnection;

                _sqlCommand.Connection.Open();
                _sqlCommand.CommandText = "sp_InsertStudent";
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.Add(new SqlParameter("@Name", model.FirstName));
                _sqlCommand.Parameters.Add(new SqlParameter("@LastName", model.LastName));
                _sqlCommand.Parameters.Add(new SqlParameter("@RollNum", model.RollNumber));
                _sqlCommand.Parameters.Add(new SqlParameter("@Gender", model.Gender));
                _sqlCommand.ExecuteNonQuery();
                ////var _sqlDataAdapter = new SqlDataAdapter(_sqlCommand);
                ////var _dtSet = new DataSet();
                ////_sqlDataAdapter.Fill(_dtSet);

                _sqlCommand.Connection.Close();
                TempData["SuccessAlertMessage"] = "Student created Successfully";
            }
            catch (Exception)
            {

                TempData["ErrorAlertMessage"] = "Unable to create student";
            }
           
            return RedirectToAction("List");
        }
    }
}
