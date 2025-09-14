namespace VDA5050MqttMessages.V210.Types;
public class EdgeState
{
    /// <summary>
    /// Unique edge identification.
    /// </summary>
    public string EdgeId { get; set; } = string.Empty;

    /// <summary>
    /// Sequence id to discern multiple edges with the same <see cref="NodeId"/>
    /// </summary>
    public uint SequenceId { get; set; }

    /// <summary>
    /// Additional information on the node. 
    /// </summary>
    public string EdgeDescription { get; set; } = string.Empty;

    /// <summary>
    /// "true" indicates that the edge is part of the base.<br/>
    /// "false" indicates that the edge is part of the horizon.
    /// </summary>
    public bool Released { get; set; }

    /// <summary>
    /// Trajectory of the vehicle in this edge
    /// </summary>
    public Trajectory Trajectory { get; set; } = null!;
}
