public class Video
{
    private string _title;
    private Author _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, Author author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }

    public int GetCommentsCount() {
        return _comments.Count;
    }

    public void AddComment(Author author, string text) {

    }

}