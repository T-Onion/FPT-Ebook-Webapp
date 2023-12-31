﻿namespace FPT_Ebook.ViewModels
{
    public class CartItem
    {
        public int BookId { get; set; }

        public string? Title { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string? ImagePath { get; set; }

        public decimal? TotalPrice => Price * Quantity;
    }
}
