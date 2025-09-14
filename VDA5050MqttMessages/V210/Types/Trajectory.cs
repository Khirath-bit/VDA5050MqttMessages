namespace VDA5050MqttMessages.V210.Types;

/// <summary>
/// Trajectory of the vehicle in an edge
/// </summary>
/// <param name="knotVector">
/// Range: [1.0 ... float64.max]<br/>
/// Degree of the NURBS curve defining the trajectory.
/// </param>
/// <param name="controlPoints">
/// Range: [0.0 … 1.0]<br/>
/// Array of knot values of the NURBS.<br/>
/// knotVector has a size of number of control points + degree + 1.
/// </param>
/// <param name="degree">
/// Array of controlPoint objects defining the control points of the NURBS, explicitly including the start and end point.
/// </param>
public class Trajectory(List<double> knotVector, List<ControlPoint> controlPoints, double degree = 1)
{
    /// <summary>
    /// Range: [1.0 ... float64.max]<br/>
    /// Degree of the NURBS curve defining the trajectory.
    /// </summary>
    public double Degree { get; set; } = degree;

    /// <summary>
    /// Range: [0.0 … 1.0]<br/>
    /// Array of knot values of the NURBS.<br/>
    /// knotVector has a size of number of control points + degree + 1.
    /// </summary>
    public List<double> KnotVector { get; set; } = knotVector;

    /// <summary>
    /// Array of controlPoint objects defining the control points of the NURBS, explicitly including the start and end point.
    /// </summary>
    public List<ControlPoint> ControlPoints { get; set; } = controlPoints;
}
