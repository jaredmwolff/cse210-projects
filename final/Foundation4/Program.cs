using System;
using System.Collections.Generic;

namespace ExerciseFoundation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("");
            List<Activity> activities = new List<Activity>();

            RunningActivity runningActivity = new RunningActivity(new DateTime(2023, 7, 12), 30, 4);
            CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2023, 7, 12), 30, 22);
            SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2023, 7, 12), 30, 15);

            activities.Add(runningActivity);
            activities.Add(cyclingActivity);
            activities.Add(swimmingActivity);


            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
            
        }
    }
}