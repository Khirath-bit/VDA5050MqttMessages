namespace VDA5050MqttMessages.V210.Types;
public class LoadSet
{
    /// <summary>
    /// Unique name of the load set (e.g., DEFAULT, SET1)
    /// </summary>
    public string SetName { get; set; } = string.Empty;

    /// <summary>
    /// Type of load (e.g., EPAL, XLT1200)
    /// </summary>
    public string LoadType { get; set; } = string.Empty;

    /// <summary>
    /// Array of load positions this load set is valid for.
    /// If empty or missing, valid for all load handling devices.
    /// </summary>
    public List<string> LoadPositions { get; set; } = [];

    /// <summary>
    /// Bounding box reference as defined in state.loads[]
    /// </summary>
    public BoundingBoxReference BoundingBoxReference { get; set; } = null!;

    /// <summary>
    /// Load dimensions as defined in state.loads[]
    /// </summary>
    public LoadDimensions LoadDimensions { get; set; } = null!;

    /// <summary>
    /// [kg], maximum weight of load type.
    /// </summary>
    public double MaxWeight { get; set; }

    /// <summary>
    /// [m], minimum allowed height for handling of this load type and weight.<br/>
    /// References <c>boundingBoxReference</c>.
    /// </summary>
    public double MinLoadHandlingHeight { get; set; }

    /// <summary>
    /// [m], maximum allowed height for handling of this load type and weight.<br/>
    /// References <c>boundingBoxReference</c>.
    /// </summary>
    public double MaxLoadHandlingHeight { get; set; }

    /// <summary>
    /// [m], minimum allowed depth for this load type and weight.<br/>
    /// References <c>boundingBoxReference</c>.
    /// </summary>
    public double MinLoadHandlingDepth { get; set; }

    /// <summary>
    /// [m], maximum allowed depth for this load type and weight.<br/>
    /// References <c>boundingBoxReference</c>.
    /// </summary>
    public double MaxLoadHandlingDepth { get; set; }

    /// <summary>
    /// [rad], minimum allowed tilt for this load type and weight.
    /// </summary>
    public double MinLoadHandlingTilt { get; set; }

    /// <summary>
    /// [rad], maximum allowed tilt for this load type and weight. 
    /// </summary>
    public double MaxLoadHandlingTilt { get; set; }

    /// <summary>
    /// [m/s], maximum allowed speed for this load type and weight.
    /// </summary>
    public double AgvSpeedLimit { get; set; }

    /// <summary>
    /// [m/s²], maximum allowed acceleration for this load type and weight. 
    /// </summary>
    public double AgvAccelerationLimit { get; set; }

    /// <summary>
    /// [m/s²], maximum allowed deceleration for this load type and weight. 
    /// </summary>
    public double AgvDecelerationLimit { get; set; }

    /// <summary>
    /// [s], approx. time for picking up the load
    /// </summary>
    public double PickTime { get; set; }

    /// <summary>
    /// [s], approx. time for dropping the load.
    /// </summary>
    public double DropTime { get; set; }

    /// <summary>
    /// Free-form text: description of the load handling set.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
