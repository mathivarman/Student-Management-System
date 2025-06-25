using System;

namespace StudentManagementSystem.Model
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Telephone { get; set; } 
        public string Nic { get; set; }
        public string Email{ get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfAppoint { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public string DeletedBy { get; set; }
    }
}
