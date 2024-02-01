using System;
using System.Reflection.Metadata;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{

    /*
    Exceeding requirements:
    1. Does not hide already hidden words
    2. Loads a random scripture from a json file
    3. Program notifies if the scripture file does not exist and exits the program
    */
    static void Main(string[] args)
    {
        string response = string.Empty;
        const string filename = "scriptures.json";
        List<Scripture> scriptures;
        int index = 0;

        Console.WriteLine("Loading scriptures");
        scriptures = LoadFile(filename);
        if (scriptures.Count == 0) {
            Console.WriteLine($"The file [{filename}] does not exist. Please verify the file name and try again.");
            return;
        }

        index = new Random().Next(0, scriptures.Count);
        Scripture scripture = scriptures[index];

        Console.ForegroundColor = ConsoleColor.Yellow;

        while (response != "quit"){
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            if (scripture.IsCompletelyHidden())
                response = "quit";
            scripture.HideRandomWords(1);
        }
    }

    static List<Scripture> LoadFile(string filename) {
        List<Scripture> scriptures = new List<Scripture>();
        string content;

        if (File.Exists(filename)) {
            content = File.ReadAllText(filename);
            JsonNode scriptureNode = JsonNode.Parse(content);
            JsonNode root = scriptureNode.Root;
            JsonArray scripturesArray = root.AsArray();

            foreach (JsonNode element in scripturesArray) {
                string book, text;
                int chapter, verse, endVerse;

                JsonNode referenceNode = element["reference"];
                book = referenceNode["book"].ToString();
                chapter = int.Parse(referenceNode["chapter"].ToString());
                verse = int.Parse(referenceNode["verse"].ToString());
                if (referenceNode?["endVerse"] is JsonNode endVerseNode)
                    endVerse = int.Parse(endVerseNode.ToString());
                else
                    endVerse = 0;
                Reference reference = new Reference(book, chapter, verse, endVerse);
                text = element["text"].ToString();
                scriptures.Add(new Scripture(reference, text));
            }
        }

        /*foreach (Scripture scr in scriptures) {
            Console.WriteLine(scr.GetDisplayText() + "\n");
        }*/

        return scriptures;
    }
}