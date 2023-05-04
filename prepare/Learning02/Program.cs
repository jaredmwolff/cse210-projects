using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Deli Clerk";
        job1._company = "WinCo Foods";
        job1._startYear = 2021;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._jobTitle = "Missionary";
        job2._company = "Church of Jesus Christ of Latter-day Saints";
        job2._startYear = 2018;
        job2._endYear = 2020;

        Resume myResume = new Resume();
        myResume._name = "Jared Wolff";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}