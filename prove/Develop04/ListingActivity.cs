namespace MindfulnessApp
{
    class ListingActivity : Activity
    {
        public ListingActivity(): base("Listing Activity", ""){}
        private List<string> _prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};


        public override void RunActivity()
        {
            Console.WriteLine();                
            Console.WriteLine("Get Ready...");
            ShowSpinner();
            Console.WriteLine();


            Console.WriteLine("List as many responses as you can based on the following prompt: ");
            int _randomNumber = _rand.Next(0, _prompts.Count - 1);
            Console.WriteLine($"{_prompts[_randomNumber]}");
            Console.WriteLine();


            Console.WriteLine($"You may begin in: ");
                for(int i = 5; i >= 1; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write($"\b \b");
                }
        
            DateTime _startTime = DateTime.Now;
                while((DateTime.Now - _startTime).TotalSeconds < GetTime())
                {
                    Console.Write("> ");
                    Console.ReadLine();
                }

            Console.WriteLine();
        }
    }
}










            //   Before you ask, yes, I needed a ton of help from my classmates on this :c   //



            ////////////////////////
            // Code that just didn't work prior to tons of change //
            ////////////////////////



            //public ListingActivity()
            //{
            //    this.duration = duration;
            //    this.description = "Listing Activity";
            //    this.prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
            //}





            // ..... //





            //Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

            //Random rand = new Random();
            //string prompt = prompts[rand.Next(prompts.Count)];
            //Console.WriteLine(prompt);

            //int count = duration / 5;
            //for (int i = 0; i < count; i++)
            //{
            //    System.Threading.Thread.Sleep(5000); 
            //    Console.WriteLine("Go!");
            //    int itemcount = 0;
            //    DateTime start = DateTime.Now;
            //    while ((DateTime.Now - start).TotalSeconds < 5) 
            //    {
            //        string item = Console.ReadLine();
            //        if (item == "")
            //            break;
            //        itemcount++;
            //    }
            //    Console.WriteLine("You listed {0} items.", itemcount);
            //}
            //EndActivity();
        //}
    //}
//}