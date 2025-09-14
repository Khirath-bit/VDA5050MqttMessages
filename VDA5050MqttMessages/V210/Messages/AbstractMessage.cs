using MQTTnet.Protocol;

namespace VDA5050MqttMessages.V210.Messages;
public class AbstractMessage(uint headerId, string manufacturer, 
    string serialNumber, MqttQualityOfServiceLevel qos, string interfaceName)
{
    /// <summary>
    /// Gets or sets the header id for this message. <br></br>
    /// This is a continuesly inrementing number for each topic for the agvs to check if duplicates arrive or messages get losts
    /// </summary>
    public uint HeaderId { get; set; } = headerId;

    /// <summary>
    /// Gets the version of this implementation
    /// </summary>
    public string Version { get; } = "2.1.0";

    /// <summary>
    /// Gets or sets the time stamp of this message, already defaulted to <see cref="DateTime.UtcNow"></see>
    /// <br></br>
    /// Requires this format: <b>yyyy-MMdd'T'HH:mm:ss.ff'Z'</b>
    /// </summary>
    public string TimeStampUtc { get; set; } = DateTime.UtcNow.ToString("yyyy-MMdd'T'HH:mm:ss.ff'Z'");

    /// <summary>
    /// Gets or sets the manufacturer <br></br>
    /// Allowed characters: A-Z, a-z, 0-9, _, ., :, -
    /// </summary>
    public string Manufacturer { get; set; } = manufacturer;

    /// <summary>
    /// Gets or sets the serial number of the agv or server
    /// </summary>
    public string SerialNumber { get; set; } = serialNumber;

    /// <summary>
    /// Gets or sets the qos for this message. <br></br>
    /// </summary>
    public MqttQualityOfServiceLevel QoS { get; set; } = qos;

    /// <summary>
    /// Gets or sets the interface name used for the topic
    /// </summary>
    public string InterfaceName { get; set; } = interfaceName;
}
