using MQTTnet.Protocol;
using VDA5050MqttMessages.V210.Types;

namespace VDA5050MqttMessages.V210.Messages.ToMasterControl;
public class Factsheet(uint headerId, string manufacturer, string serialNumber, string interfaceName, MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtMostOnce)
    : AbstractMessage(headerId, manufacturer, serialNumber, qos, interfaceName), IVDAMqttMessageV210
{
    /// <inheritdoc/>
    public string SubscribePattern => "+/v2/+/+/factsheet";

    /// <inheritdoc/>
    public string PublishTopic => $"{InterfaceName}/v2/{Manufacturer}/{SerialNumber}/factsheet";

    /// <summary>
    /// These parameters generally specify the class and the capabilities of the AGV.
    /// </summary>
    public TypeSpecification TypeSpecification { get; set; } = null!;

    /// <summary>
    /// These parameters specify the basic physical properties of the AGV.
    /// </summary>
    public PhysicalParameters PhysicalParameters { get; set; } = null!;

    /// <summary>
    /// Limits for length of identifiers, arrays, strings, and similar in MQTT communication. 
    /// </summary>
    public ProtocolLimits ProtocolLimits { get; set; } = null!;

    /// <summary>
    /// Supported features of VDA5050 protocol. 
    /// </summary>
    public ProtocolFeatures ProtocolFeatures { get; set; } = null!;

    /// <summary>
    /// Detailed definition of AGV geometry.
    /// </summary>
    public AgvGeometry AgvGeometry { get; set; } = null!;

    /// <summary>
    /// Abstract specification of load capabilities. 
    /// </summary>
    public LoadSpecification LoadSpecification { get; set; } = null!;

    /// <summary>
    /// Summary of current software and hardware versions on the vehicle and optional networkinformation. 
    /// </summary>
    public VehicleConfig VehicleConfig { get; set; } = null!;
}