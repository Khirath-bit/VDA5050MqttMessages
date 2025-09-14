using MQTTnet.Protocol;
using VDA5050MqttMessages.V210.Types;

namespace VDA5050MqttMessages.V210.Messages.ToMasterControl;

/// <summary>
/// AGV state messages will be published upon the occurrence of relevant events, or at the latest every 30 seconds, via the MQTT broker to master control.<br/>
/// Events that trigger the transmission of the state message include:<br/>
/// • Receiving an order<br/>
/// • Receiving an order update<br/>
/// • Changes in the load status<br/>
/// • Errors or warnings<br/>
/// • Driving over a node<br/>
/// • Switching the operating mode<br/>
/// • Change in the driving field<br/>
/// • Change in the nodeStates, edgeStates, actionStates, or maps<br/>
/// Communication should be minimized. If two events correlate with each other (e.g., receiving a new order usually forces an update of node- and edgeStates, as does driving over a node), it is sensible to trigger a single state update instead of multiple updates.
/// </summary>
public class State(uint headerId, string manufacturer, string serialNumber, string interfaceName, MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtMostOnce)
    : AbstractMessage(headerId, manufacturer, serialNumber, qos, interfaceName), IVDAMqttMessageV210
{
    /// <inheritdoc/>
    public string SubscribePattern => "+/v2/+/+/instantActions";

    /// <inheritdoc/>
    public string PublishTopic => $"{InterfaceName}/v2/{Manufacturer}/{SerialNumber}/instantActions";

    /// <summary>
    /// Array of map objects that are currently stored on the vehicle.
    /// </summary>
    public List<Map> Maps { get; set; } = [];

    /// <summary>
    /// Unique order identification of the current order or the previously finished order.<br/>
    /// The orderId is kept until a new order is received.<br/>
    /// Empty string ("") if no previous orderId is available.
    /// </summary
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// Order update identification to indicate that an order update has been accepted by the AGV.<br/>
    /// "0" if no previous orderUpdateId is available.
    /// </summary>
    public uint OrderUpdateId { get; set; }

    /// <summary>
    /// Unique ID of the zone set that the AGV currently uses for path planning.<br/>
    /// Shall be the same as the one used in the order.<br/>
    /// Optional: If the AGV does not use zones, this field can be omitted.
    /// </summary>
    public string? ZoneSetId { get; set; } = null;

    /// <summary>
    /// Node ID of the last reached node or, if the AGV is currently on a node, the current node (e.g., "node7").<br/>
    /// Empty string ("") if no lastNodeId is available.
    /// </summary>
    public string LastNodeId { get; set; } = string.Empty;

    /// <summary>
    /// Sequence ID of the last reached node or, if the AGV is currently on a node, the Sequence ID of the current node.<br/>
    /// "0" if no lastNodeSequenceId is available.
    /// </summary>
    public uint LastNodeSequenceId { get; set; } = 0;

    /// <summary>
    /// Array of nodeState objects that need to be traversed to fulfill the order (empty array if idle).
    /// </summary>
    public List<NodeState> NodeStates { get; set; } = [];

    /// <summary>
    /// Array of edgeState objects that need to be traversed to fulfill the order (empty array if idle).
    /// </summary>
    public List<EdgeState> EdgeStates { get; set; } = [];

    /// <summary>
    /// Current position of the AGV on the map.<br/>
    /// Optional: can only be omitted for AGVs without the capability to localize themselves, e.g., line-guided AGVs.
    /// </summary>
    public AgvPosition? AgvPosition { get; set; } = null!;

    /// <summary>
    /// The AGV velocity in vehicle coordinates.
    /// </summary>
    public Velocity Velocity { get; set; } = null!;

    /// <summary>
    /// Loads that are currently handled by the AGV.<br/>
    /// Optional: If the AGV cannot determine the load state, this field shall be omitted completely and not reported as an empty array.<br/>
    /// If the AGV can determine the load state but the array is empty, the AGV is considered unloaded.
    /// </summary>
    public List<Load>? Loads { get; set; } = null!;

    /// <summary>
    /// "true": indicates that the AGV is driving and/or rotating. Other movements of the AGV (e.g., lift movements) are not included here.<br/>
    /// "false": indicates that the AGV is neither driving nor rotating.
    /// </summary
    public bool Driving { get; set; }

    /// <summary>
    /// "true": AGV is currently in a paused state, either because of the push of a physical button on the AGV or because of an instantAction.<br/>
    /// The AGV can resume the order.<br/>
    /// "false": The AGV is currently not in a paused state.
    /// </summary>
    public bool Paused { get; set; }

    /// <summary>
    /// "true": AGV is almost at the end of the base and will reduce speed if no new base is transmitted.<br/>
    /// Trigger for master control to send a new base.<br/>
    /// "false": no base update required.
    /// </summary>
    public bool NewBaseRequest { get; set; }

    /// <summary>
    /// Used by line-guided vehicles to indicate the distance driven past the "lastNodeId".<br/>
    /// Distance is in meters.
    /// </summary>
    public double? DistanceSinceLastNode { get; set; } = null;

    /// <summary>
    /// Contains an array of all actions from the current order and all received instantActions since the last order.<br/>
    /// The action states are kept until a new order is received. Action states, except for running instant actions, are removed upon receiving a new order.<br/>
    /// This may include actions from previous nodes that are still in progress.<br/>
    /// When an action is completed, an updated state message is published with <c>actionStatus</c> set to 'FINISHED' and, if applicable, with the corresponding <c>resultDescription</c>.
    /// </summary>
    public List<ActionState> ActionStates { get; set; } = [];

    /// <summary>
    /// Contains an array of all actions from the current order and all received instantActions since the last order.<br/>
    /// The action states are kept until a new order is received. Action states, except for running instant actions, are removed upon receiving a new order.<br/>
    /// This may include actions from previous nodes that are still in progress.<br/>
    /// When an action is completed, an updated state message is published with <c>actionStatus</c> set to 'FINISHED' and, if applicable, with the corresponding <c>resultDescription</c>.
    /// </summary>
    public BatteryState BatteryState { get; set; } = null!;

    /// <summary>
    /// Enum values: 'AUTOMATIC', 'SEMIAUTOMATIC', 'MANUAL', 'SERVICE', 'TEACHIN'.
    /// </summary>
    public string OperatingMode { get; set; } = string.Empty;

    /// <summary>
    /// Array of error objects.<br/>
    /// All active errors of the AGV should be in the array.<br/>
    /// An empty array indicates that the AGV has no active errors.
    /// </summary>
    public List<Error> Errors { get; set; } = [];

    /// <summary>
    /// Array of info objects.<br/>
    /// An empty array indicates that the AGV has no information.<br/>
    /// This should only be used for visualization or debugging – it shall not be used for logic in master control.
    /// </summary>
    public List<Info> Information { get; set; } = [];

    /// <summary>
    /// Contains all safety-related information.
    /// </summary>
    public SafetyState SafetyState { get; set; } = null!;
}
