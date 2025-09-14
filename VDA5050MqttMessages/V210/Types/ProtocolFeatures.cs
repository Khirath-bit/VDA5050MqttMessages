using VDA5050MqttMessages.V210.Types.Actions;

namespace VDA5050MqttMessages.V210.Types;
public class ProtocolFeatures
{
    /// <summary>
    /// Supported/Optional required parameters
    /// </summary>
    public List<OptionalParameter> OptionalParameters { get; set; } = [];

    /// <summary>
    /// List of supported agv actions
    /// </summary>
    public List<AgvAction> AgvActions { get; set; } = [];


    public class OptionalParameter
    {
        /// <summary>
        /// Ful name of optional paramter e.g. "order.nodes.nodePosition.allowedDeviationTheta"
        /// </summary>
        public string Parameter { get; set; } = string.Empty;

        /// <summary>
        /// Support for optional parameters
        /// </summary>
        public SupportValues Support { get; set; }

        public enum SupportValues
        {
            /// <summary>
            /// Optional parameter is supported like specified
            /// </summary>
            SUPPORTED,
            /// <summary>
            /// Optional Parameter is required for proper agv operation
            /// </summary>
            REQUIRED
        }
    }

    public class AgvAction
    {
        // <summary>
        /// Name of the action as described in the first column of "Actions and Parameters".<br/>
        /// Identifies the function of the action.
        /// </summary>
        public string ActionType { get; set; } = string.Empty;

        /// <summary>
        /// Additional information on the action
        /// </summary>
        public string ActionDescription { get; set; } = string.Empty;

        /// <summary>
        /// Allowed scopes
        /// </summary>
        public List<Scopes> ActionScopes { get; set; } = [];

        /// <summary>
        /// List of parameters of this action
        /// </summary>
        public List<AgvActionParameters> AgvActionParameters { get; set; } = [];

        public enum Scopes 
        { 
            /// <summary>
            /// Usable as instant actions
            /// </summary>
            INSTANT, 
            /// <summary>
            /// Usable on nodes
            /// </summary>
            NODE, 
            /// <summary>
            /// Usable on edges
            /// </summary>
            EDGE 
        }
    }
    
    public class AgvActionParameters
    {
        /// <summary>
        /// Action key
        /// </summary>
        public string Key { get; set; } = string.Empty;

        /// <summary>
        /// <see cref="Value"/>
        /// </summary>
        public Value ValueDataType { get; set; }

        /// <summary>
        /// Description of the parameter
        /// </summary>
        public string Description { get; set; } = string.Empty;

        public bool IsOptional { get; set; }

        public enum Value
        {
            BOOL,
            NUMBER,
            INTEGER,
            FLOAT,
            STRING,
            OBJECT,
            ARRAY
        }
    }
}
