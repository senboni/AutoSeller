﻿using Domain.Interaces;
using System;

namespace Domain.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public IApplicationUser Seller { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
