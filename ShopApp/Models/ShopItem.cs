﻿namespace ShopApp.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public float Price { get; set; }

        public ShopItem()
        {

        }

    }
}
