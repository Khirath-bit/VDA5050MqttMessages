using MQTTnet.Protocol;

namespace VDA5050MqttMessages.V210.Messages.ToVehicle;

/// <summary>
/// In certain cases, it is necessary to send actions to the AGV that need to be performed immediately.<br/>
/// This is done by publishing an <c>instantAction</c> message to the topic <c>instantActions</c>.<br/>
/// <c>instantActions</c> shall not conflict with the content of the AGV's current order (e.g., an instantAction to lower a fork while the order says to raise the fork).<br/>
/// Examples of relevant instant actions include:<br/>
/// • Pause the AGV without changing anything in the current order.<br/>
/// • Resume order after pause.<br/>
/// • Activate a signal (optical, audio, etc.).
/// </summary>
/// <param name="headerId">to identify this message</param>
/// <param name="manufacturer">of this server</param>
/// <param name="serialNumber">of this server</param>
/// <param name="qos">to send the message with. Default is <see cref="MqttQualityOfServiceLevel.AtMostOnce"/> as defined in VDA5050</param>
public class InstantActions(uint headerId, string manufacturer, string serialNumber, string interfaceName, MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtMostOnce)
    : AbstractMessage(headerId, manufacturer, serialNumber, qos, interfaceName), IVDAMqttMessageV210
{
    /// <inheritdoc/>
    public string SubscribePattern => "+/v2/+/+/instantActions";

    /// <inheritdoc/>
    public string PublishTopic => $"{InterfaceName}/v2/{Manufacturer}/{SerialNumber}/instantActions";

    /// <summary>
    /// Array of actions that need to be performed immediately and are not part of the regular order.
    /// </summary>
    public List<Types.Actions.Action> Actions = [];
}
