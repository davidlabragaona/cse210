public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse) :
    this(book, chapter, verse, 0) {}

    public Reference(string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText() {
        string t = $"{_book} {_chapter}:{_verse}";
        if (_endVerse != 0)
            t += $"-{_endVerse}";
        return t;
    }
}