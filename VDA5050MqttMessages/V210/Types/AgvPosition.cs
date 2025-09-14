namespace VDA5050MqttMessages.V210.Types;

/// <summary>
/// Defines the position on a map in world coordinates. Each floor has its own map.
/// </summary>

public class AgvPosition
{
    /// <summary>
    /// "true": position is initialized.<br/>
    /// "false": position is not initialized.
    /// </summary>
    public bool PositionInitialized { get; set; }

    /// <summary>
    /// Range: [0.0 ... 1.0]<br/>
    /// Describes the quality of the localization and can be used, e.g., by SLAM AGVs to indicate how accurate the current position information is.<br/>
    /// 0.0: position unknown<br/>
    /// 1.0: position known<br/>
    /// Optional for vehicles that cannot estimate their localization score.<br/>
    /// Only for logging and visualization purposes.
    /// </summary>
    public double LocalizationScore { get; set; }

    /// <summary>
    /// Value for the deviation range of the position in meters.<br/>
    /// Optional for vehicles that cannot estimate their deviation, e.g., grid-based localization.<br/>
    /// Only for logging and visualization purposes.
    /// </summary>
    public double? DevationRange { get; set; } = null;
    
    /// <summary>
    /// Unit: <b>m</b> <br/>
    /// X-position on the map in reference to the map coordinate system.<br/>
    /// Precision is up to the specific implementation.
    /// </summary>
    public double X {  get; set; }

    /// <summary>
    /// Unit: <b>m</b> <br/>
    /// Y-position on the map in reference to the map coordinate system.<br/>
    /// Precision is up to the specific implementation.
    /// </summary>
    public double Y { get; set; }

    /// <summary>
    /// Unit: <b>RAD</b> <br></br>
    /// Range: [-Pi ... Pi] 
    /// Orientation of the AGV.
    /// </summary>
    public double Theta { get; set; }

    /// <summary>
    /// Unique identification of the map in which the position is referenced.<br/>
    /// Each map has the same origin of coordinates.<br/>
    /// When an AGV uses an elevator from a departure floor to a destination floor, it leaves the map of the departure floor and spawns on the corresponding elevator node on the map of the destination floor.
    /// </summary>
    public string MapId { get; set; }

    /// <summary>
    /// Additional information on the map. 
    /// </summary>
    public string MapDescription { get; set; }
}
