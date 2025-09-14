namespace VDA5050MqttMessages.V210.Types.Actions;
public class DownloadMapAction : Action
{
    public DownloadMapAction(string mapId, string mapVersion, string mapDownloadLink, string? mapHash = null) : base(
        "downloadMap",
        Guid.NewGuid().ToString(),
        "Trigger the download of a new map. Active during the download. Errors reported in vehicle state. Finished after verifying the successful download, preparing the map for use and setting the map in the state. ",
        BlockingTypes.HARD)
    {
        ActionParameters.Add("mapId", mapId);
        ActionParameters.Add("mapVersion", mapVersion);
        ActionParameters.Add("mapDownloadLink", mapDownloadLink);

        if (mapHash != null)
            ActionParameters.Add("mapHash", mapHash);
    }
}
