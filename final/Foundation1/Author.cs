public class Author
{
    private string _username;
    private string _email;

    public Author(string username, string email) {
        _username = username;
        _email = email;
    }

    public string GetAuthorString() {
        return $"@{_username}";
    }
}