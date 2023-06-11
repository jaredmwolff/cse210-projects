namespace MindfulnessApp
{
    public abstract class Activity
        {
            private string _description;
            private int _time;
            private string [] _animation = {"|","/","-","\\","|","/","-","\\"};
            private string _name;
            private DateTime _startTime;
            private DateTime _endTime;
            protected Random _rand = new Random();


            ////////////////////////////////


            public Activity(string name, string description)
            {
                _name = name;
                _description = description;
            }


            ////////////////////////////////


            public int GetTime()
            {
                return _time;
            }


            ////////////////////////////////


            public void StartActivity()
            {
                Console.WriteLine("");
                Console.WriteLine($"Welcome to the {_name}");
                Console.WriteLine($"{_description}");
                Console.WriteLine("");
                Console.WriteLine("How many seconds would you like for the session to last? ");
                _time = int.Parse(Console.ReadLine());
                Console.Clear();
            }


            ////////////////////////////////


            public abstract void RunActivity();


            ////////////////////////////////


            protected void ShowSpinner(int time = 5)
            {
                _startTime = DateTime.Now;
                _endTime = _startTime.AddSeconds(time);
                int _counter = 0;
                while(DateTime.Now < _endTime)
                {
                    Console.Write(_animation[_counter]);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");

                    _counter++;

                    if(_counter >= _animation.Count())
                    {
                        _counter = 0;
                    }

                }
            }


            ////////////////////////////////


            public void EndActivity()
            {
                Console.WriteLine("Excellent work for completing the activity!");
                ShowSpinner();
                Console.WriteLine();
                Console.WriteLine($"You have completed a total of {_time} seconds of the {_name}");
                ShowSpinner();
                Console.Clear();
            }
        }
}

