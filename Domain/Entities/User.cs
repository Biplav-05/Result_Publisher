using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public Guid user_Id { get; set; }
        public string ? userName { get; set; } 
        public string ? firstName { get; set; }
        public string ? lastName { get; set;}
        public string ? email { get; set; }
        public string ? password { get; set; }

    }
}
