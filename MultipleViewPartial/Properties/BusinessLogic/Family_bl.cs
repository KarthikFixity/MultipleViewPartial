using System.Data.SqlClient;
using System.Data;
using MultipleViewPartial.Models;
namespace MultipleViewPartial.Properties.BusinessLogic
{
    public class Family_bl
    {


        public static bool Insertdata(Adress obj)
        {
            bool res = false;
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))

            {
                try
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("SP_INSERT_Address", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@DNo", obj.DNo);
                    cmd.Parameters.AddWithValue("@VillageName", obj.VillageName);
                    cmd.Parameters.AddWithValue("@Mandal", obj.Mandal);
                    cmd.Parameters.AddWithValue("@DistrictName", obj.DistrictName);
                    cmd.Parameters.AddWithValue("@StateName", obj.StateName);
                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        return res = true;
                    }
                    else
                    {
                        return res = false;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    con.Close();
                }
                return res = true;
            }

        }
        public static bool Insertdata1(Family obj)
        {
            bool res = false;
            var dbconfig = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();
            string dbconnectionstr = dbconfig["ConnectionStrings:DefaultConnection"];
            using (SqlConnection con = new SqlConnection(dbconnectionstr))

            {
                try
                {
                    con.Open();


                    SqlCommand cmd = new SqlCommand("SP_INSERT_Family", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", obj.ID);
                    cmd.Parameters.AddWithValue("@FatherName", obj.FatherName);
                    cmd.Parameters.AddWithValue("@MotherName", obj.MotherName);
                    cmd.Parameters.AddWithValue("@fatherOccupation", obj.fatherOccupation);
                    cmd.Parameters.AddWithValue("@motherOccupation", obj.motherOccupation);
                    cmd.Parameters.AddWithValue("@SisterName", obj.SisterName);
                    cmd.Parameters.AddWithValue("@BrotherName", obj.BrotherName);
                    cmd.Parameters.AddWithValue("@Mobile", obj.Mobile);

                    int x = cmd.ExecuteNonQuery();
                    if (x > 0)
                    {
                        return res = true;
                    }
                    else
                    {
                        return res = false;
                    }
                }
                catch (Exception)
                {

                }
                finally
                {
                    con.Close();
                }
                return res = true;
            }
        }
    }

   
}


