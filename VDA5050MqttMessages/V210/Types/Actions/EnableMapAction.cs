namespace VDA5050MqttMessages.V210.Types.Actions;
public class EnableMapAction : Action
{
    public EnableMapAction(string mapId, string mapVersion) : base(
        "enableMap",
        Guid.NewGuid().ToString(),
        "Enable a previously downloaded map explicitly to be used in orders without initializing a new position. ",
        BlockingTypes.SOFT)
    {
        ActionParameters.Add("mapId", mapId);
        ActionParameters.Add("mapVersion", mapVersion);
    }
}
