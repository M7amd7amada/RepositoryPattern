namespace RepositoryPattern.Core.Models;

public class Author
{
    [Key]
    public int AuthorId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
}