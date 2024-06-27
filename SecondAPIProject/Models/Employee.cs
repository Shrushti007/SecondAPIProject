using System.ComponentModel.DataAnnotations;

namespace SecondAPIProject.Models
{
    public class Employee
    {
        public int Empid { get; set; }
        [Required(ErrorMessage ="Name is compulsory",AllowEmptyStrings =false)]
        public string Name { get; set; }


    }
}
