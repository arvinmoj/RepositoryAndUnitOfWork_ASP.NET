namespace Data
{
    public interface IUnitOfWork : Base.IUnitOfWork
    {
         IUserRepository UserRepository {get;}
    }
}