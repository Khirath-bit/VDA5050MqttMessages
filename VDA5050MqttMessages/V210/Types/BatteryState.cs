namespace VDA5050MqttMessages.V210.Types;
public class BatteryState
{
    /// <summary>
    /// State of Charge:<br/>
    /// If the AGV only provides values for good or bad battery levels, these will be indicated as 20% (bad) and 80% (good).
    /// </summary>
    public double BatteryCharge { get; set; }

    /// <summary>
    /// Battery Voltage. 
    /// </summary>
    public double BatteryVoltage { get; set; }

    /// <summary>
    /// Range: [0 ... 100]<br/>
    /// State describing the battery's health.
    /// </summary>
    public byte BatteryHealth { get; set; }

    /// <summary>
    /// "true": charging in progress.<br/>
    /// "false": AGV is currently not charging.
    /// </summary>
    public bool Charging { get; set; }

    /// <summary>
    /// Range: [0 ... uint32.max]<br/>
    /// Estimated reach with the current state of charge.
    /// </summary>
    public uint Reach { get; set; }
}
