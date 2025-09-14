namespace VDA5050MqttMessages.V210.Types.Actions;
internal class FactsheetRequestAction : Action
{
    /// <summary>
    /// Requests the AGV to send a factsheet 
    /// </summary>
    public FactsheetRequestAction() : base(
        "factsheetRequest",
        Guid.NewGuid().ToString(),
        "Requests the AGV to send a factsheet ",
        BlockingTypes.NONE)
    { }
}
