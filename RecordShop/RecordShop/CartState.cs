using System.Collections.Generic;
using System.Linq;

// Holds the shopping cart for the current session (scoped per Blazor circuit).
public class CartState
{
    public List<CartItem> Items { get; } = new();

    public void Add(Album album)
    {
        var existing = Items.FirstOrDefault(i => i.Album.Id == album.Id);
        if (existing != null)
        {
            existing.Quantity++;
        }
        else
        {
            Items.Add(new CartItem { Album = album, Quantity = 1 });
        }
    }

    public void Remove(int albumId)
    {
        Items.RemoveAll(i => i.Album.Id == albumId);
    }

    public void Clear()
    {
        Items.Clear();
    }

    public int Count => Items.Sum(i => i.Quantity);

    public decimal Total => Items.Sum(i => i.Album.Price * i.Quantity);
}

public class CartItem
{
    public Album Album { get; set; } = default!;
    public int Quantity { get; set; }
}
