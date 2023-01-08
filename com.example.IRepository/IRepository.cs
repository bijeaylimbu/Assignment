namespace com.example.IRepository;

public interface IRepository <T> where  T: class
{
    IUnitOfWork UnitOfWork { get; set; }
}