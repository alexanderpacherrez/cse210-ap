public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        Entry userEntry = new Entry();
        _entries.Add(userEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._promptText}");
            Console.WriteLine($"{entry._entryText}");
            Console.WriteLine();
        }
    }
    public void SavetoFile(string file)
    {
        if (file.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{response}");
                Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(file))
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }
    public void LoadFromFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file, true))
        {
            if (file.EndsWith(".csv"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
                }
            }
            else
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date:{entry._date},{entry._promptText},{entry._entryText}");
                    outputFile.WriteLine($"Prompt:{entry._promptText}");
                    outputFile.WriteLine($"{entry._entryText}");
                    outputFile.WriteLine();
                }
            }
        }
    }
}
