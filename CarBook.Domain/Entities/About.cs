﻿namespace CarBook.Domain.Entities;

public class About
{
    public int AboutID { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
}
