﻿namespace FlyrodWebAppRazor.Models
{
    public class Flyrod
    {
        public int Id { get; set; }
        public int MakerId { get; set; }
        public string Model { get; set; }
        public double LengthFeet { get; set; }
        public int Sections { get; set; }
        public string LineWeight { get; set; }
        public int YearMade { get; set; }
        public string Type { get; set; }
        public string Construction { get; set; }

        public virtual Maker Maker { get; set; }

    }
}
