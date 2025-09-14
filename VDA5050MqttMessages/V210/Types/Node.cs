namespace VDA5050MqttMessages.V210.Types;
public class Node
{
    /// <summary>
    /// Unique node id
    /// </summary>
    public string NodeId { get; set; } = string.Empty;

    /// <summary>
    /// Number to track the sequence of nodes and edges in an order and to simplify order updates.<br/>
    /// The main purpose is to distinguish between a node, which is passed more than once within one orderId.<br/>
    /// The variable sequenceId runs across all nodes and edges of the same order and is reset when a new orderId is issued.
    /// </summary>
    public uint SequenceId { get; set; }

    /// <summary>
    /// Additional information on the node
    /// </summary>
    public string NodeDescription { get; set; } = string.Empty;

    /// <summary>
    /// "true" indicates that the node is part of the base.<br/>
    /// "false" indicates that the node is part of the horizon.
    /// </summary>
    public bool Released { get; set; }

    /// <summary>
    /// Node position.<br/>
    /// Optional for vehicle types that do not require the node position (e.g., line-guided vehicles).
    /// </summary>
    public NodePosition NodePosition { get; set; } = null!;

    /// <summary>
    /// Gets or sets the list of actions to be executed on this node. Can be empty.
    /// </summary>
    public List<Actions.Action> Actions { get; set; } = [];
}
