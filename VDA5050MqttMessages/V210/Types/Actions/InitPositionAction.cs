namespace VDA5050MqttMessages.V210.Types.Actions;
public class InitPositionAction : Action
{
    public InitPositionAction(double x, double y, double theta, string mapId, string lastNodeId) : base(
        "initPosition",
        Guid.NewGuid().ToString(),
        "Resets (overrides) the pose of the AGV with the given parameters.",
        BlockingTypes.SOFT)
    {
        ActionParameters.Add("x", x);
        ActionParameters.Add("y", y);
        ActionParameters.Add("theta", theta);
        ActionParameters.Add("mapId", mapId);
        ActionParameters.Add("lastNodeId", lastNodeId);
    }
}
