using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AquaWebStore.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context db)
        {
            db.Users.Add(new Models.User { Login = "Admin", Password = "huawei", Name = "Aydar", EMail="a88236@gmail.com" });
            db.SaveChanges();
        }

    }
}