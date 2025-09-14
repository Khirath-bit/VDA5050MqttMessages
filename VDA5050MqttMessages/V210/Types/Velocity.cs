namespace VDA5050MqttMessages.V210.Types;
public class Velocity
{
    /// <summary>
    /// Unit: <b>m/s</b> <br></br>
    /// The AGV's velocity in its X-direction. 
    /// </summary>
    public double Vx { get; set; }

    /// <summary>
    /// Unit: <b>m/s</b> <br></br>
    /// The AGV's velocity in its Y-direction. 
    /// </summary>
    public double Vy { get; set; }

    /// <summary>
    /// Unit: <b>RAD/s</b> <br></br>
    /// The AGV's turning speed around its Z-axis. 
    /// </summary>
    public double Omega { get; set; }
}
