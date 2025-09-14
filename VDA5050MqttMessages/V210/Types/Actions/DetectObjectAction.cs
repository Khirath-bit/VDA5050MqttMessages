namespace VDA5050MqttMessages.V210.Types.Actions;

/// <summary>
/// AGV detects object (e.g., load, charging spot, free parking position).. <br></br>
/// Can be used as validation etc
/// </summary>
public class DetectObjectAction : Action
{
    /// <summary>
    /// AGV detects object (e.g., load, charging spot, free parking position).. <br></br>
    /// Can be used as validation etc
    /// </summary>
    public DetectObjectAction(string objectType) : base(
        "detectObject",
        Guid.NewGuid().ToString(),
        "AGV detects object (e.g., load, charging spot, free parking position)..",
        BlockingTypes.NONE)
    {
        ActionParameters.Add("objectType", objectType);
    }
}
