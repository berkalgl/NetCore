namespace DILifeCycle.Services
{
    public class GuidService
    {
        public readonly ISingletonGuidGenerator _singletonGuidGenerator;
        public readonly IScopedGuidGenerator _scopedGuidGenerator;
        public readonly ITransientGuidGenerator _transientGuidGenerator;

        public GuidService(ISingletonGuidGenerator singletonGuidGenerator, IScopedGuidGenerator scopedGuidGenerator, ITransientGuidGenerator transientGuidGenerator)
        {
            _singletonGuidGenerator = singletonGuidGenerator;
            _scopedGuidGenerator = scopedGuidGenerator;
            _transientGuidGenerator = transientGuidGenerator;
        }
    }
}
