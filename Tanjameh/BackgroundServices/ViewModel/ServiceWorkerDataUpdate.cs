namespace Tanjameh.BackgroundServices.ViewModel;

public record ServiceWorkerDataUpdate(
    ServiceWorkerStatusEnum Status,
    string Message,
    object? Model = null) 
{
    public DateTime DateTime { get; init; } = DateTime.Now;

};


public enum ServiceWorkerStatusEnum
{
    None,
    Start,
    InProgress,
    Stop,
    Error
}
