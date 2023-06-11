 namespace MindfulnessApp
 {
    class ReflectionActivity : Activity
        {
            public ReflectionActivity(): base("Reflection Activity", "For this activity, think in your head what you did/thought in recent time based on the prompts and questions provided."){}
            private List<string> _prompts = new List<string>{ "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
            private List<string> _questions = new List<string>{"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};


            public override void RunActivity()
            {
                Console.WriteLine();                
                Console.WriteLine("Get Ready...");
                ShowSpinner();
                Console.WriteLine();
                int _randomNumber = _rand.Next(0, _prompts.Count - 1);


                Console.WriteLine($"{_prompts[_randomNumber]}");
                Console.WriteLine();
                Console.WriteLine("Once you are ready, press enter to continue...");
                Console.ReadLine();

                Console.WriteLine($"Based on the prompt, consider the following questions...");
                Console.WriteLine();
                Console.Write("You may begin in: ");
                for(int i = 5; i >= 1; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                Console.Clear();

                DateTime startTime = DateTime.Now;
                while((DateTime.Now - startTime).TotalSeconds < GetTime())
                {
                    _randomNumber = _rand.Next(0, _questions.Count - 1);
                    Console.Write($"{_questions[_randomNumber]} ");
                    ShowSpinner(15);
                    _questions.RemoveAt(_randomNumber);
                    Console.WriteLine();
                }

                Console.WriteLine();

            }
        }
}



// Had lots of issues in the latter part of this class, so I needed to change a lot of it as a result... Sadly erased my attempts on this class out of frustration.//

// One example I did save... //


            //public ReflectionActivity()
            //{
                
                //this.prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
                //this.questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
            //}