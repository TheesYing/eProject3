﻿namespace Ice_Cream.DTO
{
    public class UpdateBookDTO
    {
        public int Id { get; set; }
        public string? BookName { get; set; }
        public string? BookDescription { get; set; }
        public float? Price { get; set; }
        public string? BookImage { get; set; }
    }
}
