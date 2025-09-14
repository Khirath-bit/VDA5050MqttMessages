namespace VDA5050MqttMessages.V210.Types;
public class Envelops3d
{
    /// <summary>
    /// Name of the envelope curve set.
    /// </summary>
    public string Set { get; set; } = string.Empty;

    /// <summary>
    /// Format of data, e.g., DXF. 
    /// </summary>
    public string Format { get; set; } = string.Empty;

    /// <summary>
    /// 3D-envelope curve data, format specified in <see cref="Format"/>
    /// </summary>
    public object Data { get; set; } = string.Empty;

    /// <summary>
    /// Protocol and URL definition for downloading the 3D-envelope curve data, e.g., ftp://xxx.yyy.com/ac4dgvhoif5tghji.
    /// </summary>
    public string Url { get; set; } = string.Empty;

    /// <summary>
    /// Free-form text: description of envelope curve set
    /// </summary>
    public string Description { get; set; } = string.Empty;  
}
