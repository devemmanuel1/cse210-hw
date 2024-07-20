using System;

class Program
{
    static void Main(string[] args)
    {
        Address lectureAddress = new Address("84 Refiners estate", "Emene", "Enugu", "Nigeria");
        Lecture lecture = new Lecture("The Future of Artificial Intelligence", "Lecture on the future of AI from the perspective of a farmer", "June 23th, 2024", "11:00 AM", lectureAddress, "John Snow", 980);
        Console.Clear();
        Console.WriteLine("Lecture Standard Details");
        Console.WriteLine(lecture.DisplayStandardDetails());
        Console.WriteLine("Lecture Full Details");
        Console.WriteLine(lecture.DisplayFullDetails());
        Console.WriteLine("Lecture Short Description");
        Console.WriteLine(lecture.DisplayShortDescription());

        Address receptionAddress = new Address("84 Refiners estate", "Emene", "Enugu", "Nigeria");
        Reception reception = new Reception("Networking Reception: Celebrating Innovations in Technology", "Join us for a reception on celebrating the latest innovations in technology", "June 25th, 2024", "9:30 AM", receptionAddress, "networkRSVP@gmail.com");
        Console.WriteLine("Reception Standard Details");
        Console.WriteLine(reception.DisplayStandardDetails());
        Console.WriteLine("Reception Full Details");
        Console.WriteLine(reception.DisplayFullDetails());
        Console.WriteLine("Reception Short Description");
        Console.WriteLine(reception.DisplayShortDescription());

        Address outdoorGatheringAddress = new Address("84 Refiners estate", "Emene", "Enugu", "Nigeria");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Healthcare Professionals Outdoor Social", "A unique opportunity for medical and healthcare professionals to connect in a relaxed, outdoor setting", "July 8th, 2024", "11:30 AM", outdoorGatheringAddress, "Partly Cloudy");
        Console.WriteLine("Outdoor Gathering Standard Details");
        Console.WriteLine(outdoorGathering.DisplayStandardDetails());
        Console.WriteLine("Outdoor Gathering Full Details");
        Console.WriteLine(outdoorGathering.DisplayFullDetails());
        Console.WriteLine("Outdoor Gathering Short Description");
        Console.WriteLine(outdoorGathering.DisplayShortDescription());
    }
}