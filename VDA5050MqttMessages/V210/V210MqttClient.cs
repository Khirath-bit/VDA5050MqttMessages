namespace VDA5050MqttMessages.V210;
public sealed class V210MqttClient
{
    /// <summary>
    /// Contains the next header id to use per topic
    /// </summary>
    private readonly Dictionary<string, uint> _headerIdsPerTopic = [];
}
