namespace LiteraryRecommendation.Core.Entities
{
    public class UserGenrePreference
    {
        public int Id { get; set; }
        public int UserId { get; set; }   
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
