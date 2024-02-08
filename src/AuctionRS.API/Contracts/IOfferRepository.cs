using AuctionRS.API.Entities;

namespace AuctionRS.API.Contracts;

public interface IOfferRepository
{
    void Add(Offer offer);
}
