﻿namespace LibraryApi.Classes
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public float Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
