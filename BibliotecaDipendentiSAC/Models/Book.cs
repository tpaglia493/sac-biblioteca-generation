using System.ComponentModel.DataAnnotations;

namespace BibliotecaDipendentiSAC.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo  titolo è obbligatorio")]
        [StringLength(100, ErrorMessage = "Il nome non può essere più lungo di 100 caratteri!")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Il descrizione è obbligatorio")]
        [StringLength(800, ErrorMessage = "La descrizione non può essere più lunga di 800 caratteri!")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il numero di pagine è obbligatorio")]
        [Range(5, 10000)]
        public int NumberOfPages { get; set; }


        [Range(0, 250)]
        public int AvailableCopies { get; set; }



        public int Edition { get; set; }

        [Required(ErrorMessage = "Il campo publisher è obbligatorio")]
        [StringLength(40, ErrorMessage = "Il nome della casa editrice non può essere più lungo di 40 caratteri!")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Il bookable è obbligatorio")]
        public bool Bookable { get; set; }

        public bool eBook { get; set; }
        [StringLength(40, ErrorMessage = "Il nome della casa editrice non può essere più lungo di 40 caratteri!")]

        public string? Autore { get; set; }

        public Book() { }

        public Book(string title, string descritpion, int numberOfPages, int availableCopies, int edition, string publisher, bool bookable, bool ebook, string autore)
        {
            Title = title;
            Description = descritpion;
            NumberOfPages = numberOfPages;
            AvailableCopies = availableCopies;
            Edition = edition;
            Publisher = publisher;
            Bookable = bookable;
            this.eBook = ebook;
            Autore = autore;


        }

    }
}
