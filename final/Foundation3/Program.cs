using System;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("");
        Address address1 = new Address("13457 Royal Ct", "Bakersfield", "CA", "93415");
        Address address2 = new Address("1600 Pennsylvania Ave", "Pittsburgh", "PA", "69780");
        Address address3 = new Address("7189 Elm Blvd", "Houston", "TX", "31779");

        Lecture lecture = new Lecture("TED Talk: Can Advanced AI End Humanity?", "Discover the intricate possibilites of AI learning and why that could be a bad thing.", new DateTime(2023, 5, 13, 10, 0, 0), address1, "William Jefferson", 1220);

        Reception reception = new Reception("Wedding Reception", "Celebrate alongside Derik and Marissa on the happiest day of their life.", new DateTime(2023, 2, 21, 18, 0, 0), address2, "wedding_rsvp@gmail.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Church BBQ (Stockdale Ward)", "Enjoy hotdogs and hamburgers with the members of your ward.", new DateTime(2023, 7, 14, 12, 0, 0), address3, "Sunny");
        

        ///////////////////////


        Console.WriteLine("Standard Details for Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Full Details for Lecture:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Short Description for Lecture:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine("");

        Console.WriteLine("");
        Console.WriteLine("_______________________________");
        Console.WriteLine("");
        Console.WriteLine("");

        //////////////////////

        Console.WriteLine("Standard Details for Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Full Details for Reception:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Short Description for Reception:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("");
        Console.WriteLine("_______________________________");
        Console.WriteLine("");
        Console.WriteLine("");

        //////////////////////

        Console.WriteLine("Standard Details for Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Full Details for Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Short Description for Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("");
        Console.WriteLine("_______________________________");
        Console.WriteLine("");
    }

}