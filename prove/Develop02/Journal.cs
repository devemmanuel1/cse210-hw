public class Journal 
{
    public List<Entry> _entries = [];

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll() 
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._dayOfWeek}|{entry._promptText}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        // Replace any entries currently stored in the journal
        _entries = [];

        // Read from file
        string[] lines = System.IO.File.ReadAllLines(file);

        // Iterate through file lines
        foreach (string line in lines) 
        {
            // Split line into parts
            string[] parts = line.Split("|");

            // Create new entry to store the parts
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._dayOfWeek = parts[1];
            entry._promptText = parts[2];
            entry._entryText = parts[3];

            // Add entry to journal
            _entries.Add(entry);
        }
    }
}