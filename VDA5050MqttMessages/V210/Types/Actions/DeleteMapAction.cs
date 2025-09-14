namespace VDA5050MqttMessages.V210.Types.Actions;
public class DeleteMapAction : Action
{
    public DeleteMapAction(string mapId, string mapVersion) : base(
        "deleteMap",
        Guid.NewGuid().ToString(),
        "Trigger the removal of a map from the vehicle memory.",
        BlockingTypes.NONE)
    {
        ActionParameters.Add("mapId", mapId);
        ActionParameters.Add("mapVersion", mapVersion);
    }
}
