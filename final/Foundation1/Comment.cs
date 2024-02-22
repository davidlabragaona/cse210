public class Comment
{
    private Author _author;
    private string _text;
    private int _likes;
    private DateTime _creationDate;

    public Comment(Author author, string text) {
        _author = author;
        _text = text;
        _likes = 0;
        _creationDate = DateTime.Now;
    }

    public void Like() {
        _likes++;
    }

    public int GetLikesCount() {
        return _likes;
    }

    public string GetCommentString() {
        return $"{_creationDate} - {_author.GetAuthorString()}: {_text}";
    }

}