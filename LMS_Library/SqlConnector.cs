using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LMS_Library
{
    public class SqlConnector
    {
        public static string connectionString = "Server=DESKTOP-GB26U6N\\SQLEXPRESS;Database=LMS;Trusted_Connection=True;";

        private SqlConnection connection = new SqlConnection();
        private SqlCommand command = new SqlCommand();
        private SqlDataAdapter adapter = new SqlDataAdapter();
        private SqlDataReader reader;
        private SqlTransaction dbTrasaction;
        private string sqlQuery, output = "";

        //create function that reads login data from the database and store it in LoginModel
        public SqlConnector()
        {

        }
        public void createConn()
        {

            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void closeConn()
        {
            connection.Close();
            //MessageBox.Show("Connection CLosed");
        }

        public void readDataThroughAdapter(string query, DataTable tableName)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    createConn();
                }
                command.Connection = connection;
                command.CommandText = query;
                command.CommandType = CommandType.Text;

                adapter = new SqlDataAdapter(command);
                adapter.Fill(tableName);


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Execute Query and read data from database
        public class InsertData : SqlConnector
        {
            //Login
            public int login(string username, string password, string type)
            {
                string user_db, pass_db, type_db;
                int ID = 0;
                LoginModel lm = new LoginModel();
                createConn();
                sqlQuery = "Select * from Login WHERE Username = '" + username +
                    "' AND Password = '" + password +
                    "' AND User_Type = '" + type + "'";
                try
                {

                    command = new SqlCommand(sqlQuery, connection);
                    reader = command.ExecuteReader();

                    reader.Read();
                    ID = int.Parse(reader[0].ToString());

                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("Exception\r\n" + e.Message);
                }
                closeConn();
                return ID;
            }

            //Add Student
            public void AddStudent(StudentModel std)
            {
                createConn();
                try
                {

                    command = new SqlCommand("spLogin_Insert", connection);

                    command.CommandType = CommandType.StoredProcedure;

                    //SqlParameter login_id_param = new SqlParameter("@id", SqlDbType.Int);
                    //login_id_param.Direction = ParameterDirection.Output;
                    //command.Parameters.Add(login_id_param);
                    command.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value =std.username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = std.password;
                    //command.Parameters.AddWithValue("@password", tm.password);
                    //command.Parameters.AddWithValue("@username", tm.username);
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = "student";
                    command.ExecuteNonQuery();
                    //int loginID = (int)login_id_param.Value;
                    int User_ID = int.Parse(command.Parameters["@id"].Value.ToString());

                    MessageBox.Show("Login ID = " + User_ID.ToString());

                    command = new SqlCommand("Student_Insert", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@FirstName", std.FirstName);
                    command.Parameters.AddWithValue("@LastName", std.LastName);                    
                    command.Parameters.AddWithValue("@Phone_number", std.Contact);
                    command.Parameters.AddWithValue("@Email", std.Email);
                    command.Parameters.AddWithValue("@User_ID", User_ID);

                    command.ExecuteNonQuery();


                    MessageBox.Show("Successfully Submitted");

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                closeConn();
            }

            //AddCourse
            public void AddCourse(CourseModel cm)
            {
                createConn();
                try
                {
                    command = new SqlCommand("Course_Insert", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@CourseCode", cm.Course_ID);
                    command.Parameters.AddWithValue("@Course_Name", cm.Course_Name);
                    command.Parameters.AddWithValue("@Category", cm.Category);

                    command.ExecuteNonQuery();
                    MessageBox.Show("SUCCESS");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
            }

            //Add Teacher
            public void AddTeacher(TeacherModel tm)
            {
                //            nvarchar(30),
                //@LastName nvarchar(30),
                //@Contact nvarchar(20),
                //@Email nvarchar(50),
                //   @Department nvarchar(30),
                
                createConn();
                try
                {
                    command = new SqlCommand("spLogin_Insert", connection);

                    command.CommandType = CommandType.StoredProcedure;

                    //SqlParameter login_id_param = new SqlParameter("@id", SqlDbType.Int);
                    //login_id_param.Direction = ParameterDirection.Output;
                    //command.Parameters.Add(login_id_param);
                    command.Parameters.Add("@id", SqlDbType.Int).Direction = ParameterDirection.Output;

                    command.Parameters.Add("@username", SqlDbType.NVarChar).Value = tm.username;
                    command.Parameters.Add("@password", SqlDbType.NVarChar).Value = tm.password;
                    //command.Parameters.AddWithValue("@password", tm.password);
                    //command.Parameters.AddWithValue("@username", tm.username);
                    command.Parameters.Add("@type", SqlDbType.NVarChar).Value = "teacher";
                    command.ExecuteNonQuery();
                    //int loginID = (int)login_id_param.Value;
                    int User_ID = int.Parse(command.Parameters["@id"].Value.ToString());

                    MessageBox.Show("Login ID = " + User_ID.ToString());

                    command = new SqlCommand("teacher_insert", connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@firstname", tm.FirstName);
                    command.Parameters.AddWithValue("@lastname", tm.LastName);
                    command.Parameters.AddWithValue("@contact", tm.Contact);
                    command.Parameters.AddWithValue("@email", tm.Email);
                    command.Parameters.AddWithValue("@LoginID", User_ID);

                    command.ExecuteNonQuery();


                    MessageBox.Show("Successfully Submitted");

                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

                closeConn();
            }

            //Allocate Course
            public void AllocateCourse(int teacher_ID, int class_ID, string course_ID)
            {
                createConn();
                try
                {
                    command = new SqlCommand("AllocateClass", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("TID", teacher_ID);
                    command.Parameters.AddWithValue("CID", class_ID);
                    command.Parameters.AddWithValue("CrID", course_ID);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Data Added Successfully");
                }
                catch (Exception e)
                {
                    MessageBox.Show("OHOOO\r\n" + e.Message);
                }
                closeConn();
            }

            public bool UploadMaterial(MaterialModel m)
            {
                createConn();
                try
                {
                    string Material_Type = m.Material_Type;
                    string Course_ID = m.Course_ID;

                    command = new SqlCommand("spMaterial_Upload", connection);
                    command.CommandType = CommandType.StoredProcedure;                   
                    command.Parameters.Add("@Material_Type", SqlDbType.NVarChar).Value = Material_Type;
                    command.Parameters.Add("@Course_ID", SqlDbType.Int).Value = Course_ID;
                    command.ExecuteNonQuery();
                    closeConn();
                    return true;

                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }

            public bool UploadAssignment(AssignmentModel m, DateTime d)
            {
                createConn();
                try
                {

                   

                    string Course_ID = m.Course_ID;

                    command = new SqlCommand("spUploadAssignment", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add("@Course_ID", SqlDbType.NVarChar).Value = Course_ID;
                    command.Parameters.AddWithValue("@Date", SqlDbType.DateTime).Value = d;

                    command.ExecuteNonQuery();
                    closeConn();
                    return true;


                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);

                }




                return true;
            }


        }

        public class GetData : SqlConnector
        {
            /// <summary>
            /// Get Courses by department
            /// </summary>
            /// <param name="cat"></param>
            /// <returns></returns>
            public List<CourseModel> GetCourses(string cat)
            {
                List<CourseModel> lcm = new List<CourseModel>();
                CourseModel cmd;
                createConn();
                try
                {
                    command = new SqlCommand("spCourses_GetByDep", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Category", cat);

                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        cmd = new CourseModel();
                        cmd.Course_ID = reader[0].ToString();
                        cmd.Course_Name = reader[1].ToString();
                        cmd.Category = cat;
                        lcm.Add(cmd);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return lcm;

            }

            /// <summary>
            /// Get Classes(Semester Section Department)
            /// </summary>
            /// <param name="cid"></param>
            /// <returns></returns>
            public List<ClassModel> GetClasses(string cid)
            {
                ClassModel cm;
                List<ClassModel> lcm = new List<ClassModel>();

                createConn();
                try
                {
                    command = new SqlCommand("spClass_GetByDep", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@cid", cid);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        cm = new ClassModel();
                        cm.Class_ID = int.Parse(reader[0].ToString());
                        cm.Teacher_ID = int.Parse(reader[2].ToString());
                        cm.Start_Date = DateTime.Parse(reader[3].ToString());
                        cm.End_Date = DateTime.Parse(reader[4].ToString());
                        cm.Course_Term = reader[5].ToString();
                        cm.Course_ID = cid;
                        lcm.Add(cm);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                closeConn();

                return lcm;
            }
            
            public TeacherModel GetTeacher_GetByLoginID(int User_ID)
            {
                TeacherModel tm = new TeacherModel();

                createConn();
                try
                {
                    command = new SqlCommand("spTeacher_GetByLoginID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@User_ID", User_ID);
                    reader = command.ExecuteReader();
                    reader.Read();

                    tm = new TeacherModel();
                    tm.Teacher_ID = int.Parse(reader[1].ToString());
                    tm.FirstName = reader[2].ToString();
                    tm.LastName = reader[3].ToString();
                    tm.Contact = reader[4].ToString();
                    tm.Email = reader[5].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();

                return tm;
            }

            public StudentModel Student_GetByLoginID(int User_ID)
            {
                StudentModel sm = new StudentModel();

                createConn();
                try
                {
                    command = new SqlCommand("spStudent_GetByUser_ID", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@User_ID", User_ID);
                    reader = command.ExecuteReader();
                    reader.Read();

                    sm = new StudentModel();
                    sm.User_ID = int.Parse(reader[0].ToString());
                    sm.Student_ID = int.Parse(reader[1].ToString());
                    sm.FirstName = reader[2].ToString();
                    sm.LastName = reader[3].ToString();
                    sm.Contact = reader[4].ToString();
                    sm.Email = reader[5].ToString();

                    reader.Close();

                    LoginModel lm = new LoginModel();
                    lm = GetLoginInfo(sm.User_ID);
                    sm.username = lm.Username;
                    sm.password = lm.Password;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();

                return sm;
            }

            public LoginModel GetLoginInfo(int User_ID)
            {
                LoginModel lm = new LoginModel();
                createConn();
                try
                {
                    command = new SqlCommand("spGetLoginInfo", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", User_ID);
                    reader = command.ExecuteReader();
                    reader.Read();

                    lm.User_ID = User_ID;
                    lm.Username = reader[1].ToString();
                    lm.Password = reader[2].ToString();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                closeConn();
                return lm;

            }

            /// <summary>
            /// Get Students By Class 
            /// </summary>
            /// <param name="CM">Class Model which includes Semester Section & Depart</param>
            /// <returns></returns>
            public List<TeacherModel> SearchTeacher(string value, string sb)
            {
                List<int> deps = new List<int>();
                int ID = 0;
                string FName = "", LName = "";
                List<TeacherModel> ltm = new List<TeacherModel>();
                if (sb.ToUpper() == "ID")
                    ID = int.Parse(value);
                else if (sb.ToUpper() == "FIRSTNAME")
                    FName = value;
                else if (sb.ToUpper() == "LASTNAME")
                    LName = value;
                else { }

                createConn();
                try
                {
                    command = new SqlCommand("spTeacher_Search", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@ID", ID);
                    command.Parameters.AddWithValue("@FirstName", FName);
                    command.Parameters.AddWithValue("@LastName", LName);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        TeacherModel t = new TeacherModel();
                        t.User_ID = int.Parse(reader[0].ToString());
                        t.Teacher_ID = int.Parse(reader[1].ToString());
                        t.FirstName = reader[2].ToString();
                        t.LastName = reader[3].ToString();
                        t.Contact = reader[4].ToString();
                        t.Email = reader[5].ToString();
                        deps.Add(int.Parse(reader[6].ToString()));
                        //t.Department = reader[6].ToString();
                        
                        ltm.Add(t);
                    }
                    reader.Close();
                    for (int i = 0; i<ltm.Count; i++)
                    {
                        LoginModel lm = GetLoginInfo(ltm[i].User_ID);
                        ltm[i].username = lm.Username;
                        ltm[i].password = lm.Password;
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }


                return ltm;
            }


        }

    }
}
