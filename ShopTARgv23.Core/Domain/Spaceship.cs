﻿namespace ShopTARgv23.Core.Domain
{
    public class Spaceship
    {
        public Guid? Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public DateTime? BuiltDate { get; set; }
        public int? CargoWeight { get; set; }
        public int? Crew { get; set; }
        public int? EnginePower { get; set; }

        //only in db
        public DateTime? CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}