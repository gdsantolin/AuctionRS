using AuctionRS.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionRS.API.Repositories;

public class AuctionRSDbContext : DbContext
{
    public AuctionRSDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

}
