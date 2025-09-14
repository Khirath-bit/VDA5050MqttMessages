using MQTTnet.Protocol;

namespace VDA5050MqttMessages.V210;
public interface IVDAMqttMessageV210
{
    /// <summary>
    /// Gets or sets the qos for this message.
    /// </summary>
    MqttQualityOfServiceLevel QoS { get; set; }

    /// <summary>
    /// Regex pattern used to subscribe to this topic.
    /// </summary>
    string SubscribePattern { get; }

    /// <summary>
    /// Topic string used to publish this message.
    /// </summary>
    string PublishTopic { get; }
}
