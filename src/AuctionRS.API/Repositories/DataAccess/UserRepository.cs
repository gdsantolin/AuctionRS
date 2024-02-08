using AuctionRS.API.Contracts;
using AuctionRS.API.Entities;

namespace AuctionRS.API.Repositories.DataAccess;

public class UserRepository : IUserRepository
{
    private readonly AuctionRSDbContext _dbContext;

    public UserRepository(AuctionRSDbContext dbContext) => _dbContext = dbContext;

    public bool ExistUserWithEmail(string email)
    {
        return _dbContext.Users.Any(user => user.Email.Equals(email));
    }

    public User GetUserByEmail(string email) => _dbContext.Users.First(user => user.Email.Equals(email));
}
