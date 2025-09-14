namespace VDA5050MqttMessages.V210.Types;
public class Timing
{
    /// <summary>
    /// [s], Minimum interval sending order messages to the agv
    /// </summary>
    public float MinOrderInterval { get; set; }

    /// <summary>
    /// [s], Minimum interval for sending state messages
    /// </summary>
    public float MinStateInterval { get; set; }

    /// <summary>
    /// [s], Default interval for sending state 
    /// messages, if not defined, the default value
    /// from the main document is used.
    /// </summary>
    public float DefaultStateInterval { get; set; }

    /// <summary>
    /// [s], Default interval for sending messages on vizu topic
    /// </summary>
    public float VisualizationInterval { get; set; }
}
