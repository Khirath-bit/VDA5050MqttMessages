namespace VDA5050MqttMessages.V210.Types;

/// <summary>
/// Position of a node
/// </summary>
/// <param name="x">
/// Unit: <b>m</b> <br/>
/// X-position on the map in reference to the map coordinate system.<br/>
/// Precision is up to the specific implementation.
/// </param>
/// <param name="y">
/// Unit: <b>m</b> <br/>
/// Y-position on the map in reference to the map coordinate system.<br/>
/// Precision is up to the specific implementation.
/// </param>
/// <param name="theta">
/// Unit: <b>RAD</b> <br/>
/// Range: [-Pi ... Pi]<br/>
/// Absolute orientation of the AGV on the node.<br/>
/// Optional: vehicle can plan the path by itself.<br/>
/// If defined, the AGV has to assume the theta angle on this node. If previous edge disallows rotation, the AGV shall rotate on the node.<br/>
/// If following edge has a differing orientation defined but disallows rotation, the AGV is to rotate on the node to the edge's desired rotation before entering the edge.
/// </param>
/// <param name="allowedDeviationXY">
/// Unit: <b>m</b> <br/>
/// Indicates how precisely an AGV shall match the position of a node for it to be considered traversed.<br/>
/// If = 0.0: no deviation is allowed (no deviation means within the normal tolerance of the AGV manufacturer).<br/>
/// If > 0.0: allowed deviation radius in meters.<br/>
/// If the AGV passes a node within the deviation radius, the node can be considered traversed.
/// </param>
/// <param name="allowedDeviationTheta">
/// Unit: <b>RAD</b> <br/>
/// Range: [0.0 … Pi]<br/>
/// Indicates how precise the orientation defined in theta has to be met on the node by the AGV.<br/>
/// The lowest acceptable angle is theta - allowedDeviationTheta and the highest acceptable angle is theta + allowedDeviationTheta.
/// </param>
/// <param name="mapId">
/// Unique identification of the map on which the position is referenced.<br/>
/// Each map has the same project-specific global origin of coordinates.<br/>
/// When an AGV uses an elevator, e.g., leading from a departure floor to a target floor, it will disappear off the map of the departure floor and spawn in the related lift node on the map of the target floor.
/// </param>
/// <param name="mapDescription">Gets or sets additional info to the map</param>
public class NodePosition(
    double x,
    double y,
    double theta,
    double allowedDeviationXY,
    double allowedDeviationTheta,
    string mapId,
    string mapDescription
)
{
    /// <summary>
    /// Unit: <b>m</b> <br/>
    /// X-position on the map in reference to the map coordinate system.<br/>
    /// Precision is up to the specific implementation.
    /// </summary>
    public double X { get; set; } = x;

    /// <summary>
    /// Unit: <b>m</b> <br/>
    /// Y-position on the map in reference to the map coordinate system.<br/>
    /// Precision is up to the specific implementation.
    /// </summary>
    public double Y { get; set; } = y;

    /// <summary>
    /// Unit: <b>RAD</b> <br/>
    /// Range: [-Pi ... Pi]<br/>
    /// Absolute orientation of the AGV on the node.<br/>
    /// Optional: vehicle can plan the path by itself.<br/>
    /// If defined, the AGV has to assume the theta angle on this node. If previous edge disallows rotation, the AGV shall rotate on the node.<br/>
    /// If following edge has a differing orientation defined but disallows rotation, the AGV is to rotate on the node to the edge's desired rotation before entering the edge.
    /// </summary>
    public double Theta { get; set; } = theta;

    /// <summary>
    /// Unit: <b>m</b> <br/>
    /// Indicates how precisely an AGV shall match the position of a node for it to be considered traversed.<br/>
    /// If = 0.0: no deviation is allowed (no deviation means within the normal tolerance of the AGV manufacturer).<br/>
    /// If > 0.0: allowed deviation radius in meters.<br/>
    /// If the AGV passes a node within the deviation radius, the node can be considered traversed.
    /// </summary>
    public double AllowedDeviationXY { get; set; } = allowedDeviationXY;

    /// <summary>
    /// Unit: <b>RAD</b> <br/>
    /// Range: [0.0 … Pi]<br/>
    /// Indicates how precise the orientation defined in theta has to be met on the node by the AGV.<br/>
    /// The lowest acceptable angle is theta - allowedDeviationTheta and the highest acceptable angle is theta + allowedDeviationTheta.
    /// </summary>
    public double AllowedDeviationTheta { get; set; } = allowedDeviationTheta;

    /// <summary>
    /// Unique identification of the map on which the position is referenced.<br/>
    /// Each map has the same project-specific global origin of coordinates.<br/>
    /// When an AGV uses an elevator, e.g., leading from a departure floor to a target floor, it will disappear off the map of the departure floor and spawn in the related lift node on the map of the target floor.
    /// </summary>
    public string MapId { get; set; } = mapId;

    /// <summary>
    /// Gets or sets additional info to the map
    /// </summary>
    public string MapDescription { get; set; } = mapDescription;
}
