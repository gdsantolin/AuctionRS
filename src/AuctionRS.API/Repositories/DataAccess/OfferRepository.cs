using AuctionRS.API.Contracts;
using AuctionRS.API.Entities;

namespace AuctionRS.API.Repositories.DataAccess;

public class OfferRepository : IOfferRepository
{
    private readonly AuctionRSDbContext _dbContext;

    public OfferRepository(AuctionRSDbContext dbContext) => _dbContext = dbContext;

    public void Add(Offer offer)
    {
        _dbContext.Offers.Add(offer);

        _dbContext.SaveChanges();
    }
}
