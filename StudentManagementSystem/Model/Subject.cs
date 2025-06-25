using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Model
{
    internal class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public string SubjectIndex { get; set; }
        public int SubjectOrder { get; set; }
        public string SubjectColor { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public string DeletedBy { get; set; }
    }
}
