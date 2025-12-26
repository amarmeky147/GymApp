using System.Data;
using Microsoft.Data.SqlClient;

namespace GymApp.Helpers_1
{
    public class GymRepository
    {
        public bool CheckInMember(int memberId)
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            using (SqlCommand cmd = new SqlCommand("sp_CheckInMember", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MemberID", memberId);

                SqlParameter resultParam = new SqlParameter("@Result", SqlDbType.Bit);
                resultParam.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(resultParam);

                con.Open();
                cmd.ExecuteNonQuery();

                return Convert.ToBoolean(resultParam.Value);
            }
        }

        public DataTable GetAttendanceByMember(int memberId)
        {
            string query = @"SELECT AttendanceID, MemberID, CheckInDate
                             FROM Attendance
                             WHERE MemberID = @MemberID
                             ORDER BY CheckInDate DESC";

            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@MemberID", memberId);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable GetAttendance()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM Attendance ORDER BY CheckInDate DESC", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
