namespace VDA5050MqttMessages.V210.Types;
public class Info
{
    /// <summary>
    /// Type or name of the info.
    /// </summary>
    public string InfoType { get; set; } = string.Empty;

    /// <summary>
    /// Array of references (e.g., nodeId, edgeId, orderId, actionId, etc.) to provide more information related to the info.
    /// </summary>
    public List<InfoReference> InfoReferences { get; set; } = [];

    /// <summary>
    /// <see cref="Level"/>
    /// </summary>
    public string InfoLevel { get; set; } = string.Empty;

    public enum Level
    {
        /// <summary>
        /// AGV is ready to start (e.g., maintenance cycle expiration warning).
        /// </summary>
        DEBUG,
        /// <summary>
        /// AGV is not in running condition; user intervention required (e.g., laser scanner is contaminated).
        /// </summary>
        INFO
    }
}
