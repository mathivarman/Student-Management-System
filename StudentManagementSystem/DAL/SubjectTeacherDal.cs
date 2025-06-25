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
    internal class SubjectTeacherDal
    {
        public DataTable GetAllSubjectTeachers()
        {
            string query = @"SELECT 
                                id, subject_id, teacher_id, created_at, created_by, 
                                updated_at, updated_by, deleted_at, deleted_by
                             FROM subject_teacher
                             WHERE deleted_at IS NULL";

            return DbHelper.GetData(query);
        }

        public SubjectTeacher GetById(int id)
        {
            string query = "SELECT * FROM subject_teacher WHERE id = @id";
            var parameter = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };

            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new SubjectTeacher
            {
                Id = Convert.ToInt32(row["id"]),
                SubjectId = Convert.ToInt32(row["subject_id"]),
                TeacherId = Convert.ToInt32(row["teacher_id"]),
                CreatedAt = Convert.ToDateTime(row["created_at"]),
                CreatedBy = row["created_by"]?.ToString(),
                UpdatedAt = Convert.ToDateTime(row["updated_at"]),
                UpdatedBy = row["updated_by"]?.ToString(),
                DeletedAt = Convert.ToDateTime(row["deleted_at"]),
                DeletedBy = row["deleted_by"]?.ToString()
            };
        }

        public int AddSubjectTeacher(SubjectTeacher st)
        {
            string query = @"INSERT INTO subject_teacher
                            (subject_id, teacher_id, created_at, created_by)
                            VALUES
                            (@subjectId, @teacherId, @createdAt, @createdBy);
                            SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = st.SubjectId },
                new MySqlParameter("@teacherId", MySqlDbType.Int32) { Value = st.TeacherId },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = st.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = st.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool UpdateSubjectTeacher(SubjectTeacher st)
        {
            string query = @"UPDATE subject_teacher SET
                                subject_id = @subjectId,
                                teacher_id = @teacherId,
                                updated_at = @updatedAt,
                                updated_by = @updatedBy
                             WHERE id = @id";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", MySqlDbType.Int32) { Value = st.Id },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = st.SubjectId },
                new MySqlParameter("@teacherId", MySqlDbType.Int32) { Value = st.TeacherId },
                new MySqlParameter("@updatedAt", MySqlDbType.DateTime) { Value = st.UpdatedAt },
                new MySqlParameter("@updatedBy", MySqlDbType.VarChar) { Value = st.UpdatedBy ?? "" }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteSubjectTeacher(int id, string deletedBy)
        {
            string query = @"UPDATE subject_teacher 
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
