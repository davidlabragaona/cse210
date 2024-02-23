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

    public void ShowVideoData() {
        Console.WriteLine($"{_title} ({GetDuration()})");
        Console.WriteLine($"{_author.GetAuthorString()} - {GetCommentsCount()} comments:\n");
        foreach (Comment comment in _comments) {
            Console.WriteLine($"{comment.GetCommentString()}");
        }
    }

    public string GetDuration() {
        int hours = _length / 3600;
        int remainder = _length % 3600;
        int minutes = remainder / 60;
        int seconds = remainder % 60;

        return $"{hours:00}:{minutes:00}:{seconds:00}";

    }

    public void AddComment(Author author, string text) {
        Comment comment = new Comment(author, text);
        _comments.Add(comment);
    }

}