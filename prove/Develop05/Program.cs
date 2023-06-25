using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


///////////////////////////////////////////////////////////////


public class Program
{
    private List<Activity> _activities = new List<Activity>();
    private int _score;

    //public Program()
    //{
    //    this.activities = new List<Activity>();
    //    this._score = 0;
    //}


///////////////////////////////////////////////////////////////


public static void Main()
{
    Program program = new Program();
    bool done = false;

    while (!done)
    {
        //Console.Clear();  --------->   does not work well with this code :c
        Console.WriteLine("_______________________");
        Console.WriteLine("");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. Record Event");
        Console.WriteLine("3. Display Progress");
        Console.WriteLine("4. Save to File");
        Console.WriteLine("5. Load from File");
        Console.WriteLine("6. Quit");
        Console.WriteLine("");

        
        int choice = int.Parse(Console.ReadLine());


        switch (choice)
        {
            case 1:
                program.CreateNewGoal();
                break;
            case 2:
                program.RecordEvent();
                break;
            case 3:
                program.DisplayProgress();
                break;
            case 4:
                program.SaveToFile();
                break;
            case 5:
                program.LoadFromFile();
                break;
            case 6:
                done = true;
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}


///////////////////////////////////////////////////////////////


    private void CreateNewGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("Choose the goal type:");
        Console.WriteLine("");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("");


        Activity newActivity = null;
        int choice = int.Parse(Console.ReadLine());



        Console.WriteLine("");
        Console.Write("Enter the goal's name: ");
        string name = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Enter the goal's description: ");
        string description = Console.ReadLine();

        Console.WriteLine("");
        Console.Write("Enter the point value: ");
        int pointValue = int.Parse(Console.ReadLine());


        switch (choice)
        {
            case 1:
                newActivity = new SimpleGoal{_name = name, _description = description, _pointValue = pointValue};
                break;

            case 2:
                newActivity = new EternalGoal{_name = name, _description = description, _pointValue = pointValue};
                break;

            case 3:
                Console.Write("Enter the number of times required for completion: ");
                int numTimesRequired = int.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                newActivity = new ChecklistGoal (numTimesRequired, bonusPoints) {_name = name, _description = description, _pointValue = pointValue};
                break;

            default:
                Console.WriteLine("Invalid choice. Please pick one of the available options.");
                break;

    }

    _activities.Add(newActivity);
}


///////////////////////////////////////////////////////////////


private void RecordEvent()
{
        Console.WriteLine("");
        DisplayProgress();
        Console.WriteLine("");
        Console.Write("Enter the number of the goal to record: ");

        int activityIndex = int.Parse(Console.ReadLine()) - 1;

        if (activityIndex >= 0 && activityIndex < new List<Activity>().Count)
        {
            Activity activity = new List<Activity>()[activityIndex];
            _score += activity.RecordEvent();
            Console.WriteLine("Your event has been recorded.");
        }

        else
        {
            Console.WriteLine("Invalid number. Please try again.");
        }
    }



//{
//    Console.WriteLine("Choose the activity: ");
//
//
//    for (int i = 0; i < activities.Count; i++)
//    {
//        Console.WriteLine($"{i + 1}. {activities[i].Name}");
//    }


//    int choice = int.Parse(Console.ReadLine()) - 1;
//    activities[choice].RecordEvent();
//    score += activities[choice].PointValue;
//}


///////////////////////////////////////////////////////////////


public void DisplayProgress()
{
    for (int i = 0; i < _activities.Count; i++)
        {
            Activity activity = _activities[i];

            string completionStatus = activity.IsComplete() ? "[X]" : "[ ]";
            string timesCompleted = activity is ChecklistGoal ? $" - Completed {((ChecklistGoal)activity)._numTimesCompleted}/{((ChecklistGoal)activity)._numTimesRequired} times" : "";

            Console.WriteLine($"{i + 1}. {completionStatus} {activity._name} - {activity._description}{timesCompleted}");
        }
}

//{
//    Console.WriteLine($"Current score: {_score}");
//    for (int i = 0; i < _activities.Count; i++)
//    {
//        Console.WriteLine(_activities[i].DisplayProgress());
//    }
//}


///////////////////////////////////////////////////////////////


public void SaveToFile()
{
    Console.WriteLine("");
    Console.Write("Enter the name of the file to save: ");
    string fileName = Console.ReadLine();

    using (StreamWriter writer = new StreamWriter(fileName))
    {
        writer.WriteLine(_score);
        writer.WriteLine(_activities.Count);


        foreach (Activity activity in _activities)
        {
            if (activity is SimpleGoal)
            {
                writer.WriteLine("Simple");
            }

            else if (activity is EternalGoal)
            {
                writer.WriteLine("Eternal");
            }

            else if (activity is ChecklistGoal)
            {
                writer.WriteLine("Checklist");
                writer.WriteLine(((ChecklistGoal)activity)._numTimesRequired);
                writer.WriteLine(((ChecklistGoal)activity)._bonusPoints);
            }

            writer.WriteLine(activity._name);
            writer.WriteLine(activity._description);
            writer.WriteLine(activity._pointValue);
        }
    }
}


///////////////////////////////////////////////////////////////


public void LoadFromFile()
{
    //string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "goals.txt");
    //using (FileStream fileStream = new FileStream(filePath, FileMode.Open))

    Console.WriteLine("");
    Console.Write("Enter the name of the file to load: ");
    string fileName = Console.ReadLine();

    using (StreamReader streamReader = new StreamReader(fileName))
    {
        //string totalScoreStr = streamReader.ReadLine();
        //int.TryParse(totalScoreStr, out _score);

        //string line;
        //while ((line = streamReader.ReadLine()) != null)

        _score = int.Parse(streamReader.ReadLine());
        int activityCount = int.Parse(streamReader.ReadLine());
        _activities.Clear();

        for (int i = 0; i < activityCount; i++)
        {
            string activityType = streamReader.ReadLine();
            Activity activity = null;

            //string[] parts = line.Split(',');
            //string name = parts[0];
            //int pointValue;
            //int.TryParse(parts[1], out pointValue);


            if (activityType == "Simple")
            {
                activity = new SimpleGoal();

                //SimpleGoal goal = new SimpleGoal();
                //_activities.Add(goal);
            }

            else if (activityType == "Eternal")
            {
                activity = new EternalGoal();

                //EternalGoal goal = new EternalGoal();
                //_activities.Add(goal);
            }

            else if (activityType == "Checklist")
            {
                int numTimesRequired = int.Parse(streamReader.ReadLine());
                int bonusPoints = int.Parse(streamReader.ReadLine());

                activity = new ChecklistGoal(numTimesRequired, bonusPoints);
                //int.TryParse(parts[3], out numTimesRequired);
                //ChecklistGoal goal = new ChecklistGoal(numTimesRequired, bonusPoints);
                
            }

            activity._name = streamReader.ReadLine();
            activity._description = streamReader.ReadLine();
            activity._pointValue = int.Parse(streamReader.ReadLine());

            _activities.Add(activity);
        }
    }

    Console.WriteLine("Goals and score loaded from file.");
}

}