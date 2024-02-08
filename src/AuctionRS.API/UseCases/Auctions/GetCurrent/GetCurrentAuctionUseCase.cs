using AuctionRS.API.Contracts;
using AuctionRS.API.Entities;
using AuctionRS.API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AuctionRS.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    private readonly IAuctionRepository _repository;

    public GetCurrentAuctionUseCase(IAuctionRepository repository) => _repository = repository;

    public Auction? Execute() => _repository.GetCurrent();

}
