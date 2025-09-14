namespace VDA5050MqttMessages.V210.Types;
public class TypeSpecification
{
    public string SeriesName { get; set; } = string.Empty;

    public string SeriesDescription { get; set; } = string.Empty;

    /// <summary>
    /// <see cref="AgvKinematics"/>
    /// </summary>
    public string AgvKinematic { get; set; } = string.Empty;

    /// <summary>
    /// <see cref="AgvClasses"/>
    /// </summary>
    public string AgvClass {  get; set; } = string.Empty;

    public double MaxLoadMass { get; set; }

    /// <summary>
    /// <see cref="LocalizationType"/>
    /// </summary>
    public List<string> LocalizationTypes { get; set; } = [];

    /// <summary>
    /// <see cref="NavigationType"/>
    /// </summary>
    public List<string> NavigationTypes { get; set; } = [];
}
