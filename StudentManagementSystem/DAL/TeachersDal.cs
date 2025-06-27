using MySql.Data.MySqlClient;
using student_management_system.DAL;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.DAL
{
    internal class TeachersDal
    {
        public DataTable GetAllTeachers()
        {
            string query = @"SELECT 
                                id, first_name, last_name, gender, telephone_no, nic_no,
                                email_id, address, date_of_birth, date_of_appoint,
                                created_at, created_by, updated_at, updated_by, deleted_at, deleted_by
                             FROM teachers
                             ORDER BY last_name, first_name";

            return DbHelper.GetData(query);
        }

        public Teacher GetTeacherById(int teacherId)
        {
            string query = "SELECT * FROM teachers WHERE id = @teacherId";
            var parameter = new MySqlParameter("@teacherId", MySqlDbType.Int32) { Value = teacherId };

            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Teacher
            {
                Id = Convert.ToInt32(row["id"]),
                FirstName = row["first_name"].ToString(),
                LastName = row["last_name"].ToString(),
                Gender = row["gender"].ToString(),
                Telephone = row["telephone_no"].ToString(),
                Nic = row["nic_no"].ToString(),
                Email = row["email_id"].ToString(),
                Address = row["address"].ToString(),
                DateOfBirth = Convert.ToDateTime(row["date_of_birth"]),
                DateOfAppoint = Convert.ToDateTime(row["date_of_appoint"]),
                CreatedAt = Convert.ToDateTime(row["created_at"]),
                CreatedBy = row["created_by"]?.ToString(),
                UpdatedAt = Convert.ToDateTime(row["updated_at"]),
                UpdatedBy = row["updated_by"]?.ToString(),
                DeletedAt = Convert.ToDateTime(row["deleted_at"]),
                DeletedBy = row["deleted_by"]?.ToString()
            };
        }

        public int AddTeacher(Teacher teacher)
        {
            string query = @"INSERT INTO teachers
                            (first_name, last_name, gender, telephone_no, nic_no, 
                             email_id, address, date_of_birth, date_of_appoint,
                             created_at, created_by)
                             VALUES
                            (@firstName, @lastName, @gender, @telephoneNo, @nicNo, 
                             @emailId, @address, @dob, @doa, @createdAt, @createdBy);
                             SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = teacher.FirstName },
                new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = teacher.LastName },
                new MySqlParameter("@gender", MySqlDbType.VarChar) { Value = teacher.Gender },
                new MySqlParameter("@telephoneNo", MySqlDbType.VarChar) { Value = teacher.Telephone },
                new MySqlParameter("@nicNo", MySqlDbType.VarChar) { Value = teacher.Nic },
                new MySqlParameter("@emailId", MySqlDbType.VarChar) { Value = teacher.Email },
                new MySqlParameter("@address", MySqlDbType.VarChar) { Value = teacher.Address },
                new MySqlParameter("@dob", MySqlDbType.Date) { Value = teacher.DateOfBirth },
                new MySqlParameter("@doa", MySqlDbType.Date) { Value = teacher.DateOfAppoint },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = teacher.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = teacher.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool UpdateTeacher(Teacher teacher)
        {
            string query = @"UPDATE teachers SET
                                first_name = @firstName,
                                last_name = @lastName,
                                gender = @gender,
                                telephone_no = @telephoneNo,
                                nic_no = @nicNo,
                                email_id = @emailId,
                                address = @address,
                                date_of_birth = @dob,
                                date_of_appoint = @doa,
                                updated_at = @updatedAt,
                                updated_by = @updatedBy
                             WHERE id = @id";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", MySqlDbType.Int32) { Value = teacher.Id },
                new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = teacher.FirstName },
                new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = teacher.LastName },
                new MySqlParameter("@gender", MySqlDbType.VarChar) { Value = teacher.Gender },
                new MySqlParameter("@telephoneNo", MySqlDbType.VarChar) { Value = teacher.Telephone },
                new MySqlParameter("@nicNo", MySqlDbType.VarChar) { Value = teacher.Nic },
                new MySqlParameter("@emailId", MySqlDbType.VarChar) { Value = teacher.Email },
                new MySqlParameter("@address", MySqlDbType.VarChar) { Value = teacher.Address },
                new MySqlParameter("@dob", MySqlDbType.Date) { Value = teacher.DateOfBirth },
                new MySqlParameter("@doa", MySqlDbType.Date) { Value = teacher.DateOfAppoint },
                new MySqlParameter("@updatedAt", MySqlDbType.DateTime) { Value = teacher.UpdatedAt },
                new MySqlParameter("@updatedBy", MySqlDbType.VarChar) { Value = teacher.UpdatedBy ?? "" }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteTeacher(int teacherId)
        {
            string query = @"DELETE FROM teachers 
                             WHERE id = @teacherId;";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@teacherId", MySqlDbType.Int32) { Value = teacherId }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
