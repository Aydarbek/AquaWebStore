﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AquaWebStore.Models
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context db)
        {
            db.Users.Add( new Models.User { Login = "Admin", Password = "huawei", Name = "Aydar", EMail="a88236@gmail.com" });


            Category SwimSuite = new Category { Name = "Swimming Suites", Description = "Cool and modern models of suits for swimming" };
            Category SportSuite = new Category { Name = "Sport Suites", Description = "Cool and modern models of suits for aqua sports - Surfing, Kiting, Waking, anything" };


            db.Categories.Add(SwimSuite);
            db.Categories.Add(SportSuite);


            Photo SpSuitM1_front = new Photo { Path = @"\SportSuites\SpSuit_M1_front.jpg" };
            Photo SpSuitM1_back = new Photo { Path = @"\SportSuites\SpSuit_M1_back.jpg" };
            Photo SpSuitM2_front = new Photo { Path = @"\SportSuites\SpSuit_M2_front.jpg" };
            Photo SpSuitM2_back = new Photo { Path = @"\SportSuites\SpSuit_M2_back.jpg" };
            Photo SpSuitM3_front = new Photo { Path = @"\SportSuites\SpSuit_M3_front.jpg" };
            Photo SpSuitM3_back = new Photo { Path = @"\SportSuites\SpSuit_M3_back.jpg" };

            Photo SwSuitS1_front = new Photo { Path = @"\SwimSuites\SwSuit_S1_front.jpg" };
            Photo SwSuitS1_back = new Photo { Path = @"\SwimSuites\SwSuit_S1_back.jpg" };
            Photo SwSuitS2_front = new Photo { Path = @"\SwimSuites\SwSuit_S2_front.jpg" };
            Photo SwSuitS2_back = new Photo { Path = @"\SwimSuites\SwSuit_S2_back.jpg" };

            db.Photos.Add(SpSuitM1_front);
            db.Photos.Add(SpSuitM1_back);
            db.Photos.Add(SpSuitM2_front);
            db.Photos.Add(SpSuitM2_back);
            db.Photos.Add(SpSuitM3_front);
            db.Photos.Add(SpSuitM3_back);

            db.Photos.Add(SwSuitS1_front);
            db.Photos.Add(SwSuitS1_back);
            db.Photos.Add(SwSuitS2_front);
            db.Photos.Add(SwSuitS2_back);



            Hsuit SpSuitM1 = new Hsuit { Name = "SpSuitM1", Description = "Good model for surf", Size = "M", Price = 7000 };
            SpSuitM1.Category = SportSuite;
            SpSuitM1.Photo.Add(SpSuitM1_front);
            SpSuitM1.Photo.Add(SpSuitM1_back);

            Hsuit SpSuitM2 = new Hsuit { Name = "SpSuitM2", Description = "Best model for surf", Size = "M", Price = 8000 };
            SpSuitM2.Category = SportSuite;
            SpSuitM2.Photo.Add(SpSuitM2_front);
            SpSuitM2.Photo.Add(SpSuitM2_back);

            Hsuit SpSuitM3 = new Hsuit { Name = "SpSuitM3", Description = "Beatiful model for surf", Size = "M", Price = 7500 };
            SpSuitM3.Category = SportSuite;
            SpSuitM3.Photo.Add(SpSuitM3_front);
            SpSuitM3.Photo.Add(SpSuitM3_back);

            db.Hsuits.Add(SpSuitM1);
            db.Hsuits.Add(SpSuitM2);
            db.Hsuits.Add(SpSuitM3);



            Hsuit SwSuitS1 = new Hsuit { Name = "SwSuitS1", Description = "Best model for swim", Size = "S", Price = 6000 };
            SwSuitS1.Category = SwimSuite;
            SwSuitS1.Photo.Add(SwSuitS1_front);
            SwSuitS1.Photo.Add(SwSuitS1_back);

            Hsuit SwSuitS2 = new Hsuit { Name = "SwSuitS2", Description = "Good model for swim", Size = "S", Price = 5000 };
            SwSuitS2.Category = SwimSuite;
            SwSuitS2.Photo.Add(SwSuitS2_front);
            SwSuitS2.Photo.Add(SwSuitS2_back);

            db.Hsuits.Add(SwSuitS1);
            db.Hsuits.Add(SwSuitS2);

            db.SaveChanges();
        }

    }
}