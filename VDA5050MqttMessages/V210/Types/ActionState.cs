namespace VDA5050MqttMessages.V210.Types;
public class ActionState
{
    /// <summary>
    /// Unique identifier of the action.
    /// </summary>
    public string ActionId { get; set; } = string.Empty;

    /// <summary>
    /// Type of the action.<br/>
    /// Optional: only for informational or visualization purposes. Master Control (MC) is aware of the action type as dispatched in the order.
    /// </summary>
    public string? ActionType { get; set; } = null;

    /// <summary>
    /// Additional information on the current action.
    /// </summary>
    public string ActionDescription { get; set; } = string.Empty;

    /// <summary>
    /// <see cref="Actions.Action.State"/>
    /// </summary>
    public string ActionStatus { get; set; } = string.Empty;

    /// <summary>
    /// Description of the result, e.g., the result of an RFID reading.<br/>
    /// Errors will be transmitted in <c>errors</c>.
    /// </summary>
    public string ResultDescription { get; set; } = string.Empty;
}
