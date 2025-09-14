namespace VDA5050MqttMessages.V210.Types;
public class VehicleConfig
{
    /// <summary>
    /// Array of key-value pair objects containing software and hardware information. 
    /// </summary>
    public List<VersionInfo> Versions { get; set; } = [];

    /// <summary>
    /// Information about the vehicle's network connection. The listed information shall not be updated while the vehicle is operating. 
    /// </summary>
    public NetworkInfo Network { get; set; } = null!;

    public class NetworkInfo
    {
        /// <summary>
        /// Array of Domain Name Servers (DNS) used by the vehicle. 
        /// </summary>
        public List<string> DnsServers { get; set; } = [];

        /// <summary>
        /// Array of Network Time Protocol (NTP) servers used by the vehicle.
        /// </summary>
        public List<string> NtpServers { get; set; } = [];

        /// <summary>
        /// A priori assigned IP address used to communicate with the MQTT broker.<br/>
        /// Note that this IP address should not be modified/changed during operations.
        /// </summary>
        public string LocalIpAddress { get; set; } = string.Empty;

        /// <summary>
        /// The subnet mask used in the network configuration corresponding to the local IP address.
        /// </summary>
        public string Netmask {  get; set; } = string.Empty;

        /// <summary>
        /// The default gateway used by the vehicle, corresponding to the local IP address. 
        /// </summary>
        public string DefaultGateway {  get; set; } = string.Empty;
    }

    public class VersionInfo
    {
        /// <summary>
        /// Key of the software/hardware version used. (e.g., softwareVersion) 
        /// </summary>
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// The version corresponding to the key. (e.g., v1.12.4-beta) 
        /// </summary>
        public string Value { get; set; } = string.Empty;
    }
}
