using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using mvcproject.Models;

namespace mvcproject.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection con;

        private void connection()
        {
            string constring = "Server=DESKTOP-UR9NSK5\\SQLEXPRESS; Database=ArtGalleryManagement; Integrated Security=True;";
            con = new SqlConnection(constring);
        }
        private readonly IConfiguration configuration;

        public object FormsAuthentication { get; private set; }

        public HomeController(IConfiguration config)
        {
            this.configuration = config;
        }


        public ActionResult Index(string input1)
        {
            return View();
        }
        
        public IActionResult Painting()
        {
            List<Models.ArtWork> list = new List<Models.ArtWork>();
            try
            {
                connection();
                // runs stored procedure and returns data to main page
                
                    String sql = @"select * from [ArtWork] where category_id = 1";
                  

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand(sql, con);

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        var pub = new Models.ArtWork();
                        pub.art_id = int.Parse(row["art_id"].ToString());
                        pub.title = row["title"].ToString();
                        pub.price = decimal.Parse(row["price"].ToString());
                        pub.file_location = row["file_location"].ToString();
                        pub.category_id = int.Parse(row["category_id"].ToString());
                        
                        list.Add(pub);
                        
                        
                    }
                
                return View(list);
            }
            catch
            {
                return View("Error");
            }

        }
    
        public IActionResult Sculpture()
        {
            List<ArtWork> list = new List<ArtWork>();
            try
            {
                connection();
                // runs stored procedure and returns data to main page
                
                    String sql = @"select * from [ArtWork] WHERE category_id = 2";
                   

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand(sql, con);

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        var pub = new Models.ArtWork();
                        pub.art_id = int.Parse(row["art_id"].ToString());
                        pub.title = row["title"].ToString();
                        pub.price = decimal.Parse(row["price"].ToString());
                        pub.file_location = row["file_location"].ToString();
                        pub.category_id = int.Parse(row["category_id"].ToString());
                       
                        list.Add(pub);
                        
                        
                    }
                
                
                return View(list);
            }
            catch
            {
                return View("Error");
            }
        }
   
        public IActionResult Music()
        {
            List<Models.ArtWork> list = new List<Models.ArtWork>();
            try
            {
                connection();
                // runs stored procedure and returns data to main page
                
                    String sql = @"select * from [ArtWork]";
                    

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = new SqlCommand(sql, con);

                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        var pub = new Models.ArtWork();
                        pub.art_id = int.Parse(row["art_id"].ToString());
                        pub.title = row["title"].ToString();
                        pub.price = decimal.Parse(row["price"].ToString());
                        pub.file_location = row["file_location"].ToString();
                        pub.category_id = int.Parse(row["category_id"].ToString());
                        if (pub.category_id == 2)
                        {
                            list.Add(pub);
                        }

                    }
                

                return View(list);
            }
            catch
            {
                return View("Error");
            }
        }
        [HttpGet]
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(User user)
        {
            if (loginisvalid(user.email, user.password))
            {
                
                return RedirectToAction("Index", "Admin");

            }
            else
            {

                ModelState.AddModelError("", "Your Email and password is incorrect");
                
            }
            return View(user);

        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            try {
                if (ModelState.IsValid)
                {
                    if (!isUserExist(user.email))
                    {
                        connection();
                        string query = "INSERT INTO [dbo].[User] VALUES (@name,@surname,@phone_number, @email, @age,@city,@country,@street,@password)";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@name", user.name);
                        cmd.Parameters.AddWithValue("@surname", user.surname);
                        cmd.Parameters.AddWithValue("@phone_number", user.phone_number);
                        cmd.Parameters.AddWithValue("@email", user.email);
                        cmd.Parameters.AddWithValue("@age", user.age);
                        cmd.Parameters.AddWithValue("@city", user.city);
                        cmd.Parameters.AddWithValue("@country", user.country);
                        cmd.Parameters.AddWithValue("@street", user.street);
                        cmd.Parameters.AddWithValue("@password", user.password);
                        cmd.CommandType = CommandType.Text;

                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        con.Close();

                        if (i >= 1)
                            return RedirectToAction("login", "Home");
                        else
                            ModelState.AddModelError("", "something went wrong try later!");
                    }
                    else
                    {
                        ModelState.AddModelError("", "User with same email already exist!");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Data is not correct");
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
            }
            return View();
        }

        private bool loginisvalid(string email,string password)
        {


            connection();
            bool IsValid = false;
            string query = "select * from [User] where email=@email AND password=@password";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Open();
                int i = cmd.ExecuteNonQuery();
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    IsValid = true;
                }
            }
            return IsValid;
        }

        private bool isUserExist(string email)
        {
            connection();
            bool isUserExist = false;
            string query = "SELECT * FROM [dbo].[User] where email=@email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                isUserExist = true;
            }
            return isUserExist;
            
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult review(int id)
        {
            return View(new AdminController().GetUserAndProduct().Find(artmodel => artmodel.art_id == id));
        }
    }
}
