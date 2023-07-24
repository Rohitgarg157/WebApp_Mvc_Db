using System.ComponentModel.DataAnnotations;

namespace WebApp_Mvc_Db.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [MinLength(3,ErrorMessage ="Min 3 character required")]
        [MaxLength(15,ErrorMessage ="Max 15 character allowed")]
        public string? Name { get; set; }
            public string? Email { get; set; }
        public string? Department { get; set; }

    }
}
