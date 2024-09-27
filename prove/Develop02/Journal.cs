public class Journal
{ 
public List<Entry> _entries;

public Journal()
{
    _entries = new List<Entry>();
}

public void AddEntry(Entry newEntry)
{
  _entries.Add(newEntry);
}
public void DisplayAll()
{
  foreach(Entry entry in _entries){
    entry.Display();
  }
}
public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} - Prompt: {entry._promptText} {entry._entryText}");
            }
        }
        Console.WriteLine($"Journal saved in:  {file}");
    }
public void LoadFromFile(string filename)
{
    
    if (!System.IO.File.Exists(filename))
    {
        Console.WriteLine($"Error: The file '{filename}' does not exist.");
        return;
    }

    
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
        
        string[] parts = line.Split(new string[] { " - Prompt: " }, StringSplitOptions.None);

        if (parts.Length == 2)
        {
            string date = parts[0]; 
            string entryText = parts[1]; 

          
            string[] entryParts = entryText.Split(new char[] { ' ' }, 2);

            if (entryParts.Length == 2)
            {
                Entry entry = new Entry();
                entry._date = date;                     
                entry._promptText = entryParts[0];     
                entry._entryText = entryParts[1];      

                _entries.Add(entry); 
            }
        }
    }

    Console.WriteLine($"Journal loaded from: {filename}");
}

}