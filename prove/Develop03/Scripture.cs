using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) {
        //store the reference
        _reference = reference;

        //split text into words.
        foreach(string t in text.Split(" ")) {
            Word word = new Word(t);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide) {
        int number = 0;
        int completed = 0;
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words) {
            if (!word.IsHidden()) {
                visibleWords.Add(word);
            }
        }

        while (completed < numberToHide && visibleWords.Count > 0) {
            number = new Random().Next(0, visibleWords.Count);
            Word word = visibleWords[number];
            word.Hide();
            visibleWords.Remove(word);
            number = _words.IndexOf(word);
            _words[number].Hide();
            completed++;
        }
    }

    public string GetDisplayText() {

        StringBuilder sb = new StringBuilder();

        //Scripture reference
        sb.Append($"{_reference.GetDisplayText()} ");

        //Scripture text
        foreach (Word word in _words) {
            sb.Append($"{word.GetDisplayText()} ");
        }
        return sb.ToString();
    }

    public bool IsCompletelyHidden() {
        int count = 0;
        foreach (Word w in _words)
            if (w.IsHidden())
                count++;

        if (_words.Count == count)
            return true;
        return false;
    }
}