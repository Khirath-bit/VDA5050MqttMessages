namespace VDA5050MqttMessages.V210.Types;
public enum NavigationType
{
    /// <summary>
    /// No path planning, vehicle follows installed paths
    /// </summary>
    PHYSICAL_LINE_GUIDED,
    /// <summary>
    /// Agv goes fixed virtual paths
    /// </summary>
    VIRTUAL_LINE_GUIDED,
    /// <summary>
    /// Agv plans its path autonomously
    /// </summary>
    AUTONOMOUS,
}
