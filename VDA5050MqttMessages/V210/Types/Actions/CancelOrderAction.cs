namespace VDA5050MqttMessages.V210.Types.Actions;

/// <summary>
/// The AGV stops as soon as possible.<br/>
/// This could be immediately or at the next node.<br/>
/// Then the order is deleted and all actions are canceled.
/// </summary>
public class CancelOrderAction : Action
{
    /// <summary>
    /// The AGV stops as soon as possible.<br/>
    /// This could be immediately or at the next node.<br/>
    /// Then the order is deleted and all actions are canceled.
    /// </summary>
    public CancelOrderAction() : base(
        "cancelOrder",
        Guid.NewGuid().ToString(),
        "AGV stops as soon as possible. This could be immediately or on the next node. Then the order is deleted. All actions are canceled.",
        BlockingTypes.NONE)
    { }
}
