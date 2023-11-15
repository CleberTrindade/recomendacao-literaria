namespace LiteraryRecommendation.Core.Entities
{
    public class UserAuthorPreference
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
