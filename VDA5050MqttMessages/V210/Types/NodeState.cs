namespace VDA5050MqttMessages.V210.Types;
public class NodeState
{
    /// <summary>
    /// Unique node identification.
    /// </summary>
    public string NodeId { get; set; } = string.Empty;

    /// <summary>
    /// Sequence id to discern multiple nodes with the same <see cref="NodeId"/>
    /// </summary>
    public uint SequenceId { get; set; }

    /// <summary>
    /// Additional information on the node. 
    /// </summary>
    public string NodeDescription { get; set; } = string.Empty;

    /// <summary>
    /// "true" indicates that the node is part of the base.<br/>
    /// "false" indicates that the node is part of the horizon.
    /// </summary>
    public bool Released { get; set; }

    /// <summary>
    /// Node position
    /// </summary>
    public NodePosition? NodePosition { get; set; } = null!;
}
