using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public static class FileManager
    {
        public static void Save(Journal journal, string filename, char sep = '|')
        {
            using var writer = new StreamWriter(filename);
            foreach (var entry in journal.GetEntries())
            {
                writer.WriteLine(entry.ToLine(sep));
            }
        }

        public static Journal Load(string filename, char sep = '|')
        {
            var journal = new Journal();
            var lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var entry = Entry.FromLine(line, sep);
                journal.AddEntry(entry);
            }
            return journal;
        }
    }
}
