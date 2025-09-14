namespace VDA5050MqttMessages.V210.Types;

/// <summary>
/// Control point for a nurb
/// </summary>
/// <param name="x">X-coordinate described in the world coordinate system.</param>
/// <param name="y">Y-coordinate described in the world coordinate system.</param>
/// <param name="weight">
/// Range: [0.0 ... float64.max]<br/>
/// The weight of the control point on the curve.<br/>
/// When not defined, the default will be 1.0.
/// </param>
public class ControlPoint(double x, double y, double weight = 1)
{
    /// <summary>
    /// X-coordinate described in the world coordinate system.
    /// </summary>
    public double X { get; set; } = x;

    /// <summary>
    /// Y-coordinate described in the world coordinate system.
    /// </summary>
    public double Y { get; set; } = y;

    /// <summary>
    /// Range: [0.0 ... float64.max]<br/>
    /// The weight of the control point on the curve.<br/>
    /// When not defined, the default will be 1.0.
    /// </summary>
    public double Weight { get; set; } = weight;
}
