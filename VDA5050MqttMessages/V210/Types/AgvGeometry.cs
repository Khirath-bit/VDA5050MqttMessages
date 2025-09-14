namespace VDA5050MqttMessages.V210.Types;
public class AgvGeometry
{
    /// <summary>
    /// Wheel definitions
    /// </summary>
    public List<WheelDefinition> WheelDefinitions { get; set; } = [];

    /// <summary>
    /// Envelope curve as an x/y-polygon polygon is assumed as closed and shall be non-self-intersecting.
    /// </summary>
    public List<Envelops2d> Envelopes2d { get; set; } = [];

    /// <summary>
    /// Array of AGV envelope curves in 3D.
    /// </summary>
    public List<Envelops3d> Envelopes3D { get; set; } = [];
}
