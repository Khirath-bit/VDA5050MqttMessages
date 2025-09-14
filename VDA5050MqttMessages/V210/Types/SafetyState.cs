namespace VDA5050MqttMessages.V210.Types;
public class SafetyState
{
    /// <summary>
    /// <see cref="Type"></see>
    /// </summary>
    public string EStop { get; set; } = string.Empty;

    /// <summary>
    /// Protective field violation.
    /// </summary>
    public bool FieldViolation { get; set; }

    public enum Type
    {
        AUTOACK,
        MANUAL,
        REMOTE,
        NONE
    }
}
