using System.ComponentModel.DataAnnotations;

namespace PustokTemplate.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(25)]
        [Required]
        public string Name { get; set; }
        [MaxLength(500)]
        [Required]
        public string Description { get; set; }
        [Required]
        public double InitialPrice { get; set; }
        public double DiscountPercent { get; set; }
        [Required]
        public bool IsAviable { get; set; }
        [Required]
        public int ImageId { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set;}
        public Genre Genre { get; set;}
    }
}
