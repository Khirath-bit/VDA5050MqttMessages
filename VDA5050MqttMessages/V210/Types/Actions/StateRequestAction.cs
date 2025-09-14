namespace VDA5050MqttMessages.V210.Types.Actions;
public class StateRequestAction : Action
{
    public StateRequestAction() : base(
        "stateRequest",
        Guid.NewGuid().ToString(),
        "Requests the AGV to send a new state report.",
        BlockingTypes.NONE)
    { }
}
