namespace CreationalPatterns.FactoryMethod;

// not recommended
public class WriterFactory : IWriterFactory
{
    public IWriter Create(object obj)
    {
        if (obj is int value)
        {
            if (value == 1)
            {
                return new JsonWriter(null!);
            }

            if (value == 2)
            {
                return new TextWriter(null!);
            }
        }

        throw new ArgumentOutOfRangeException(nameof(obj));
    }
}