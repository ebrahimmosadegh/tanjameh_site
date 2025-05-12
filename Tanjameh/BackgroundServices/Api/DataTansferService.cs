using DocumentFormat.OpenXml.ExtendedProperties;
using Tanjameh.BackgroundServices.ViewModel;

namespace Tanjameh.BackgroundServices.Api;

public class DataTansferService
{
    public const string FetchCategoryKey = "CategoryDataTansfer";
    public const string DownloadImageKey = "ImageDataTansfer";

    public event EventHandler<KeyValuePair<string, ServiceWorkerDataUpdate>> DataUpdated;
    public event EventHandler<KeyValuePair<string, ProgressValue>>? ProgressUpdated;

    public Dictionary<string, ServiceWorkerDataUpdate> CurrentData { get; private set; } =
        new Dictionary<string, ServiceWorkerDataUpdate>();

    public void UpdateData(string name, ServiceWorkerDataUpdate newData)
    {
        CurrentData[name] = newData;

        DataUpdated?.Invoke(this, new KeyValuePair<string, ServiceWorkerDataUpdate>(name, newData));
    }

    public void UpdateProgress(string name, ProgressValue progress)
    {
        ProgressUpdated?.Invoke(this, new KeyValuePair<string, ProgressValue>(name, progress));
    }
}

public  class ProgressValue
{
    public ProgressValue(int value, int total)
    {
        this.value = value;
        Total = total;
    }

    public float Progress => (Total == 0) ? 0 : value / (float)Total;

    public int value { get; }
    public int Total { get; }
}