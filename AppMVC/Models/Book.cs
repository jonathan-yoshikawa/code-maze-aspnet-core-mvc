using System;
using System.ComponentModel.DataAnnotations;

namespace AppMVC.Models
{
    public class Book
    {
        public int Id { get; set; }
        
        [Display(Name = "Título do Livro")]
        [Required]
        public string Title { get; set; }
        
        [Display(Name ="Gênero")]
        public string Genre { get; set; }
        
        [DataType(DataType.Currency)]
        [Range(1, 100)]
        [Display(Name = "Preço")]
        public decimal Price { get; set; }
        
        [Display(Name = "Data da Publicação")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }
    }
}
