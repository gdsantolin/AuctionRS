using AuctionRS.API.Entities;

namespace AuctionRS.API.Contracts;

public interface IAuctionRepository
{
    public Auction? GetCurrent();
}
