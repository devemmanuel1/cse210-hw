public class Word 
{
    private string _text;
    private bool _isHidden;
    private bool _isPartialHidden;

    public Word(string text) 
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void PartialHide()
    {
        _isPartialHidden = true;
    }

    public string GetDisplayText()
    {
        string displayText = _text;

        // If hidden, display underscores instead of the word
        if (_isHidden)
        {
            for (int i = 0; i < displayText.Length; i++)
            {
                displayText = displayText.Replace(displayText[i], '_');
            }
        }
        else if (_isPartialHidden) // Display first letter of the word, using underscores for the rest
        {
            for (int i = 1; i < displayText.Length; i++)
            {
                displayText = displayText.Replace(displayText[i], '_');
            }
        }

        return displayText;
    }
}