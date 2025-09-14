using MQTTnet.Protocol;
using VDA5050MqttMessages.V210.Types;

namespace VDA5050MqttMessages.V210.Messages.ToMasterControl;
public class Vizualization(uint headerId, string manufacturer, string serialNumber, string interfaceName, MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtMostOnce)
    : AbstractMessage(headerId, manufacturer, serialNumber, qos, interfaceName), IVDAMqttMessageV210
{
    /// <summary>
    /// Position of the agv
    /// </summary>
    public AgvPosition Position { get; set; } = null!;

    /// <summary>
    /// Velocity of the agv
    /// </summary>
    public Velocity Velocity { get; set; } = null!;

    /// <inheritdoc/>
    public string SubscribePattern => "+/v2/+/+/vizualization";

    /// <inheritdoc/>
    public string PublishTopic => $"{InterfaceName}/v2/{Manufacturer}/{SerialNumber}/vizualization";
}
