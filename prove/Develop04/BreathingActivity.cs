namespace MindfulnessApp
{
    public class BreathingActivity : Activity   
    {
        public BreathingActivity(): base("Breathing Activity", "For this activity, simply relax and follow the prompt..."){}

    
        public override void RunActivity()
        {
            Console.WriteLine();                
            Console.WriteLine("Get Ready...");
            ShowSpinner();
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            while((DateTime.Now - startTime).TotalSeconds < GetTime())
            {

                Console.Write("Breathe in...");
                for(int i = 5; i >= 1; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                Console.WriteLine();

                Console.Write("Breathe out...");
                for(int i = 5; i >= 1; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}