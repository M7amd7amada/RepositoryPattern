
namespace RepositoryPattern.Core.Models;

public class Book
{
    [Key]
    public int BookId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = string.Empty;


    [ForeignKey(nameof(AuthorId))]
    public int AuthorId { get; set; }
    public Author? Author { get; set; }
}