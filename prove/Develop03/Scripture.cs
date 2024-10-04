public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word)); 
        }
    }

    public void HideRandomWords(int numberToHide)
{
    Random random = new Random();
    List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

    if (visibleWords.Count == 0)
    {
        return;
    }

    int wordsToHide = Math.Min(numberToHide, visibleWords.Count);

    for (int i = 0; i < wordsToHide; i++)
    {
        int index = random.Next(visibleWords.Count);
        visibleWords[index].Hide();  
        visibleWords.RemoveAt(index);  
    }
}


    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();  
        foreach (var word in _words)
        {
            displayWords.Add(word.GetDisplayText());  
        }
        return $"{_reference.GetDisplayText()} - {string.Join(" ", displayWords)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());  
    }
}
