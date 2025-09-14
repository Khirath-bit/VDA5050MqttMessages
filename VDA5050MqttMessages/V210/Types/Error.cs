namespace VDA5050MqttMessages.V210.Types;
public class Error
{
    /// <summary>
    /// Type or name of the error.
    /// </summary>
    public string ErrorType { get; set; } = string.Empty;

    /// <summary>
    /// Array of references (e.g., nodeId, edgeId, orderId, actionId, etc.) to provide more information related to the error.
    /// </summary>
    public List<ErrorReference> ErrorReferences { get; set; } = [];

    /// <summary>
    /// Verbose description providing details and possible causes of the error.
    /// </summary>
    public string ErrorDescription { get; set; } = string.Empty;

    /// <summary>
    /// Hint on how to approach or solve the reported error.
    /// </summary>
    public string ErrorHint {  get; set; } = string.Empty;

    /// <summary>
    /// AGV is not in running condition; user intervention required (e.g., laser scanner is contaminated).
    /// </summary>
    public string ErrorLevel { get; set; } = string.Empty;

    public enum Level
    {
        /// <summary>
        /// AGV is ready to start (e.g., maintenance cycle expiration warning).
        /// </summary>
        WARNING,
        /// <summary>
        /// AGV is not in running condition; user intervention required (e.g., laser scanner is contaminated).
        /// </summary>
        FATAL
    }
}
