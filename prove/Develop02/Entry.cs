using System;

public class Entry
{
    public string _prompt;

    public string _response;

    public string _date = DateTime.Now.ToString("mm/d/yyyy");

    public PromptGenerator _randomPrompt = new PromptGenerator(); 

    //public string _keptEntry;

    public override string ToString()
    {
        return ($"Date: {_date} \nPrompt: {_prompt} \nResponse: {_response}");
    }
}