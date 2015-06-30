using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace J_eTech_International_Interview_Phase_2.Segment_5
{
    public static class dbCon
    {
        static public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\myMobileApps\J-eTech International Interview Phase 2\J-eTech International Interview Phase 2\Segment 5\dnQueensUni.mdf;Integrated Security=True");

    }

    public class StudentClass
    {
        public static string name;
        public static string dob;
        public static decimal gpa;
        public static bool active;
        static public void AllStudents(DataGridView gridview)
        {
            try
            {
                dbCon.con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SelectStudents", dbCon.con);
                DataTable ds = new DataTable();
                da.Fill(ds);
                gridview.DataSource = ds;
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                dbCon.con.Close();
            }
        }

        static public void StudentInsert(string Name, string DOB, double GradePointAvg, bool Active)
        {
            try
            {
                dbCon.con.Open();
                SqlCommand cmd = new SqlCommand("InsertStudent", dbCon.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Name", Name);
                cmd.Parameters.Add("@DOB", DOB);
                cmd.Parameters.Add("@GradePointAvg", GradePointAvg);
                cmd.Parameters.Add("@Active", Active);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException exception)
            {
                //MessageBox.Show(exception.ToString());
            }
            finally
            {
                dbCon.con.Close();
            }

        }
    }
}
