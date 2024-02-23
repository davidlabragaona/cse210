class Program
{
    static List<Video> videos = new List<Video>();
    static void Main(string[] args)
    {

        Console.Clear();
        InitializeVideos();

        foreach(Video v in videos) {
            v.ShowVideoData();
            Console.WriteLine();
            Thread.Sleep(3000);
        }   
    }

    static void InitializeVideos() {
        Video video1 = new Video("Saturday Morning Session | October 2023 General Conference",
            new Author("churchofjesuschristgeneralconf", ""), 7080);
        video1.AddComment(new Author("lindalovett", ""), "The uplifting messages are very much appreciated.");
        video1.AddComment(new Author("robertvizcarra", ""), "I felt the spirit. Keep serving in the capacity you are call.");
        video1.AddComment(new Author("josephmarra", ""), "I loved Elder Bednars talk! Just what i needed to hear.");
        video1.AddComment(new Author("monicastevenson", ""), "The opening from the tabernacle Choir is so beautiful. It brings me so much peace.");

        Video video2 = new Video("Learn Database Normalization - 1NF, 2NF, 3NF, 4NF, 5NF",
            new Author("decomplexify", ""), 1714);
        video2.AddComment(new Author("adamknight", ""), "I’ve been building databases for over 20 years and this is one of the simplest and clearest explanations I’ve ever seen.");
        video2.AddComment(new Author("martha", ""), "Someone give this guy a teacher's award - One of the best breakdowns of a difficult subject I have seen");
        video2.AddComment(new Author("anonymoususer1", ""), "You summarized 2 whole days worth of lectures into 20 mins, thank you!!!");

        Video video3 = new Video("Graphic Design Basics | FREE COURSE", new Author("envatotuts", ""), 3040);
        video3.AddComment(new Author("user-ud23s3", ""), "Only tutorial I have watched to full length which is over an hour. You guys have done great effort to make that possible. Thank you....");
        video3.AddComment(new Author("JohnWall", ""), "I am Excited  Thank you so much");
        video3.AddComment(new Author("ricardospinelli", ""), "This is a very in-depth & thorough INTRODUCTION.\nWow.");

        Video video4 = new Video("I RACED My Self-Driving RC Car", new Author("stevengongg", ""), 1404);
        video4.AddComment(new Author("kiwi3t8", ""), "easy-to-move track boders seems like a massive oversight for something like this");
        video4.AddComment(new Author("boogie", ""), "The easiest way to adjust the gears is to put a slice of regular paper in between them and then tighten them.");
        video4.AddComment(new Author("paulsmith", ""), "You did excellent! You were right on pace with the other drivers, and this was your first shot.");
        video4.AddComment(new Author("ProducerRus", ""), "I love that you're making robotics fun and accessable. Keep up the great work!");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
    }
}