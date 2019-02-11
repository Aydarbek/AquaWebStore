using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AquaWebStore.Models
{
    public class Hsuit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Sex { get; set; }
        public int Size { get; set; }
        public int Price { get; set; }
        public virtual Collection Collection { get; set; }


        public Hsuit()
        {
            Id = 1;
            Name = "Касатка";
            Description = "Гидрокостюм женский закрытый";
            Photo = "Kasatka.jpg";
            Sex = "F";
            Size = 50;
            Price = 7000;
        }
    }
}