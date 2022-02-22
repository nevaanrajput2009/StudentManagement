﻿using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using UI.Web.Helpers;
using UI.Web.Models;

namespace UI.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IConfiguration Configuration;

        public AccountController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IActionResult Login()
        {
            var model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            UserModel user = null;

            string connString = Configuration.GetConnectionString("Myconnection");
            var _sqlConnection = new SqlConnection(connString);
            var _sqlCommand = new SqlCommand();
            _sqlCommand.Connection = _sqlConnection;

            _sqlCommand.Connection.Open();
            _sqlCommand.CommandText = "sp_ValidateLogin";
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _sqlCommand.Parameters.Add(new SqlParameter("@UserName", model.UserName));
            _sqlCommand.Parameters.Add(new SqlParameter("@Password", model.Password));
            SqlDataReader reader = _sqlCommand.ExecuteReader();
            // Call Read before accessing data.
            while (reader.Read())
            {
                user = new UserModel();
                user.UserName = reader.GetString("UserName");
           }

            // Call Close when done reading.
            reader.Close();

            _sqlCommand.Connection.Close();

            if (user == null)
            {
                TempData["ErrorAlertMessage"] = "Invalid user name or password";
                return View(model); 
            }

            HttpContext.Session.SetObjectAsJson("CurrentUser", user);
            return RedirectToAction("Index", "Home");
        }

        [UserAuthorizationActionFilter]
        public IActionResult Privacy()
        {

            return View();
        }
    }
}
