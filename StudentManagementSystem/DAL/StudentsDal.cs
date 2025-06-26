using MySql.Data.MySqlClient;
using student_management_system.DAL;
using StudentManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.DAL
{
    internal class StudentsDal
    {
        public DataTable GetAllStudents()
        {
            string query = @"SELECT 
                                id, admission_no, first_name, last_name, gender, 
                                telephone_no, email_id, address, date_of_birth, 
                                date_of_admission, grade_id, created_at, created_by, 
                                updated_at, updated_by, deleted_at, deleted_by 
                             FROM students 
                             ORDER BY first_name";

            return DbHelper.GetData(query);
        }

        public Student GetStudentById(int studentId)
        {
            string query = @"SELECT * FROM students WHERE id = @studentId";
            var parameter = new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = studentId };

            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new Student
            {
                Id = Convert.ToInt32(row["id"]),
                AdmissionNo = row["admission_no"].ToString(),
                FirstName = row["first_name"].ToString(),
                LastName = row["last_name"].ToString(),
                Gender = row["gender"].ToString(),
                Telephone = row["telephone_no"].ToString(),
                Email = row["email_id"].ToString(),
                Address = row["address"].ToString(),
                DateOfBirth = Convert.ToDateTime(row["date_of_birth"]),
                DateOfAdmission = Convert.ToDateTime(row["date_of_admission"]),
                GradeId = Convert.ToInt32(row["grade_id"]),
                CreatedAt = Convert.ToDateTime(row["created_at"]),
                CreatedBy = row["created_by"]?.ToString(),
                UpdatedAt = Convert.ToDateTime(row["updated_at"]),
                UpdatedBy = row["updated_by"]?.ToString(),
                DeletedAt = Convert.ToDateTime(row["deleted_at"]),
                DeletedBy = row["deleted_by"]?.ToString()
            };
        }

        public int AddStudent(Student student)
        {
            string query = @"INSERT INTO students 
                            (admission_no, first_name, last_name, gender, telephone_no, 
                             email_id, address, date_of_birth, date_of_admission, grade_id, 
                              created_by) 
                             VALUES 
                            (@admissionNo, @firstName, @lastName, @gender, @telephoneNo, 
                             @emailId, @address, @dob, @doa, @gradeId, @createdBy);
                             SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@admissionNo", MySqlDbType.VarChar) { Value = student.AdmissionNo },
                new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = student.FirstName },
                new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = student.LastName },
                new MySqlParameter("@gender", MySqlDbType.VarChar) { Value = student.Gender },
                new MySqlParameter("@telephoneNo", MySqlDbType.VarChar) { Value = student.Telephone },
                new MySqlParameter("@emailId", MySqlDbType.VarChar) { Value = student.Email },
                new MySqlParameter("@address", MySqlDbType.VarChar) { Value = student.Address },
                new MySqlParameter("@dob", MySqlDbType.Date) { Value = student.DateOfBirth },
                new MySqlParameter("@doa", MySqlDbType.Date) { Value = student.DateOfAdmission },
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = student.GradeId },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = student.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool UpdateStudent(Student student)
        {
            string query = @"UPDATE students SET
                                admission_no = @admissionNo,
                                first_name = @firstName,
                                last_name = @lastName,
                                gender = @gender,
                                telephone_no = @telephoneNo,
                                email_id = @emailId,
                                address = @address,
                                date_of_birth = @dob,
                                date_of_admission = @doa,
                                grade_id = @gradeId,
                                updated_at = @updatedAt,
                                updated_by = @updatedBy
                             WHERE id = @studentId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = student.Id },
                new MySqlParameter("@admissionNo", MySqlDbType.VarChar) { Value = student.AdmissionNo },
                new MySqlParameter("@firstName", MySqlDbType.VarChar) { Value = student.FirstName },
                new MySqlParameter("@lastName", MySqlDbType.VarChar) { Value = student.LastName },
                new MySqlParameter("@gender", MySqlDbType.VarChar) { Value = student.Gender },
                new MySqlParameter("@telephoneNo", MySqlDbType.VarChar) { Value = student.Telephone },
                new MySqlParameter("@emailId", MySqlDbType.VarChar) { Value = student.Email },
                new MySqlParameter("@address", MySqlDbType.VarChar) { Value = student.Address },
                new MySqlParameter("@dob", MySqlDbType.Date) { Value = student.DateOfBirth },
                new MySqlParameter("@doa", MySqlDbType.Date) { Value = student.DateOfAdmission },
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = student.GradeId },
                new MySqlParameter("@updatedAt", MySqlDbType.DateTime) { Value = student.UpdatedAt  },
                new MySqlParameter("@updatedBy", MySqlDbType.VarChar) { Value = student.UpdatedBy  }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteStudent(int studentId)
        {
            string query = @"DELETE
                            FROM
                            `student_management_system`.`students`
                            WHERE id = @studentId";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = studentId },

            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
