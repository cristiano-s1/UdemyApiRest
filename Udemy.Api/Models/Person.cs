﻿namespace Udemy.Api.Models
{
    public class Person : BaseEntity
    {
        public string Address { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public bool Enabled { get; set; }
    }
}
