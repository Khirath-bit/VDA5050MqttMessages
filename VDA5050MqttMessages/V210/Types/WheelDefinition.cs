using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VDA5050MqttMessages.V210.Types;
public class WheelDefinition
{
    public WheelType Type { get; set; }

    public bool IsActiveDriven { get; set; }

    public bool IsActiveSteered { get; set; }

    public WheelPosition Position { get; set; } = null!;

    /// <summary>
    /// [m], nominal diameter of wheel.
    /// </summary>
    public double Diameter { get; set; }

    /// <summary>
    /// [m], nominal width of wheel. 
    /// </summary>
    public double Width { get; set; }

    /// <summary>
    /// [m], nominal displacement of the wheel's center to the rotation point (necessary for caster wheels).<br/>
    /// If the parameter is not defined, it is assumed to be 0.
    /// </summary>
    public double CenterDisplacement { get; set; }

    /// <summary>
    /// Free-form text: can be used by the manufacturer to define constraints.
    /// </summary>
    public string Contraints { get; set; } = null!;

    public enum WheelType
    {
        DRIVE,
        CASTER,
        FIXED,
        MECANUM
    }

    public class WheelPosition
    {
        /// <summary>
        /// [m], x-position in AGV coordinate. system 
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// [m], y-position in AGV coordinate. system  
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// [rad], orientation of wheel in AGV coordinate system. Necessary for fixed wheels.
        /// </summary>
        public double Theta { get; set; }
    }
}
