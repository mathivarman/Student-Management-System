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
    internal class StudentSubjectDal
    {
        public DataTable GetAllStudentSubjects()
        {
            string query = @"SELECT 
                                id, student_id, subject_id, 
                                created_at, created_by, 
                                updated_at, updated_by, 
                                deleted_at, deleted_by 
                             FROM student_subject
                             WHERE deleted_at IS NULL";

            return DbHelper.GetData(query);
        }

        public StudentSubject GetStudentSubjectById(int id)
        {
            string query = "SELECT * FROM student_subject WHERE id = @id";
            var parameter = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };

            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new StudentSubject
            {
                Id = Convert.ToInt32(row["id"]),
                StudentId = Convert.ToInt32(row["student_id"]),
                SubjectId = Convert.ToInt32(row["subject_id"]),
                CreatedAt = Convert.ToDateTime(row["created_at"]),
                CreatedBy = row["created_by"]?.ToString(),
                UpdatedAt = Convert.ToDateTime(row["updated_at"]),
                UpdatedBy = row["updated_by"]?.ToString(),
                DeletedAt = Convert.ToDateTime(row["deleted_at"]),
                DeletedBy = row["deleted_by"]?.ToString()
            };
        }

        public int AddStudentSubject(StudentSubject ss)
        {
            string query = @"INSERT INTO student_subject
                            (student_id, subject_id, created_at, created_by)
                            VALUES
                            (@studentId, @subjectId, @createdAt, @createdBy);
                            SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = ss.StudentId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = ss.SubjectId },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = ss.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = ss.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool UpdateStudentSubject(StudentSubject ss)
        {
            string query = @"UPDATE student_subject SET
                                student_id = @studentId,
                                subject_id = @subjectId,
                                updated_at = @updatedAt,
                                updated_by = @updatedBy
                             WHERE id = @id";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", MySqlDbType.Int32) { Value = ss.Id },
                new MySqlParameter("@studentId", MySqlDbType.Int32) { Value = ss.StudentId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = ss.SubjectId },
                new MySqlParameter("@updatedAt", MySqlDbType.DateTime) { Value = ss.UpdatedAt },
                new MySqlParameter("@updatedBy", MySqlDbType.VarChar) { Value = ss.UpdatedBy ?? "" }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteStudentSubject(int id, string deletedBy)
        {
            string query = @"UPDATE student_subject 
                             SET deleted_at = @deletedAt, deleted_by = @deletedBy 
                             WHERE id = @id";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", MySqlDbType.Int32) { Value = id },
                new MySqlParameter("@deletedAt", MySqlDbType.DateTime) { Value = DateTime.Now },
                new MySqlParameter("@deletedBy", MySqlDbType.VarChar) { Value = deletedBy }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
