using System.IO;
public class Journal
{
    List<Entry> _entries = new List<Entry>();

    public void DisplayAll() {
        foreach (Entry entry in _entries) {
            entry.Display();
            Console.WriteLine("\n\n");
        }
        Console.WriteLine("Press a key to continue");
        Console.ReadKey(true);
    }

    public void SaveToFile(string file) {
        string option = string.Empty;
        if (_entries.Count > 0) {
            if (File.Exists(file))
                Console.WriteLine("The file already exists. If you save the changes, all previous entries will be lost. Should I proceed? (y/n)");
                option = Console.ReadLine().ToLower();
                if (option != "y")
                    return;

            using (StreamWriter outputFile = new StreamWriter(file)) {
                //We write the header line
                outputFile.WriteLine("date|prompt|text");
                foreach (Entry entry in _entries) {
                    outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
                }
            }
            Console.WriteLine($"Saved {_entries.Count - 1} entries");
            Console.WriteLine("Press a key to return to the main menu");
            Console.ReadKey(true);
        }
        else {
            Console.WriteLine("No entries to save in your Journal");
        }
    }

    public void LoadFromFile(string file) {
        if (!File.Exists(file)) {
            Console.WriteLine("The file does not exist. Press a key to go to the main menu");
            Console.ReadKey(true);
            return;
        }
        bool headers = true;
        string[] lines = File.ReadAllLines(file);

        //remove entries, clear them
        _entries.Clear();

        foreach (string line in lines)
        {
            if (headers) {
                headers = false;
                continue;
            }
            string[] parts = line.Split("|");
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];

            AddEntry(entry);
        }
        Console.WriteLine($"Loaded {lines.Count() - 1} entries");
        Console.WriteLine("Press a key to return to the main menu");
        Console.ReadKey(true);
    }

    public void AddEntry (Entry newEntry) {
        _entries.Add(newEntry);
    }
}