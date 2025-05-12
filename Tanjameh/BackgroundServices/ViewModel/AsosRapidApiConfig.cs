using System;
using System.Text.Json.Serialization;

namespace Tanjameh.BackgroundServices.ViewModel;

public class AsosRapidApiConfig
{
    public const string RapidApiConfig = "RapidApiConfig:Asos";

    public string Key { get; set; } = string.Empty;

    public string Host { get; set; } = string.Empty;
}
