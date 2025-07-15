namespace WordCounterMain;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Paste your text here to be counted(type f to finish pasting the text): ");

        string? line;
        var lines = new List<string>();

        while((line = Console.ReadLine()) != null)
        {
            if (line.Trim() == "f")
            {
                break;
            }

            lines.Add(line);
        }

        var input = string.Join(Environment.NewLine, lines);

        var wordCounter = new WordCounter();

        var result = wordCounter.CountWords(input);

        Console.WriteLine(result);
    }
}

public class WordCounter
{
    public int CountWords(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return 0;
        }

        var splittedText = text.Split(new[] {' ', '\r', '\n', '\t'}, StringSplitOptions.RemoveEmptyEntries);

        return splittedText.Length;
    }
}