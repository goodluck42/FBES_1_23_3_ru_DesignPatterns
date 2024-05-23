namespace BehavioralPatterns.ObjectPool;

public interface IResettable
{
    void Reset();
}

public class Bottle : IResettable
{
    public float Amount { get; set; }
    public string? Material { get; set; }
    public string? Brand { get; set; }
    public string? Contents { get; set; }

    public void Reset()
    {
        Material = Brand = Contents = default;
        Amount = default;
    }
}

public interface IBottleService
{
    void Add(Bottle bottle);
    IEnumerable<Bottle> GetAll();
}

public interface IObjectPool<T>
    where T : IResettable, new()
{
    T Get();
    void Return(T @object);
}

// public class BottleService : IBottleService, IResettable
// {
//     public void Add(Bottle bottle)
//     {
//         throw new NotImplementedException();
//     }
//
//     public IEnumerable<Bottle> GetAll()
//     {
//         throw new NotImplementedException();
//     }
//
//     public void Reset()
//     {
//         throw new NotImplementedException();
//     }
// }