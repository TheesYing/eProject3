﻿namespace Ice_Cream.Models
{
    public class FAQ
    {
        public int Id { get; set; }
        public int? RecipeId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}