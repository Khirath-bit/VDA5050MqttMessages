namespace VDA5050MqttMessages.V210.Types.Actions;
public class LogReportAction : Action
{
    public LogReportAction(string reason) : base(
        "logReport",
        Guid.NewGuid().ToString(),
        "Requests the AGV to generate and store a log report. ",
        BlockingTypes.NONE)
    { ActionParameters.Add("reason", reason); }
}
