using AuctionRS.API.Entities;

namespace AuctionRS.API.Contracts;

public interface IUserRepository
{
    public bool ExistUserWithEmail(string email);

    User GetUserByEmail(string email);
}
