namespace BookDetailsApp.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string? Publisher { get; set; }
        public string? Title { get; set; }
        public string? AuthorLastName { get; set; }
        public string? AuthorFirstName { get; set; }
        public decimal Price { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Now;
        public string? MLACitation
        {
            get
            {
                return $"{AuthorLastName}, {AuthorFirstName}. \"{Title}.\" {Publisher}, {Price:C}.";
            }
        }
        public string? ChicagoCitation
        {
            get
            {
                return $"{AuthorLastName}, {AuthorFirstName}. <i>{Title}</i>. {Publisher}, {Price:C}.";
            }
        }
    }
}
