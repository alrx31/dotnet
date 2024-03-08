using System.Text.Json;

namespace course.Models;

public class Product
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int[] Ratings { get; set; }
    public override string ToString() => JsonSerializer.Serialize<Product>(this);
    
}