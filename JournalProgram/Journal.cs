using System.Collections.Generic;

namespace JournalApp
{
    public class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry entry) => _entries.Add(entry);

        public IEnumerable<Entry> GetEntries() => _entries;

        public void ReplaceAll(List<Entry> newEntries)
        {
            _entries = newEntries ?? new List<Entry>();
        }
    }
}
