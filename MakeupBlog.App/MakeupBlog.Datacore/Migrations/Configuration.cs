namespace MakeupBlog.Datacore.Migrations
{
    using MakeupBlog.Domain.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MakeupBlog.Datacore.Context.BlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MakeupBlog.Datacore.Context.BlogDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.MasterCategories.AddOrUpdate(x => x.Name,
                new MasterCategory
                {
                    Name = "Makeup Looks & Ideas"
                },
                new MasterCategory
                {
                    Name = "Beauty Tips"
                },
                new MasterCategory
                {
                    Name = "Makeup Tutorials"
                });

            context.Categories.AddOrUpdate(x => x.Name,
                new Category
                {
                    Name = "Natural Makeup Looks",
                    MasterCategoryId = 2
                },
                new Category
                {
                    Name = "Nude Makeup Looks",
                    MasterCategoryId = 2
                },
                new Category
                {
                    Name = "Smokey Eye Looks",
                    MasterCategoryId = 2
                },
                new Category
                {
                    Name = "Makeup for Beginners",
                    MasterCategoryId = 3
                },
                new Category
                {
                    Name = "Makeup Hacks",
                    MasterCategoryId = 3
                },
                new Category
                {
                    Name = "Makeup for Sensitive Skin",
                    MasterCategoryId = 3
                },
                new Category
                {
                    Name = "Eye Makeup Tutorial",
                    MasterCategoryId = 4
                },
                new Category
                {
                    Name = "Lip Makeup Tutorial",
                    MasterCategoryId = 4
                },
                new Category
                {
                    Name = "Foundation Tutorial",
                    MasterCategoryId = 4
                });
            context.ArticleImages.AddOrUpdate(x => x.Path,
                new ArticleImage
                {
                    Path = "MakeupBlog.App/Content/images/naturalmk.jpg",
                    Article = new Article
                    {
                        Title = "5-Minute Simply Natural Makeup Tutorial",
                        CategoryId = 6,
                        Content = "Looking for a natural makeup look? We’re getting tired of the fact that some natural makeup looks tend to take far longer than a glam Instagram look. Sometimes you just need the essentials to look both chic and professional for your next work meeting. Or maybe you just want to freshen up a bit for a last minute coffee date with your BFF. The key for a quick natural makeup look is to work smarter, not harder. We’re spotlighting the best multitasking makeup products for this quick 5 minute routine - because who doesn’t want that extra 15 minutes of beauty sleep? Practice makes perfect, and soon you’ll have this routine down to a tee!",
                    }

                },
                new ArticleImage
                {
                    Path = "MakeupBlog.App/Content/images/nudelips.jpg",
                    Article = new Article
                    {
                        Title = "A Simple Guide to Picking Your Perfect Nude Lipstick",
                        CategoryId = 7,
                        Content = "You can never go wrong with a nude lip. It can be the perfect balance to a glamorous smoky eye, or serve as the final touch to a barely-there beauty vibe. But for a shade that's seemingly easy to pull off, finding the perfect natural shade can be surprisingly difficult. If you go too cool, you risk washing out your complexion; too warm and you can wind up looking like you accidentally applied beige foundation all over your lips. ",
                    }
                },
                new ArticleImage
                {
                    Path = "MakeupBlog.App/Content/images/smokeyeye.jpg",
                    Article = new Article
                    {
                        Title = "A 5-Minute Smokey Eye Tutorial that will Change Your Life",
                        CategoryId = 8,
                        Content = "A smokey eye is perhaps the most sought-after yet intimidating eye makeup look that we all wish we could master. While the cut-crease and glitter eye makeup looks are probably best left to the pro’s, getting a handle on the smokey eye isn’t as daunting a task. Believe it or not but this easy hack will give you a smokey eye in five minutes, and using only 5 products. It’s quick, beginner-friendly, and can be as bold or subtle as you’d like. Pair this look with a sultry cocktail dress or a chic blazer and we guarantee all eyes will be on you!",
                    }
                },
                new ArticleImage
                {
                    Path = "MakeupBlog.App/Content/images/img_3.jpg",
                    Article = new Article
                    {
                        Title = "How to clean your makeup brushes",
                        CategoryId = 9,
                        Content = "We paint, contour, and highlight our faces with makeup brushes every day, but we can't always say the same thing about how frequently we're cleaning those brushes. Giving them a thorough washing every month or so is not enough. (Shocker.) According to dermatologists and makeup artists, we should be sudsing up our tools far more often in order to prevent bacteria buildup, which can lead to breakouts. ",
                    }
                },
                new ArticleImage
                {
                    Path = "MakeupBlog.App/Content/images/mattelip.jpg",
                    Article = new Article
                    {
                        Title = "4 Hacks to Get Moisturizing Matte Lip Color",
                        CategoryId = 10,
                        Content = "There’s no denying it; the matte lip trend is going strong in the makeup community. Celebrities, bloggers and models alike are sporting this chic look for every occasion. While we still love our creamy, conditioning lipsticks and hydrating lip glosses, we also know how fun it is to change up your style sometimes. If you want to try this lipstick trend, we have a few easy hacks to create a matte lip color with products that are already in your makeup bag. 1) Skip the Gloss, 2) Use a Mattifying Powder, 3) Customize Your Matte Color, 4) Stencil with a Pencil.",
                    }
                },
                new ArticleImage
                {
                    Path = "MakeupBlog.App/Content/images/foundation.jpg",
                    Article = new Article
                    {
                        Title = "What’s the Best Foundation for Your Skin Type?",
                        CategoryId = 11,
                        Content = "If you have dry skin, your best foundation will rehydrate your skin cells and add a dewy finish. Hannah recommends using Liquid Minerals with Amazing Base Loose Mineral Powder on top. When you have oily skin, you need a foundation that will mattify your complexion without feeling heavy. Edgar recommends PurePressed Base Mineral Foundation as the best powder foundation if your skin is on the oilier side. If you have combination skin that tends to be on the drier side, stick with a product that will hydrate and add a dewy glow like Glow Time BB Cream or Amazing Base.",
                    }
                },
                 new ArticleImage
                 {
                     Path = "MakeupBlog.App/Content/images/img_2.jpg",
                     Article = new Article
                     {
                         Title = "Summertime Shimmery Eye Look",
                         CategoryId = 12,
                         Content = "Who doesn’t love a little shimmer during the summer months? Check out this luxe summer eye look with you to add a little shimmer to your summertime look. Featuring our Solar Flare Eye Shadow Kit, this look features warm-toned shades that are long-lasting and highly-pigmented. Ah, sweet summertime! When the sun is shining and your plans include plenty of selfies on the beach and at the park, you’ll want to make sure that your makeup look is on point. And we know just the right way to do so. It’s time to level up with trendy summer eyeshadow looks! All you need is the perfect combination of beauty trends and eyeshadow picks to create an eye makeup masterpiece. Interested? ",
                     }
                 },
                 new ArticleImage
                 {
                     Path = "MakeupBlog.App/Content/images/liptut.jpg",
                     Article = new Article
                     {
                         Title = "Pro Tips: How to Wear Red Lipstick",
                         CategoryId = 13,
                         Content = "Valentine’s Day is around the corner, and two colors are on our mind – pink and red. Pink is our favorite lipstick color when we want to create an effortless, natural makeup look. But, red is the shade we choose when we want to stand out and feel confident. You may think a red lip is only for movie stars and women who drink everything out of straws. But we’re here to show you how easy it is to create a red pout that works with your style. Keep reading for simple tips from our Global Makeup Educators on how to wear red lipstick.",
                     }
                 },
                 new ArticleImage
                 {
                     Path = "MakeupBlog.App/Content/images/liqfoun.jpg",
                     Article = new Article
                     {
                         Title = "How to Apply Liquid Foundation",
                         CategoryId = 14,
                         Content = "Learning how to properly apply liquid foundation is almost as important as finding the right shade and formula for your skin tone and type. If you apply too much foundation, you may end up with a cakey finish, and if you apply too little the finish could end up sheer. There’s also the question of whether to apply liquid foundation with a brush, a sponge or your fingers.We know how important foundation is— it’s literally the base of your makeup look! That’s why we have a series of makeup tutorial videos on YouTube to show you how to properly apply different types of products from liquid foundation to tinted moisturizer. leaving your lips feeling dried and chapped. (Pro Tip: Use the flocked Sponge to roll-press PurePressed Base to your bare lips prior to applying the lip liner. This will ensure you get the truest color possible.)",
                     }
                 });
        }
    }
}
