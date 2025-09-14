namespace VDA5050MqttMessages.V210.Types;
public class Load
{
    /// <summary>
    /// Unique identification of the load (e.g., barcode or RFID).<br/>
    /// Empty field if the AGV can identify the load but hasn't identified it yet.<br/>
    /// Optional if the AGV cannot identify the load.
    /// </summary>
    public string? LoadId { get; set; } = null;

    /// <summary>
    /// Type of load. 
    /// </summary>
    public string LoadType { get; set; } = string.Empty;

    /// <summary>
    /// Indicates which load handling/carrying unit of the AGV is used, e.g., in case the AGV has multiple spots/positions to carry loads.<br/>
    /// For example: "front", "back", "positionC1", etc.<br/>
    /// Optional for vehicles with only one load position.
    /// </summary>
    public string? LoadPosition { get; set; } = null;

    /// <summary>
    /// Point of reference for the location of the bounding box.<br/>
    /// The point of reference is always the center of the bounding box's bottom surface (at height = 0) and is described in coordinates of the AGV's coordinate system.
    /// </summary>
    public BoundingBoxReference BoundingBoxReference { get; set; } = null!;

    /// <summary>
    /// Dimensions of the load's bounding in meters.
    /// </summary>
    public LoadDimensions LoadDimensions { get; set; } = null!;

    /// <summary>
    /// Range: [0.0 ... float64.max]<br/>
    /// Absolute weight of the load measured in kg.
    /// </summary>
    public double Weight { get; set; }
}
