using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }             //if the name is Id the framework automatically sees this as primary key
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
