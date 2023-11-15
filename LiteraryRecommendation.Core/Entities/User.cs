namespace LiteraryRecommendation.Core.Entities
{
public class User
{
    public int Id { get; set; }
    public string FirtName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public List<UserGenrePreference> GenrePreferences { get; set; }
    public List<UserAuthorPreference> AuthorPreferences { get; set; }

}
}
