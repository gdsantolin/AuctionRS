using AuctionRS.API.Entities;
using AuctionRS.API.UseCases.Auctions.GetCurrent;
using Microsoft.AspNetCore.Mvc;

namespace AuctionRS.API.Controllers;

public class AuctionController : AuctionRSController
{
    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrentAuction([FromServices] GetCurrentAuctionUseCase useCase)
    {  
        var result = useCase.Execute();

        if(result is null)
            return NoContent();

        return Ok(result);
    }

    

}
