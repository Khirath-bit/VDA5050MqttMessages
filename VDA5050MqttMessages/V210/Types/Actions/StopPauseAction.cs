namespace VDA5050MqttMessages.V210.Types.Actions;
public class StopPauseAction : Action
{
    public StopPauseAction() : base(
        "stopPause",
        Guid.NewGuid().ToString(),
        "Deactivates the pause mode. Movement and all other actions will be resumed (if any). ",
        BlockingTypes.SOFT)
    { }
}
