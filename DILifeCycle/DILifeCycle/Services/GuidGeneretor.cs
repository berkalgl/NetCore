namespace DILifeCycle.Services
{
    public class SingletonGuidGenerator : ISingletonGuidGenerator
    {
        public SingletonGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }

        public Guid Guid { get; set; }
    }
    public class ScopedGuidGenerator : IScopedGuidGenerator
    {
        public ScopedGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }

        public Guid Guid { get; set; }
    }
    public class TransientGuidGenerator : ITransientGuidGenerator
    {
        public TransientGuidGenerator()
        {
            Guid = Guid.NewGuid();
        }

        public Guid Guid { get; set; }
    }
}
