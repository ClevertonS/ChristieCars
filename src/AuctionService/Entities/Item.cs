﻿using System.ComponentModel.DataAnnotations.Schema;
using AuctionService.Entities;

namespace AuctionService;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public string Make { get; set; } = string.Empty;
    public string Model {get; set; } = string.Empty;
    public int Year { get; set; }
    public string Color {get; set; } = string.Empty;
    public int Kilometer { get; set; }
    public string ImageUrl { get; set; } = string.Empty;

    //Nav propeties
    public Auction Auction {get; set;} 
    public Guid AuctionId {get; set;}
}
