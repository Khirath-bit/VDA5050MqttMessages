namespace VDA5050MqttMessages.V210.Types.Actions;

/// <summary>
/// The AGV has to wait for a trigger on the vehicle (e.g., button press, manual loading).<br/>
/// Master control is responsible for handling the timeout and must cancel the order if necessary.
/// </summary>
public class WaitForTriggerAction : Action
{
    /// <summary>
    /// The AGV has to wait for a trigger on the vehicle (e.g., button press, manual loading).<br/>
    /// Master control is responsible for handling the timeout and must cancel the order if necessary.
    /// </summary>
    public WaitForTriggerAction(string triggerType) : base(
        "waitForTrigger",
        Guid.NewGuid().ToString(),
        "Trigger the removal of a map from the vehicle memory.",
        BlockingTypes.HARD)
    {
        ActionParameters.Add("triggerType", triggerType);
    }
}
