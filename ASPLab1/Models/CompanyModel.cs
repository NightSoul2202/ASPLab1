﻿namespace ASPLab1.Models
{
    public class CompanyModel
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public double Capitalization { get; set; }
    }
}
