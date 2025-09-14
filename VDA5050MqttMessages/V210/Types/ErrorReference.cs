namespace VDA5050MqttMessages.V210.Types;
public class ErrorReference
{
    /// <summary>
    /// Specifies the type of reference used (e.g., "nodeId", "edgeId", "orderId", "actionId", etc.).
    /// </summary>
    public string ReferenceKey { get; set; } = string.Empty;

    /// <summary>
    /// The value that belongs to the reference key. For example, the ID of the node where the error occurred.
    /// </summary>
    public string ReferenceValue { get; set; } = string.Empty;
}
