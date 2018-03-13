using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ClassSchedule
{
    public class ClassSchedule
    {
        #region Declarations
        public string sectName { get; set; }
        public string synonym { get; set; }
        public int credhrs { get; set; }
        public string title { get; set; }
        public int totalSeats { get; set; }
        public int remainSeats { get; set; }
        public string meetInfo { get; set; }
        public string room { get; set; }
        public string days { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string instFullName { get; set; }
        public string location { get; set; }
        #endregion

        #region Methods
        public static List<ClassSchedule> GetClassScheduleData()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["class_schedule"].ConnectionString);
            SqlCommand cmd = new SqlCommand("spClassScheduleDisplay", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            List<ClassSchedule> schedule = new List<ClassSchedule>();
            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    ClassSchedule cs = new ClassSchedule();
                    cs.sectName = rdr["SectionName"].ToString();
                    cs.synonym = rdr["Synonym"].ToString();
                    cs.credhrs = Convert.ToInt32(rdr["CreditHrs"]);
                    cs.title = rdr["Title"].ToString();
                    cs.totalSeats = Convert.ToInt32(rdr["TotalSeats"]);
                    cs.remainSeats = Convert.ToInt32(rdr["RemainingSeats"]);
                    cs.meetInfo = rdr["MeetInformation"].ToString();
                    cs.room = rdr["Room"].ToString();
                    cs.days = rdr["Days"].ToString();
                    cs.startTime = rdr["StartTime"].ToString();
                    cs.endTime = rdr["EndTime"].ToString();
                    cs.instFullName = rdr["InstFullName"].ToString();
                    cs.location = rdr["Location"].ToString();
                    schedule.Add(cs);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
            return schedule;
        }
        #endregion

    }
}