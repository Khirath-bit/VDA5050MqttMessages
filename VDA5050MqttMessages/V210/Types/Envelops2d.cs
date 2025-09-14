namespace VDA5050MqttMessages.V210.Types;
public class Envelops2d
{
    /// <summary>
    /// Name of the envelope curve set.
    /// </summary>
    public string Set { get; set; } = string.Empty;

    /// <summary>
    /// Envelope curve as an x/y polygon polygon is assumed as closed and shall be non-self-intersecting
    /// </summary>
    public List<PolygonPoint> PolygonPoints { get; set; } = [];

    /// <summary>
    /// Free-form text: description of envelope curve set.
    /// </summary>
    public string Description { get; set; } = string.Empty;

    public class PolygonPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
