using System;

//www.plantuml.com/plantuml/png/LO_F2i8m3CRlUOeSDuO-m10Pw75UlPQoXQtOTh9ae8ZlRcZBm6E__hu_wLZiAblmC7ZBZ7Stqe8VQB1tB2UMrSNfZ6POGg0e30SquiHJY_bFIMCtcPTrLnJn52UPMtHHG8cRVL1AhbJ0adNi4rHdgi6huwUtxypLBS0NogXBDgHP9jhmLoxqalrTkegXgZMZepZgVJy0
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("TechSimplify", "Understanding APIs in 10 Minutes", "10:05");
        video1._comments.Add(new Comment("Ava M.", "This was super clear! Thanks for explaining what an API actually does."));
        video1._comments.Add(new Comment("JakeTech", "Loved the visuals, they really helped."));
        video1._comments.Add(new Comment("Dev_Dan", "Wish I saw this before my last project. Great job!"));
        videos.Add(video1);

        Video video2 = new Video("HealthyLivingNow", "5-Minute Morning Stretch Routine", "5:12");
        video2._comments.Add(new Comment("Maria Lopez", "Perfect for starting the day! My back already feels better."));
        video2._comments.Add(new Comment("Chris R.", "Short and effective. Subscribed!"));
        video2._comments.Add(new Comment("FitnessFan22", "Would love to see a version for office workers."));
        videos.Add(video2);

        Video video3 = new Video("ChefAntonio", "How to Make Authentic Italian Pasta", "14:10");
        video3._comments.Add(new Comment("Tina C.", "I tried this last night and my family loved it!"));
        video3._comments.Add(new Comment("GordonWannabe", "The tip about the pasta water was gold."));
        video3._comments.Add(new Comment("Foodie101", "Finally a recipe that tastes like what I had in Rome!"));
        videos.Add(video2);

        foreach (Video video in videos)
        {
            video.DisplayVideo();
        }
    }
}