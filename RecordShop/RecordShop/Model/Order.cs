using System;
using System.Collections.Generic;

public class Order
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public List<OrderItem> Items { get; set; } = new();
    public decimal Total { get; set; }
}

public class OrderItem
{
    public int AlbumId { get; set; }
    public string AlbumName { get; set; } = "";
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
