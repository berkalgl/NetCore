namespace DILifeCycle.Services
{
    public interface ISingletonGuidGenerator
    {
        Guid Guid { get; }
    }
    public interface IScopedGuidGenerator
    {
        Guid Guid { get; }  
    }
    public interface ITransientGuidGenerator
    {
        Guid Guid { get; }
    }
}
