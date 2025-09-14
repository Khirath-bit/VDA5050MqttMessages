namespace VDA5050MqttMessages.V210.Types;
public class LoadSpecification
{
    /// <summary>
    /// Array of load positions / load handling devices.<br/>
    /// This array contains the valid values for the parameter "state.loads[].loadPosition" and for the action parameter "lhd" of the actions pick and drop.<br/>
    /// If this array doesn't exist or is empty, the AGV has no load handling device.
    /// </summary>
    public List<string> LoadPositions { get; set; } = [];

    /// <summary>
    /// Array of loads that can be handled
    /// </summary>
    public List<LoadSet> LoadSets { get; set; } = [];
}
