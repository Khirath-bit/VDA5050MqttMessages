namespace VDA5050MqttMessages.V210.Types;

/// <summary>
/// Point of reference for the location of the bounding box.<br/>
/// The point of reference is always the center of the bounding box's bottom surface (at height = 0) and is described in coordinates of the AGV's coordinate system.
/// </summary>
public class BoundingBoxReference
{
    /// <summary>
    /// X-coordinate of the point of reference
    /// </summary>
    public double X { get; set; }

    /// <summary>
    /// X-coordinate of the point of reference
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Z-coordinate of the point of reference
    /// </summary>
    public double Z { get; set; }

    /// <summary>
    /// Orientation of the loads bounding box. <br></br>
    /// Important for truggers, trains, etc.
    /// </summary>
    public double Theta { get; set; }
}
