namespace Actio.Common.Events
{
    public interface IRejected : IEvent
    {
        string Reason { get; }
        string Code { get; }
    }
}