namespace WebApplication3.Migrations.StoreConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication3.Models;

    internal sealed class StoreConfiguration : DbMigrationsConfiguration<WebApplication3.Models.StoreContext>
    {
        public StoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication3.Models.StoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var categories = new List<Category>
             {
                    new Category {Name = "Young Adult"},
                    new Category {Name = "Science Fiction"},
                    new Category {Name = "Fantasy"},
                    new Category {Name = "Fiction"},
                    new Category {Name = "Children"},
                    new Category {Name = "Horror"},
                    new Category {Name = "Action Adventure"},
                    new Category {Name = "Dark Horse"},
                    new Category {Name = "Romance"},
                    new Category {Name = "Fantasy Magic"},
                    new Category {Name = "Humor Entertainment"},
                    new Category {Name = "Arts Music"},
                    new Category {Name = "Humor"},
                    new Category {Name = "Love Romance"},
                    new Category {Name = "Education"},
                    new Category {Name = "Mystery"},
                    new Category {Name = "Gay Lesbian"}
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            var products = new List<Product>
             {
                    new Product {Name = "One Piece", Description = "A Japanese manga series written and illustrated by Eiichiro Oda. The story follows the adventures of Monkey D. Luffy, which is to explore the Grand Line for the world's ultimate treasure.", Price =999.99M, CategoryID= categories.Single(c=>c.Name == "Young Adult").ID},
                    new Product {Name = "Naruto", Description = "A Japanese manga series written and illustrated by Masashi Kishimoto. It tells Naruto Uzumaki seeks to gain recognition and also dreams of becoming the Hokage, the leader of his village.", Price =888.99M, CategoryID= categories.Single(c=>c.Name == "Young Adult").ID},
                    new Product {Name = "Bleach", Description = "A Japanese shonen manga series written and illustrated by Tite Kubo. Bleach follows the adventures of the hotheaded teenager Ichigo Kurosaki.", Price =888.99M, CategoryID= categories.Single(c=>c.Name == "Young Adult").ID},
                    new Product {Name = "Dragon Ball", Description = "A Japanese manga created by Akira Toriyama in 1984. Dragon Ball was initially inspired by the classical Chinese novel Journey to the West, as well as Hong Kong martial arts films.", Price =555.09M, CategoryID= categories.Single(c=>c.Name == "Action Adventure").ID},
                    new Product {Name = "FAIRY TAIL", Description = "A Japanese manga series written and illustrated by Hiro Mashima.It was serialized in Kodansha's Weekly Shonen Magazine from August 2, 2006 to July 26, 2017.", Price =333M, CategoryID= categories.Single(c=>c.Name == "Young Adult").ID},
                    new Product {Name = "xxxHOLi", Description = "A manga written and illustrated by the group of manga artists known as Clamp.The series, which crosses over with another Clamp work Tsubasa: Reservoir Chronicle.", Price =520.66M, CategoryID= categories.Single(c=>c.Name == "Fantasy Magic").ID},
                    new Product {Name = "Inuyasha", Description = "A Japanese manga series written and illustrated by Rumiko Takahashi. The series begins with Kagome Higurashi from modern-day Tokyo is transported to the Sengoku period of Japan.", Price =131.4M, CategoryID= categories.Single(c=>c.Name == "Love Romance").ID},
                    new Product {Name = "Tokyo Ghoul", Description = "A Japanese dark fantasy manga series written and illustrated by Sui Ishida. It was serialized in Shueisha's seinen manga magazine Weekly Young Jump between September 2011 and September 2014.", Price =110.34M, CategoryID= categories.Single(c=>c.Name == "Horror").ID},
                    new Product {Name = "Tsubasa: Reservoir Chronicle", Description = "A Japanese manga series written and illustrated by the manga artist group Clamp. It takes place in the same fictional universe as many of Clamp's other manga series, most notably xxxHolic.", Price =78, CategoryID= categories.Single(c=>c.Name == "Action Adventure").ID},
                    new Product {Name = "The Prince of Tennis", Description = "A Japanese manga series written and illustrated by Takeshi Konomi.It was serialized in Shueisha's Weekly Shonen Jump from July 1999 to March 2008.", Price =42.8M, CategoryID= categories.Single(c=>c.Name == "Humor Entertainment").ID},
                    new Product {Name = "D.Gray-man", Description = "A Japanese manga series written and illustrated by Katsura Hoshino. The story of a young Allen Walker.", Price = 631.56M, CategoryID= categories.Single(c=>c.Name == "Action Adventure").ID},
                    new Product {Name = "Food Wars! Shokugeki no Soma", Description = "A Japanese shonen manga series written by Yuto Tsukuda and illustrated by Shun Saeki.", Price =478.29M, CategoryID= categories.Single(c=>c.Name == "Horror").ID},
                    new Product {Name = "HUNTER HUNTER", Description = "A Japanese manga series written and illustrated by Yoshihiro Togashi.", Price =678.67M, CategoryID= categories.Single(c=>c.Name == "Action Adventure").ID},
                    new Product {Name = "Gin Tama", Description = "A Japanese manga written and illustrated by Hideaki Sorachi.", Price =888.21M, CategoryID= categories.Single(c=>c.Name == "Horror").ID},
                    new Product {Name = "Assassination Classroom", Description = "A Japanese comic science fiction manga series written and illustrated by Yusei Matsui. ", Price =578.87M, CategoryID= categories.Single(c=>c.Name == "Science Fiction").ID},
                    new Product {Name = "A Certain Magical Index", Description = "A Japanese light novel series written by Kazuma Kamachi and illustrated by Kiyotaka Haimura.", Price =777.77M, CategoryID= categories.Single(c=>c.Name == "Fantasy Magic").ID},
                    new Product {Name = "Shana", Description = "A Japanese light novel series written by Yashichiro Takahashi.", Price =472.13M, CategoryID= categories.Single(c=>c.Name == "Fantasy Magic").ID},
                    new Product {Name = "The Seven Deadly Sins", Description = "A Japanese fantasy manga series written and illustrated by Nakaba Suzuki.", Price =122.78M, CategoryID= categories.Single(c=>c.Name == "Fantasy").ID},
                    new Product {Name = "World Trigger", Description = "A Japanese manga series written and illustrated by Daisuke Ashihara, also known in short form as WorTri.", Price =98, CategoryID= categories.Single(c=>c.Name == "Science Fiction").ID},
                    new Product {Name = "From Me to You", Description = "A Japanese shojo romance manga by Karuho Shiina. It was published by Shueisha in Bessatsu Margaret.", Price =55.41M, CategoryID= categories.Single(c=>c.Name == "Romance").ID},
                    new Product {Name = "One-Punch Man", Description = "A Japanese superhero webcomic. It has a manga adaptation illustrated by Yusuke Murata, as well as an anime adaptation.", Price =255.65M, CategoryID= categories.Single(c=>c.Name == "Action Adventure").ID},
                    new Product {Name = "Medaka Box", Description = "A Japanese shonen manga written by Nisio Isin and illustrated by Akira Akatsuki.", Price =87.65M, CategoryID= categories.Single(c=>c.Name == "Fantasy").ID},
                    new Product {Name = "Re Monster", Description = "After his unfortunate death, Tomokui Kanata has been reincarnated as a member of the weakest race, a goblin named Rou.", Price =44.5M, CategoryID= categories.Single(c=>c.Name == "Fantasy").ID},
                    new Product {Name = "Vampire Knight", Description = "A Japanese shojo manga series written by Matsuri Hino. The series premiered in the January 2005 issue of LaLa magazine and officially ended in May 2013.", Price =100.56M, CategoryID= categories.Single(c=>c.Name == "Gay Lesbian").ID},
                    new Product {Name = "The Familiar of Zero", Description = "A fantasy and comedy-oriented series of Japanese light novels written by Noboru Yamaguchi, with illustrations by Eiji Usatsuka.", Price =256.58M, CategoryID= categories.Single(c=>c.Name == "Fantasy Magic").ID},
                    new Product {Name = "BTOOOM!", Description = "A Japanese manga series written and illustrated by Junya Inoue.", Price =385.28M, CategoryID= categories.Single(c=>c.Name == "Action Adventure").ID},
                    new Product {Name = "Future Diary", Description = "A Japanese manga series written and illustrated by Sakae Esuno. It was serialized in Kadokawa Shoten's Shonen Ace between January 26, 2006 and December 25, 2010.", Price =125.8M, CategoryID= categories.Single(c=>c.Name == "Science Fiction").ID},
                    new Product {Name = "Initial D", Description = "A Japanese street racing manga series written and illustrated by Shuichi Shigeno. It was serialized in Weekly Young Magazine from 1995 to 2013, collected 48 volumes by Kodansha.", Price =96.99M, CategoryID= categories.Single(c=>c.Name == "Young Adult").ID},
                    new Product {Name = "Sword Art Online", Description = "A Japanese light novel series written by Reki Kawahara and illustrated by abec.", Price =27.68M, CategoryID= categories.Single(c=>c.Name == "Fantasy").ID},
                    new Product {Name = "Another", Description = "A Japanese mystery horror novel by Yukito Ayatsuji, published on October 29, 2009 by Kadokawa Shoten.", Price =99.99M, CategoryID= categories.Single(c=>c.Name == "Horror").ID},
                    new Product {Name = "Shiki ", Description = "A horror novel by Japanese novelist Fuyumi Ono. A manga series adapting the story, drawn by Ryu Fujisaki was serialized in the Japanese monthly magazine Jump SQ.", Price =128.59M, CategoryID= categories.Single(c=>c.Name == "Horror").ID},
                    new Product {Name = "Sankarea Undying Love", Description = "A Japanese manga series written and illustrated by Mitsuru Hattori. The manga was serialized in Kodansha's Bessatsu Shonen Magazine between December 2009 and September 2014 for 11 tankobon volumes.", Price =72.41M, CategoryID= categories.Single(c=>c.Name == "Love Romance").ID},

            };
             products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
             context.SaveChanges();

            var orders = new List<Order>
            {
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                Town="Town1",
                 Country="Country", PostCode="PostCode" }, TotalPrice=999.99M,
                 UserID="admin@myStore.com", DateCreated=new DateTime(2014, 1, 1) ,
                 DeliveryName="Admin" },
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                Town="Town1",
                 Country="Country", PostCode="PostCode" }, TotalPrice=888.99M,
                 UserID="admin@myStore.com", DateCreated=new DateTime(2014, 1, 2) ,
                 DeliveryName="Admin" },
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                Town="Town1",
                 Country="Country", PostCode="PostCode" }, TotalPrice=888.99M,
                 UserID="admin@myStore.com", DateCreated=new DateTime(2014, 1, 3) ,
                 DeliveryName="Admin" },
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                Town="Town1",
                 Country="County", PostCode="PostCode" }, TotalPrice=999.99M,
                 UserID="admin@myStore.com", DateCreated=new DateTime(2014, 1, 4) ,
                 DeliveryName="Admin" },                 
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                Town="Town1",
                 Country="Country", PostCode="PostCode" }, TotalPrice=555.09M,
                 UserID="admin@myStore.com", DateCreated=new DateTime(2014, 1, 5) ,
                 DeliveryName="Admin" },
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                Town="Town1",
                 Country="Country", PostCode="PostCode" }, TotalPrice=72.41M,
                 UserID="admin@myStore.com", DateCreated=new DateTime(2014, 1, 6) ,
                 DeliveryName="Admin" }
                 };

            orders.ForEach(c => context.Orders.AddOrUpdate(o => o.DateCreated, c));
            context.SaveChanges();
            var orderLines = new List<OrderLine>
                {
                    new OrderLine { OrderID = 1, ProductID = products.Single( c=> c.Name == "One Piece").ID,
                    ProductName ="One Piece", Quantity =1, UnitPrice=products.Single( c=> c.Name == "One Piece").Price },
                    new OrderLine { OrderID = 2, ProductID = products.Single( c=> c.Name == "Naruto").ID,
                    ProductName="Naruto", Quantity=1, UnitPrice=products.Single( c=> c.Name =="Naruto").Price },
                    new OrderLine { OrderID = 3, ProductID = products.Single( c=> c.Name == "Naruto").ID,
                    ProductName ="Naruto", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Naruto").Price },
                    new OrderLine { OrderID = 4, ProductID = products.Single( c=> c.Name == "One Piece").ID,
                    ProductName ="One Piece", Quantity=1, UnitPrice=products.Single( c=> c.Name == "One Piece").Price },                
                    new OrderLine { OrderID = 5, ProductID = products.Single( c=> c.Name == "Dragon Ball").ID,
                    ProductName ="Dragon Ball", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Dragon Ball").Price },
                    new OrderLine { OrderID = 6, ProductID = products.Single( c=> c.Name == "Sankarea Undying Love").ID,
                    ProductName ="Sankarea Undying Love", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Sankarea Undying Love").Price }
                };
            orderLines.ForEach(c => context.OrderLines.AddOrUpdate(ol => ol.OrderID, c));
            context.SaveChanges();
        }
    }
}