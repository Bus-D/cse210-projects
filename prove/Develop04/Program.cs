using System;

class Program
{
    static void Main(string[] args)
    {
        //www.plantuml.com/plantuml/png/VL1RJiCm4FptAVnP5EK2LOLQIeKG3rNa09L9bdQbP6rvrwqguEx4v94qHNnwPZoFNR8OBw4gLLuQPhtA1Oyevq-Lwfrf7ndabWgU8qc4dGaC7QORy1bP5ZldRUM4R-UQnIFjUmB91Hd3hVGrLE_WEvD6DiPKeZEGB7Py0MQpXraDwr_TJM-NQ0RPKD591gQcjh7jYh0oWfOYTxHOg6_LBhxpOEHGY_lfJMY3G_yXQPN_USMn4wUr3II5FT78w0d0RUF-A9wDTzmZkzASDrG3m0CrHBp1HmbvZB_eUx2dnd4Kym3o60zraR2kHSOFi-9dX_Jdg2v1BxxIzFfG4tuoVi9UzrPBe29KvGy0

        bool running = true;
        Activity baseActivity = new Activity();

        while (running)
        {
            int choice = baseActivity.DisplayStart();

            switch (choice)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity("", "", 0);
                    breathing.RunBreathing();
                    break;

                case 2:
                    ReflectionActivity reflection = new ReflectionActivity("", "", 0);
                    reflection.RunReflection();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity("", "", 0);
                    listing.RunListing();
                    break;

                case 4:
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid Choice. Please try again.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}