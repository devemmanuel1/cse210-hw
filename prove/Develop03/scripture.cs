public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _numTotalWordsHidden;
    private bool _isHidden;

    public Scripture(Reference reference, string fullText)
    {
        _reference = reference;

        // Split fullText into an array of strings and store in Word objects
        string[] arrayText = fullText.Split(" ");
        foreach (string text in arrayText)
        {
            Word word = new Word(text);
            _words.Add(word);
        }

        _numTotalWordsHidden = 0;
    }

    public void HideRandomWords(int numberToHide)
    {
        // Loop to hide words
        int numHidden = 0;
        while (numHidden < numberToHide) {

            // Get index for random word
            Random randomGenerator = new Random();
            int wordIndex = randomGenerator.Next(_words.Count);

            // Hide word at index only if not already hidden, increment _numWordsHidden by 1
            if (!_words[wordIndex].IsHidden())
            {
                _words[wordIndex].Hide();
                numHidden++;
                _numTotalWordsHidden++;
            }

            // Check total of words hidden vs length of text
            if (_numTotalWordsHidden == _words.Count) {
                _isHidden = true;
            }
        }
    }

    public void HidePartial()
    {
        // Loop to partially hide words
        foreach (Word word in _words) {
            word.PartialHide();
        }
    }

    public string GetDisplayText()
    {
        // Display reference info
        string text = _reference.GetDisplayText();
        
        // Iterate list of words and display each word
        foreach (Word word in _words)
        {
            text += $" {word.GetDisplayText()}";
        }

        return text;
    }

    public bool IsCompletelyHidden()
    {
        return _isHidden;
    }
}