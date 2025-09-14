using static VDA5050MqttMessages.V210.Types.Map;

namespace VDA5050MqttMessages.V210.Types;

/// <summary>
/// Creates a new map object
/// </summary>
/// <param name="mapId">ID of the map describing a defined area of the vehicle's workspace.</param>
/// <param name="mapVersion">Version of the map.</param>
/// <param name="mapDescription">Additional information on the map. </param>
/// <param name="mapStatus"><see cref="Status"/></param>
public class Map(string mapId, string mapVersion, string mapDescription, Status mapStatus)
{
    public enum Status
    {
        /// <summary>
        /// Indicates this map is currently active/used on the AGV.<br/>
        /// At most one map with the same <c>mapId</c> can have its status set to 'ENABLED'.
        /// </summary>
        ENABLED,
        /// <summary>
        /// Indicates this map version is currently not enabled on the AGV and thus could be enabled or deleted by request.
        /// </summary>
        DISABLED
    }

    /// <summary>
    /// ID of the map describing a defined area of the vehicle's workspace.
    /// </summary>
    public string MapId { get; set; } = mapId;

    /// <summary>
    /// Version of the map.
    /// </summary>
    public string MapVersion { get; set; } = mapVersion;

    /// <summary>
    /// Additional information on the map. 
    /// </summary>
    public string MapDescription { get; set; } = mapDescription;

    /// <summary>
    /// <see cref="Status"/>
    /// </summary>
    public string MapStatus { get; set; } = mapStatus.ToString();
}
