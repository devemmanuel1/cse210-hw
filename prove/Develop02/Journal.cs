public class Journal 
{
    public List<Entry>  _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry promp in _entries) 
        {
            promp.Display();
        }
    }

    public void SaveToFile(List<Entry> _entries) 
    
    {
        Console.WriteLine("What is the filename? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename)) 
        {
           foreach (Entry p in _entries) 
           {

                outputFile.WriteLine($"{p._date},{p._promptText},{p._entryText}");
           }
           
          
        }
    }

    public List<Entry> LoadFromFile(string file)
    {
       string[] lines = System.IO.File.ReadAllLines(file);
       List<Entry> newData = new List<Entry>();

       foreach (string line in lines)
       {
            string[] parts = line.Split(",");

            Entry data = new Entry();
            data._date = parts[0];
            data._promptText = parts[1];
            data._entryText = parts[2];

           
            newData.Add(data); 
       }

       return newData;
    }
}