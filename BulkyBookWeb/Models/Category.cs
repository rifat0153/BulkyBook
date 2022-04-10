using System.ComponentModel.DataAnnotations;

//"DefaultConnection": "server=(localdb)\\MSSQLLocalDB;Database=bulky;Trusted_Connection=True;"


namespace BulkyBookWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
