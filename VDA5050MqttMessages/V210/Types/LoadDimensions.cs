namespace VDA5050MqttMessages.V210.Types;

/// <summary>
/// Dimensions of the load's bounding box in meters.
/// </summary>
public class LoadDimensions
{
    /// <summary>
    /// Absolute width of the load's 
    /// bounding box.
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// Absolute height of the load's 
    /// bounding box.
    /// </summary>
    public double Height { get; set; }

    /// <summary>
    /// Absolute length of the load's 
    /// bounding box.
    /// </summary>
    public double Length { get; set; }
}
