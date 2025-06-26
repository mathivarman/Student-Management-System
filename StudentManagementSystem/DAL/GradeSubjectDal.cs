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
    internal class GradeSubjectDal
    {
        public DataTable GetAllGradeSubjects()
        {
            string query = @"SELECT 
                                id, grade_id, subject_id, created_at, created_by, 
                                updated_at, updated_by, deleted_at, deleted_by
                             FROM grade_subject
                             WHERE deleted_at IS NULL";

            return DbHelper.GetData(query);
        }

        public GradeSubject GetGradeSubjectById(int id)
        {
            string query = "SELECT * FROM grade_subject WHERE id = @id";
            var parameter = new MySqlParameter("@id", MySqlDbType.Int32) { Value = id };

            DataTable dt = DbHelper.GetData(query, parameter);
            if (dt.Rows.Count == 0) return null;

            DataRow row = dt.Rows[0];
            return new GradeSubject
            {
                Id = Convert.ToInt32(row["id"]),
                GradeId = Convert.ToInt32(row["grade_id"]),
                SubjectId = Convert.ToInt32(row["subject_id"]),
                CreatedAt = Convert.ToDateTime(row["created_at"]),
                CreatedBy = row["created_by"]?.ToString(),
                UpdatedAt = Convert.ToDateTime(row["updated_at"]),
                UpdatedBy = row["updated_by"]?.ToString(),
                DeletedAt = Convert.ToDateTime(row["deleted_at"]),
                DeletedBy = row["deleted_by"]?.ToString()
            };
        }

        public int AddGradeSubject(GradeSubject gs)
        {
            string query = @"INSERT INTO grade_subject
                            (grade_id, subject_id, created_at, created_by)
                            VALUES
                            (@gradeId, @subjectId, @createdAt, @createdBy);
                            SELECT LAST_INSERT_ID();";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gs.GradeId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = gs.SubjectId },
                new MySqlParameter("@createdAt", MySqlDbType.DateTime) { Value = gs.CreatedAt },
                new MySqlParameter("@createdBy", MySqlDbType.VarChar) { Value = gs.CreatedBy }
            };

            return Convert.ToInt32(DbHelper.ExecuteScalar(query, parameters));
        }

        public bool UpdateGradeSubject(GradeSubject gs)
        {
            string query = @"UPDATE grade_subject SET
                                grade_id = @gradeId,
                                subject_id = @subjectId,
                                updated_at = @updatedAt,
                                updated_by = @updatedBy
                             WHERE id = @id";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", MySqlDbType.Int32) { Value = gs.Id },
                new MySqlParameter("@gradeId", MySqlDbType.Int32) { Value = gs.GradeId },
                new MySqlParameter("@subjectId", MySqlDbType.Int32) { Value = gs.SubjectId },
                new MySqlParameter("@updatedAt", MySqlDbType.DateTime) { Value = gs.UpdatedAt },
                new MySqlParameter("@updatedBy", MySqlDbType.VarChar) { Value = gs.UpdatedBy ?? "" }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteGradeSubject(int id)
        {
            string query = @"DELETE FROM grade_subject 
                             WHERE id = @id";

            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@id", MySqlDbType.Int32) { Value = id }
            };

            return DbHelper.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
