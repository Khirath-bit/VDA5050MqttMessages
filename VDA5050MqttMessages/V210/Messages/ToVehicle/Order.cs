using MQTTnet.Protocol;
using VDA5050MqttMessages.V210.Types;

namespace VDA5050MqttMessages.V210.Messages.ToVehicle;

/// <summary>
/// Creates a new instance of <see cref="Order"/> <br></br>
/// A message sent by the master control
/// </summary>
/// <param name="headerId">to identify this message</param>
/// <param name="manufacturer">of this server</param>
/// <param name="serialNumber">of this server</param>
/// <param name="qos">to send the message with. Default is <see cref="MqttQualityOfServiceLevel.AtMostOnce"/> as defined in VDA5050</param>
public class Order(uint headerId, string manufacturer, string serialNumber, string interfaceName, MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtMostOnce) 
    : AbstractMessage(headerId, manufacturer, serialNumber, qos, interfaceName), IVDAMqttMessageV210
{
    /// <inheritdoc/>
    public string SubscribePattern => "+/v2/+/+/order";

    /// <inheritdoc/>
    public string PublishTopic => $"{InterfaceName}/v2/{Manufacturer}/{SerialNumber}/order";

    /// <summary>
    /// Order identification. <br></br>
    /// This is to be used to identify multiple order <br></br>
    /// messages that belong to the same order.
    /// </summary>
    public string OrderId { get; set; } = string.Empty;

    /// <summary>
    /// Order update identification. <br></br>
    /// Is unique per orderId. <br></br>
    /// If an order update is rejected, this field is to <br></br>
    /// be passed in the rejection message.
    /// </summary>
    public uint OrderUpdateId { get; set; }

    /// <summary>
    /// Unique identifier of the zone set used by the AGV for navigation 
    /// or assigned by master control for planning. <br></br>
    /// This is optional.
    /// </summary>
    public string ZoneSetId { get; set; } = string.Empty;

    /// <summary>
    /// For newtonsoft json to ignore zone set id if empty because defined in the vda5050
    /// </summary>
    /// <returns>True = ZoneSetId has been set</returns>
    public bool ShouldSerializeZoneSetId()
     => ZoneSetId != string.Empty;

    /// <summary>
    /// Nodes to be traversed for fulfilling the order. On node is enough for a valid order. <br></br>
    /// Leave edges empty in that case
    /// </summary>
    public List<Node> Nodes { get; set; } = [];

    /// <summary>
    /// Array of edge objects to be traversed for fulfilling the order.<br/>
    /// One node is enough for a valid order. Leave the edge array empty in that case.
    /// </summary>
    public List<Edge> Edges { get; set; } = [];
}
