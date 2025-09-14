namespace VDA5050MqttMessages.V210.Types;
public enum BlockingTypes
{
    /// <summary>
    /// Allows driving and other actions
    /// </summary>
    NONE,
    /// <summary>
    /// Allows other actions but not driving
    /// </summary>
    SOFT,
    /// <summary>
    /// This is the only allowed action at this time
    /// </summary>
    HARD
}