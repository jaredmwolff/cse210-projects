using System;

public class PromptGenerator
{
    List<string> prompts = new List<string>()
    {
        "What do I feel like I could have done better today?",
        "Was there anything that I did today that I regret doing?",
        "Did I set a good example to those around me?",
        "What made me happy today?" 
    };

    public Random random = new Random();
    
    public string _randomPrompt;

    public string Display()
    {
        _randomPrompt = prompts[random.Next(0, prompts.Count)];
        Console.WriteLine($"{_randomPrompt}");
        return _randomPrompt;
    }
       

    //int index = random.Next(prompts.Count);
    //Console.WriteLine(prompts[index]);
     
}