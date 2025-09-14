using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA5050MqttMessages.V210.Types;
public class PhysicalParameters
{
    /// <summary>
    /// [m/s] Minimal controlled continuous speed of the AGV.
    /// </summary>
    public double SpeedMin { get; set; }

    /// <summary>
    /// [m/s] Maximum speed of the AGV.
    /// </summary>
    public double SpeedMax { get; set; }

    /// <summary>
    /// [Rad/s] Maximum rotation speed of the AGV. 
    /// </summary>
    public double AngularSpeedMax { get; set; }

    /// <summary>
    /// [Rad/s] Minimal controlled continuous rotation speed of the AGV.
    /// </summary>
    public double AngularSpeedMin { get; set; }

    /// <summary>
    /// [m/s²] Maximum acceleration with maximum load.
    /// </summary>
    public double AccelerationMax { get; set; }

    /// <summary>
    /// [m/s²] Maximum deceleration with maximum load.
    /// </summary>
    public double AccelerationMin { get; set; }

    /// <summary>
    /// [m] Minimum height of AGV.
    /// </summary>
    public double HeightMin { get; set; }

    /// <summary>
    /// [m] Maximum height of AGV.
    /// </summary>
    public double HeightMax { get; set; }

    /// <summary>
    /// [m] Width of AGV. 
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// [m] Length of AGV. 
    /// </summary>
    public double Height { get; set; }
}
