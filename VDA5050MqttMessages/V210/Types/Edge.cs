namespace VDA5050MqttMessages.V210.Types;
/// <summary>
/// Represents an edge in the AGV map.
/// <para><b>edgeId:</b> Unique edge id.</para>
/// <para><b>sequenceId:</b> Number to track the sequence of nodes and edges in an order and to simplify order updates. The variable sequenceId runs across all nodes and edges of the same order and is reset when a new orderId is issued.</para>
/// <para><b>edgeDescription:</b> Additional edge information.</para>
/// <para><b>released:</b> "true" indicates that the edge is part of the base. "false" indicates that the edge is part of the horizon.</para>
/// <para><b>startNodeId:</b> NodeId of the start node of this edge.</para>
/// <para><b>endNodeId:</b> NodeId of the end node of this edge.</para>
/// <para><b>maxSpeed:</b> Permitted maximum speed on the edge. Speed is defined by the fastest measurement of the vehicle.</para>
/// <para><b>maxHeight:</b> Permitted maximum height of the vehicle, including the load, on the edge.</para>
/// <para><b>minHeight:</b> Permitted minimal height of the vehicle to pass this edge.</para>
/// <para><b>orientation:</b> Orientation of the AGV on the edge. The value orientationType defines if it has to be interpreted relative to the global project-specific map coordinate system or tangential to the edge. In case of tangential interpretation, 0.0 denotes driving forwards and PI denotes driving backwards. Example: orientation Pi/2 rad will lead to a rotation of 90 degrees. If the AGV starts in a different orientation, rotate the vehicle on the edge to the desired orientation if rotationAllowed is "true". If rotationAllowed is "false", rotate before entering the edge. If that is not possible, reject the order. If no trajectory is defined, apply the rotation to the direct path between the two connecting nodes of the edge. If a trajectory is defined for the edge, apply the orientation to the trajectory.</para>
/// <para><b>orientationType:</b> Describes the orientation type. Default is, as specified in the norm: OrientationType.TANGENTIAL.</para>
/// <para><b>direction:</b> Sets direction at junctions for line-guided or wire-guided vehicles, to be defined initially (vehicle-individual). Examples: "left", "right", "straight".</para>
/// <para><b>rotationAllowed:</b> "true": rotation is allowed on the edge. "false": rotation is not allowed on the edge. Optional: True by default.</para>
/// <para><b>maxRotationSpeed:</b> Maximum rotation speed. Optional: no limit if not set.</para>
/// <para><b>trajectory:</b> Trajectory JSON object for this edge as NURBS. Defines the path on which the AGV should move between the start node and the end node of the edge. Optional: can be omitted if the AGV cannot process trajectories or if the AGV plans its own trajectory.</para>
/// <para><b>length:</b> Length of the path from the start node to the end node. Optional: this value is used by line-guided AGVs to decrease their speed before reaching a stop position.</para>
/// <para><b>actions:</b> Array of actions to be executed on the edge. Empty array if no actions are required. An action triggered by an edge will only be active while the AGV is traversing the edge which triggered the action. When the AGV leaves the edge, the action will stop and the state before entering the edge will be restored.</para>
/// <para><b>corridor:</b> Definition of boundaries in which a vehicle can deviate from its trajectory, e.g., to avoid obstacles.</para>
/// </summary>
public class Edge(
    string edgeId,
    uint sequenceId,
    string edgeDescription,
    bool released,
    string startNodeId,
    string endNodeId,
    double maxSpeed,
    double maxHeight,
    double minHeight,
    double orientation,
    string direction,
    Trajectory trajectory,
    List<Actions.Action> actions,
    Corridor corridor,
    bool rotationAllowed = true,
    double? maxRotationSpeed = null,
    double? length = null,
    OrientationType orientationType = OrientationType.TANGENTIAL
)
{
    /// <summary>
    /// Unique edge id
    /// </summary>
    public string EdgeId { get; set; } = edgeId;

    /// <summary>
    /// Number to track the sequence of nodes and edges in an order and to simplify order updates.<br/>
    /// The variable sequenceId runs across all nodes and edges of the same order and is reset when a new orderId is issued.
    /// </summary>
    public uint SequenceId { get; set; } = sequenceId;

    /// <summary>
    /// Additional edge information
    /// </summary>
    public string EdgeDescription { get; set; } = edgeDescription;

    /// <summary>
    /// "true" indicates that the edge is part of the base.<br/>
    /// "false" indicates that the edge is part of the horizon.
    /// </summary>
    public bool Released { get; set; } = released;

    /// <summary>
    /// NodeId of the start node of this edge
    /// </summary>
    public string StartNodeId { get; set; } = startNodeId;

    /// <summary>
    /// NodeId of the end node of this edge
    /// </summary>
    public string EndNodeId { get; set; } = endNodeId;

    /// <summary>
    /// Unit: <b>m/s</b> <br></br>
    /// Permitted maximum speed on the edge.<br/>
    /// Speed is defined by the fastest measurement of the vehicle.
    /// </summary>
    public double MaxSpeed { get; set; } = maxSpeed;

    /// <summary>
    /// Unit: <b>m</b> <br></br>
    /// Permitted maximum height of the vehicle, including the load, on the edge.
    /// </summary>
    public double MaxHeight { get; set; } = maxHeight;

    /// <summary>
    /// Unit: <b>m</b> <br></br>
    /// Permitted minimal height of the vehicle to pass this edge.
    /// </summary>
    public double MinHeight { get; set; } = minHeight;

    /// <summary>
    /// Orientation of the AGV on the edge.<br/>
    /// The value orientationType defines if it has to be interpreted relative to the global project-specific map coordinate system or tangential to the edge.<br/>
    /// In case of tangential interpretation, 0.0 denotes driving forwards and PI denotes driving backwards.<br/>
    /// Example: orientation Pi/2 rad will lead to a rotation of 90 degrees.<br/>
    /// If the AGV starts in a different orientation, rotate the vehicle on the edge to the desired orientation if rotationAllowed is "true".<br/>
    /// If rotationAllowed is "false", rotate before entering the edge. If that is not possible, reject the order.<br/>
    /// If no trajectory is defined, apply the rotation to the direct path between the two connecting nodes of the edge.<br/>
    /// If a trajectory is defined for the edge, apply the orientation to the trajectory.
    /// </summary>
    public double Orientation { get; set; } = orientation;

    /// <summary>
    /// Describes the orientation type. <br></br>
    /// Default is, as specified in the norm: <see cref="OrientationType.TANGENTIAL"/>
    /// </summary>
    public string OrientationType { get; set; } = orientationType.ToString();

    /// <summary>
    /// Sets direction at junctions for line-guided or wire-guided vehicles, to be defined initially (vehicle-individual).<br/>
    /// Examples: "left", "right", "straight".
    /// </summary>
    public string Direction { get; set; } = direction;

    /// <summary>
    /// "true": rotation is allowed on the edge.<br/>
    /// "false": rotation is not allowed on the edge.<br/>
    /// Optional: True by default.
    /// </summary>
    public bool RotationAllowed { get; set; } = rotationAllowed;

    /// <summary>
    /// Unit: <b>RAD</b> <br></br>
    /// Maximum rotation speed.<br/>
    /// Optional: no limit if not set.
    /// </summary>
    public double? MaxRotationSpeed { get; set; } = maxRotationSpeed;

    /// <summary>
    /// For newtonsoft json to ignore MaxRotationSpeed if null because defined in the vda5050
    /// </summary>
    /// <returns>True = ZoneSetId has been set</returns>
    public bool ShouldSerializeMaxRotationSpeed()
     => MaxRotationSpeed != null;

    /// <summary>
    /// Trajectory JSON object for this edge as NURBS.<br/>
    /// Defines the path on which the AGV should move between the start node and the end node of the edge.<br/>
    /// Optional: can be omitted if the AGV cannot process trajectories or if the AGV plans its own trajectory.
    /// </summary>
    public Trajectory Trajectory { get; set; } = trajectory;

    /// <summary>
    /// Unit: <b>m</b> <br></br>
    /// Length of the path from the start node to the end node.<br/>
    /// Optional: this value is used by line-guided AGVs to decrease their speed before reaching a stop position.
    /// </summary>
    public double? Length { get; set; } = length;

    /// <summary>
    /// For newtonsoft json to ignore Length if null because defined in the vda5050
    /// </summary>
    /// <returns>True = ZoneSetId has been set</returns>
    public bool ShouldSerializeLength()
     => Length != null;

    /// <summary>
    /// Array of actions to be executed on the edge.<br/>
    /// Empty array if no actions are required.<br/>
    /// An action triggered by an edge will only be active while the AGV is traversing the edge which triggered the action.<br/>
    /// When the AGV leaves the edge, the action will stop and the state before entering the edge will be restored.
    /// </summary>
    public List<Actions.Action> Actions { get; set; } = actions;

    /// <summary>
    /// Definition of boundaries in which a vehicle can deviate from its trajectory, e.g., to avoid obstacles.
    /// </summary>
    public Corridor Corridor { get; set; } = corridor;
}
