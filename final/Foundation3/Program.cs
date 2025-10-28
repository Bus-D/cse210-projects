using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("120 Science Hall, Room 402", "Boston", "MA", "USA");
        Lecture event1 = new Lecture("The Physics of Black Holes", "Lecture", "A detailed presentation on recent discoveries regarding black hole formation and observation.", "2026-02-10", "07:00 PM - 08:30 PM", address1, "Professor Anna Lopez, PhD", 150);
        Console.WriteLine(event1.GetShortDescription());
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine(event1.GetShortDescription());

        Console.WriteLine();
        Address address2 = new Address("The Grand Ballroom, 800 Harbour St", "Vancouver", "BC", "Canada");
        Reception event2 = new Reception("Annual Alumni & Donor Mixer", "Reception", "A semi-formal evening reception with cocktails and appetizers for networking and celebrating institutional achievements.", "2025-12-08", "06:00 PM - 09:00 PM", address2, "alumni.events@foundation.org");
        Console.WriteLine(event2.GetStandardDetails());
        Console.WriteLine(event2.GetFullDetails());
        Console.WriteLine(event2.GetShortDescription());

        Console.WriteLine();
        Address address3 = new Address("Trailhead Parking Lot, Aspen Gate", "Estes Park", "CO", "USA");
        string temp = "Mild and partly cloudy, " + "68" + "\u2070" + "F";
        Outdoor event3 = new Outdoor("Guided Forest Ecology Hike", "Outdoor", "A moderate 3-hour guided hike focusing on local flora and fauna. Please dress appropriately.", "2026-05-18", "09:00 AM - 12:00 PM", address3, temp);
        Console.WriteLine(event3.GetStandardDetails());
        Console.WriteLine(event3.GetFullDetails());
        Console.WriteLine(event3.GetShortDescription());
    }
}