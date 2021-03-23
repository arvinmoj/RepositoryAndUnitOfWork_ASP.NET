namespace Data
{
    public class UserRepository : Base.Repository<Models.User> , IUserRepository
    {
        internal UserRepository (DatabaseContext databaseContext) : base(databaseContext)
        {
        }
    }
}