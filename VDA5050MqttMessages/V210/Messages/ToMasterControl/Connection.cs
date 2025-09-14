using MQTTnet.Protocol;

namespace VDA5050MqttMessages.V210.Messages.ToMasterControl;
public class Connection(uint headerId, string manufacturer, string serialNumber, string interfaceName, MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtMostOnce)
    : AbstractMessage(headerId, manufacturer, serialNumber, qos, interfaceName), IVDAMqttMessageV210
{
    /// <inheritdoc/>
    public string SubscribePattern => "+/v2/+/+/connection";

    /// <inheritdoc/>
    public string PublishTopic => $"{InterfaceName}/v2/{Manufacturer}/{SerialNumber}/connection";

    /// <summary>
    /// <see cref="State"/>
    /// </summary>
    public State ConnectionState {  get; set; }

    public enum State
    {
        /// <summary>
        /// connection between AGV and broker is active. 
        /// </summary>
        ONLINE,
        /// <summary>
        /// connection between AGV and broker has gone 
        /// offline in a coordinated way. 
        /// </summary>
        OFFLINE,
        /// <summary>
        /// The connection between AGV and 
        /// broker has unexpectedly ended. 
        /// </summary>
        CONNECTIONBROKEN
    }
}
