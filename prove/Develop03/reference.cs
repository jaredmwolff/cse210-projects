using System;
using System.Collections.Generic;

public class Reference
{
    private string verse;
    private string text;

    public Reference (string verse, string text)
    {
        this.verse = verse;
        this.text = text;
    }

    public static int Count { get; internal set; }

    public string Verse
    {
        get { return verse; }
    }

    public string Text
    {
        get { return text; }
    }
}