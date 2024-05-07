namespace CreationalPatterns.FactoryMethod;

public interface IWriterFactory
{
    IWriter Create(object obj);
}