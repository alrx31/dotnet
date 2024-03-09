using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using onlineshop.Models;
using onlineshop.Controllers;
var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
    .Build();





using (var context = new OnlineShopDbContext())
{
    
    Console.WriteLine("Database created");        
    
    
    
}