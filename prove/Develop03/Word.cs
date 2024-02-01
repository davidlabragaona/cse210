using System.Text;

public class Word
{
    private string _text;
    private bool _isHidden;

    //constructor
    public Word(string text) {
        _text = text;
        _isHidden = false;
    }

    public void Hide(){
        _isHidden = true;
    }

    public void Show() {
        _isHidden = false;
    }

    public bool IsHidden() {
        return _isHidden;
    }

    public string GetDisplayText() {
        StringBuilder sb = new StringBuilder();
        if (IsHidden())
            foreach(char c in _text)
                sb.Append("_");
        else
            sb.Append(_text);
        return sb.ToString();
    }


}