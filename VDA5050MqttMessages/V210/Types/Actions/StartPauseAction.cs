namespace VDA5050MqttMessages.V210.Types.Actions;
public class StartPauseAction :
    Action
{
    public StartPauseAction() : base(
        "startPause",
        Guid.NewGuid().ToString(),
        "Activates the pause mode. No more AGV driving movements - reaching the next node is not neccessary. Actions can continue. Order is resumable.",
        BlockingTypes.SOFT)
    { }
}
