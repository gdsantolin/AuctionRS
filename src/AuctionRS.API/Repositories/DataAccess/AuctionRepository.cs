using AuctionRS.API.Contracts;
using AuctionRS.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionRS.API.Repositories.DataAccess;

public class AuctionRepository : IAuctionRepository
{
    private readonly AuctionRSDbContext _dbContext;

    public AuctionRepository(AuctionRSDbContext dbContext) => _dbContext = dbContext;
    
    public Auction? GetCurrent()
    {
        var today = DateTime.Now;

        return _dbContext
            .Auctions
            .Include(auction => auction.Items)
            .FirstOrDefault();
    }
}
