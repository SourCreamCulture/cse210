using System;

namespace JournalApp
{
    public class Entry
    {
        public string Prompt { get; }
        public string Response { get; }
        public string Date { get; }

        public Entry(string prompt, string response, string date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }

        public override string ToString()
        {
            return $"{Date} - {Prompt}\n{Response}\n";
        }

        public string ToLine(char sep = '|')
        {
            return string.Join(sep, new string[] { Date, Prompt.Replace(sep.ToString(), string.Empty), Response.Replace(sep.ToString(), string.Empty) });
        }

        public static Entry FromLine(string line, char sep = '|')
        {
            var parts = line.Split(sep);
            if (parts.Length < 3)
                throw new FormatException("Invalid entry line");

            return new Entry(parts[1], parts[2], parts[0]);
        }
    }
}
