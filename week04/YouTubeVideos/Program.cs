using System;

class Program
{
    static void Main(string[] args)
    {
        {
        // Create 3-4 videos
        var video1 = new Video("How to Learn C#", "Emily Smith", 200); // 4.5 minutes
        var video2 = new Video("How To write classes", "Joo Chi", 359); // 4.5 minutes
        var video3 = new Video("Mastering C#", "The Matser", 100); // 3minutes

        // Add comments to the first video
        video1.AddComment(new Comment("Alice", "Great video! Learned a lot."));
        video1.AddComment(new Comment("chic", "Thanks for the clear explanation!"));
        video1.AddComment(new Comment("Bobo", "Very helpful, wow."));

        // Add comments to the second video
        video2.AddComment(new Comment("June", "OOPS not working for me."));
        video2.AddComment(new Comment("Ever", "Thanks."));
        video2.AddComment(new Comment("Frankie", "Thanks, this has made it easier for me."));

        // Add comments to the third video
        video3.AddComment(new Comment("June", "This helped me understand, tumbs up!"));
        video3.AddComment(new Comment("Jumpi", "Can I innbox you please"));
        video3.AddComment(new Comment("Levi", "I need a one on one session, are you available?."));

        // Store the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through each video and display details
        foreach (var video in videos)
        {

            video.DisplayVideoDetails();
            
        }
    
}
    }
}