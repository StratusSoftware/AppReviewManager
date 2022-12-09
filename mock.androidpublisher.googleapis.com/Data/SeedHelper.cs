using AppReview.Shared.Models.Review;
using System.Globalization;

namespace mock.androidpublisher.googleapis.com.Data;

public class SeedHelper
{
    public SeedHelper(ILogger<SeedHelper> logger)
    {
        
    }

    public void SeedData(ApplicationDbContext context)
    {
        context.Reviews.Add(new Review
        {
            PackageName = "com.Trailmix.LoveAndPiesMerge",
            Id = Guid.NewGuid(),
            AuthorName = "moran ickle",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    ReviewId = new Guid("37846734-172e-4149-8cec-6f43d1eb3f60"),
                    Text = "This is one of the only mobile games I've played long term, I play it every day. I see a lot of complaints about how everything costs too much now and you have to use real money but I haven't spent any money on this.You can if you want to finish goals quick but I pop in a few times a day and I still consistently reach the point where the story has finished.Then every update the story continues!I love the story and graphics, can't ask for me.",
                    ThumbsUpCount = 21,
                    ThumbsDownCount = 0,
                    StarRating = 5,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S21",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CommentId = new Guid("57846734-172e-4149-8cec-6f43d1eb3f60"),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S21",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 2048,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.Trailmix.LoveAndPiesMerge",
            Id = Guid.NewGuid(),
            AuthorName = "Jennifer Du Randt",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    Text = "Great merge game. Cute story and graphics. As you get going, you do run out of energy however it does regenerate 1 energy every 2 mins. So I leave it for a bit and get a notification when it's full. The items that produce the things you nerd to merge also have a limit but again will renew quickly. Only issue I have is that the game will crash/close regularly in the middle of doing something, clearing cookies doesn't always work hence the loss of a star.",
                    ThumbsUpCount = 12,
                    ThumbsDownCount = 0,
                    StarRating = 5,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S22",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S22",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 4096,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.Trailmix.LoveAndPiesMerge",
            Id = Guid.NewGuid(),
            AuthorName = "Alex B",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    Text = "I've been playing this for a few months now and am the end of the current storyline. Looking forward to it continuing. The competitions could be a little more diverse in prizes - the boxes should be mergable as baskets are unavailable to me (as the storyline pending). All in all, a very fun game, not necessary to spend money if you have the patience.",
                    ThumbsUpCount = 12,
                    ThumbsDownCount = 0,
                    StarRating = 4,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S22",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S22",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 4096,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.Trailmix.LoveAndPiesMerge",
            Id = Guid.NewGuid(),
            AuthorName = "Matthew Kerr",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    Text = "It is a decent game with good graphics and good storyline so far. (Been playing for about 3 hours so far). The only issue I have is the whole energy thing. From a developer point of view it puts off people playing it. Because you get so far and then just have to wait. I'd rather pay £2-£5 for the game without having that e ergy refill that being bombarded with extras or refills to carry on playing the game. Just something to consider rather than the Microtransactions. Do it for the customer.",
                    ThumbsUpCount = 47,
                    ThumbsDownCount = 0,
                    StarRating = 3,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S20",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S20",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 4096,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.Trailmix.LoveAndPiesMerge",
            Id = Guid.NewGuid(),
            AuthorName = "Geena Buck",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    Text = "A wonderful story that weaves through the lives of many diverse characters! The tasks and story are amusing and challenging enough to hold your interest, but not so much that you feel defeated. The board is the smallest I've ever played a merge game on, but that makes it easier for big thumbs and visibility. Not too many ads. There's not yet a way to divide items and I wish there were more opportunities for earning in-game gems. The pros far outweigh the cons, a well-deserved 5 stars.",
                    ThumbsUpCount = 4,
                    ThumbsDownCount = 1,
                    StarRating = 5,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S20",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S20",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 4096,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.king.candycrushsaga",
            Id = Guid.NewGuid(),
            AuthorName = "Heather Bee",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    ReviewId = new Guid("37846734-172e-4149-8cec-6f43d1eb3f60"),
                    Text = "It does seem that you are lured in to spending money. Takes days sometimes to clear a level. The silly add-ons like win 10 games in a row are quite simply utterly ludicrous - and totally unachievable without expensive purchases, if you're past level 2000. I still play it as it's relaxing and addictive! Make the in app purchases more appealing, ie cheaper please.",
                    ThumbsUpCount = 21,
                    ThumbsDownCount = 0,
                    StarRating = 5,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S21",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CommentId = new Guid("57846734-172e-4149-8cec-6f43d1eb3f60"),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S21",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 2048,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.king.candycrushsaga",
            Id = Guid.NewGuid(),
            AuthorName = "A Google user",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    ReviewId = new Guid("37846734-172e-4149-8cec-6f43d1eb3f60"),
                    Text = "It's not easy but relaxing,and helps take a lot of tention off of your mind while you try to get done. The prizes and gifts along with directions are easy to understand.I like the object that it has alot more to do in the level and you can work with my family. It be a lot more fun if my phone would stop freezing up. I checked how much memeory was on my phone and it was only at 20 percent filled. I'm use to being patient with it.",
                    ThumbsUpCount = 2,
                    ThumbsDownCount = 1,
                    StarRating = 3,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S10",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CommentId = new Guid("57846734-172e-4149-8cec-6f43d1eb3f60"),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S10",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 2048,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.king.candycrushsaga",
            Id = Guid.NewGuid(),
            AuthorName = "Pammy Rackley",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    ReviewId = new Guid("37846734-172e-4149-8cec-6f43d1eb3f60"),
                    Text = "So much Fun!! I love how fun it is to go level after level even if I have to try a level again and again, lol. And the way it is set up, it is easy for me to take a break if I lose all my lives because I get automatic lives without having to pay. What else? I just love how colorful it is and how automated it is, making wins easier even with less skills! Thank you!!",
                    ThumbsUpCount = 179,
                    ThumbsDownCount = 5,
                    StarRating = 4,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S10",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CommentId = new Guid("57846734-172e-4149-8cec-6f43d1eb3f60"),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S10",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 2048,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.king.candycrushsaga",
            Id = Guid.NewGuid(),
            AuthorName = "Austin McMullin",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    ReviewId = new Guid("37846734-172e-4149-8cec-6f43d1eb3f60"),
                    Text = "Possibly rigged time waster. I'm on level 11,430 and I've never spent a penny of real money on this game, and with how many ads they shove in your face, they still make bank even if you don't spend any real money. Play for free, skip the ads, and it's an enjoyable game. Don't let \"the man\" win.",
                    ThumbsUpCount = 1348,
                    ThumbsDownCount = 5,
                    StarRating = 4,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S10",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CommentId = new Guid("57846734-172e-4149-8cec-6f43d1eb3f60"),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S10",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 2048,
                    },
                }
            },
        });

        context.Reviews.Add(new Review
        {
            PackageName = "com.king.candycrushsaga",
            Id = Guid.NewGuid(),
            AuthorName = "Deniece Benton",
            Comments = new List<Comment>() {new Comment
                {
                    Id = Guid.NewGuid(),
                    ReviewId = new Guid("37846734-172e-4149-8cec-6f43d1eb3f60"),
                    Text = "Very challenging for an old lady! I know this is petty but, I wish they'd put the old tune back on that you could hear in the background as you played the game. The one on now, just don't fit the game at all.. The music plays a big part of the challenge!",
                    ThumbsUpCount = 1348,
                    ThumbsDownCount = 5,
                    StarRating = 4,
                    AndroidOsVersion = 10,
                    AppVersionCode = 1,
                    AppVersionName = "0.125",
                    Device = "S9",
                    DeviceMetadata = new DevicemetaData
                    {
                        Id = Guid.NewGuid(),
                        CommentId = new Guid("57846734-172e-4149-8cec-6f43d1eb3f60"),
                        CpuMake = "Intel",
                        Manufacturer = "Samsung",
                        ProductName = "Galaxy S9",
                        ScreenHeightPx = 1040,
                        ScreenWidthPx = 800,
                        RamMb = 2048,
                    },
                }
            },
        });


        context.SaveChanges();

    }
}

