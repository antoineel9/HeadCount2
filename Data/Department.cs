using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeadCount.Data
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }

        public string Name { get; set; }
        public string DeptHead { get; set; }
        public string DeptLoc { get; set; }

        //foreign key connect Employees table

        public int EmpId { get; set; }

        [ForeignKey("EmpId")]
        public Employee Employees { get; set; }
    }
}