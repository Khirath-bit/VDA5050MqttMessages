namespace VDA5050MqttMessages.V210.Types;

/// <summary>
/// Corrdior to drive in
/// </summary>
/// <param name="leftWidth">
/// Unit: <b>m</b> <br></br>
/// Range: [0.0 ... float64.max]<br/>
/// Defines the width of the corridor in meters to the left relative to the trajectory of the vehicle.
/// </param>
/// <param name="rightWidth">
/// Unit: <b>m</b> <br></br>
/// Range: [0.0 ... float64.max]<br/>
/// Defines the width of the corridor in meters to the right relative to the trajectory of the vehicle. 
/// </param>
/// <param name="corridorRefPoint">
/// Defines whether the boundaries are valid for the kinematic center or the contour of the vehicle.<br/>
/// If not specified, the boundaries are valid for the vehicle's kinematic center.
/// </param>
public class Corridor(double leftWidth, double rightWidth, CorridorRefPointType corridorRefPoint)
{
    /// <summary>
    /// Unit: <b>m</b> <br></br>
    /// Range: [0.0 ... float64.max]<br/>
    /// Defines the width of the corridor in meters to the left relative to the trajectory of the vehicle.
    /// </summary>
    public double LeftWidth { get; set; } = leftWidth;

    /// <summary>
    /// Unit: <b>m</b> <br></br>
    /// Range: [0.0 ... float64.max]<br/>
    /// Defines the width of the corridor in meters to the right relative to the trajectory of the vehicle.
    /// </summary>
    public double RightWidth { get; set; } = rightWidth;

    /// <summary>
    /// Defines whether the boundaries are valid for the kinematic center or the contour of the vehicle.<br/>
    /// If not specified, the boundaries are valid for the vehicle's kinematic center.
    /// </summary>
    public string CorridorRefPoint { get; set; } = corridorRefPoint.ToString();
}
