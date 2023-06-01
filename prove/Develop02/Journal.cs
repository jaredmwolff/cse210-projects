using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public void AddEntry(Entry entry)
    {
        _entries.Add(new Entry());
         
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void Load(string filename)
    {
        
    }

}