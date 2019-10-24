using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeadCount.Data
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmpId { get; set; }

        public int DeptId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Date { get; set; }
        public string Approved { get; set; }
        public int URId { get; set; }
        public bool? ApprPos { get; set; }
        public DateTime? ReleaseDate { get; set; }
        
    }
}