namespace VDA5050MqttMessages.V210.Types.Actions;

/// <summary>
/// Request the AGV to pick a load.<br/>
/// AGVs with multiple load handling devices can process multiple pick operations in parallel.<br/>
/// In this case, the parameter <c>lhd</c> needs to be present (e.g., LHD1).<br/>
/// The parameter <c>stationType</c> informs how the pick operation is handled in detail (e.g., floor location, rack location, passive conveyor, active conveyor, etc.).<br/>
/// The load type informs about the load unit and can be used to switch fields, for example (e.g., EPAL, INDU, etc.).<br/>
/// For preparing the load handling device (e.g., pre-lift operations based on the height parameter), the action could be announced in the horizon in advance.<br/>
/// However, pre-lift operations are not reported as <c>RUNNING</c> in the AGV state, because the associated node is not released yet.<br/>
/// If on an edge, the vehicle can use its sensing device to detect the position for picking the node.
/// </summary>
public class PickAction : Action
{
    /// <summary>
    /// Request the AGV to pick a load.<br/>
    /// AGVs with multiple load handling devices can process multiple pick operations in parallel.<br/>
    /// In this case, the parameter <c>lhd</c> needs to be present (e.g., LHD1).<br/>
    /// The parameter <c>stationType</c> informs how the pick operation is handled in detail (e.g., floor location, rack location, passive conveyor, active conveyor, etc.).<br/>
    /// The load type informs about the load unit and can be used to switch fields, for example (e.g., EPAL, INDU, etc.).<br/>
    /// For preparing the load handling device (e.g., pre-lift operations based on the height parameter), the action could be announced in the horizon in advance.<br/>
    /// However, pre-lift operations are not reported as <c>RUNNING</c> in the AGV state, because the associated node is not released yet.<br/>
    /// If on an edge, the vehicle can use its sensing device to detect the position for picking the node.
    /// </summary>
    public PickAction(string stationType, string loadType, string? side = null, double? depth = null, double? height = null, string? loadId = null, string? stationName = null, string? lhd = null) : base(
        "pick",
        Guid.NewGuid().ToString(),
        "Request the AGV to pick a load. AGVs with multiple load handling devices can process multiple pick operations in parallel. In this case, the parameter lhd needs to be present (e.g., LHD1). The parameter stationType informs how the pick operation is handled in detail (e.g., floor location, rack location, passive conveyor, active conveyor, etc.). The load type informs about the load unit and can be used to switch field for example (e.g., EPAL, INDU, etc). For preparing the load handling device (e.g., pre-lift operations based on the height parameter), the action could be announced in the horizon in advance. But, pre-Lift operations, etc., are not reported as 'RUNNING' in the AGV state, because the associated node is not released yet. If on an edge, the vehicle can use its sensing device to detect the position for picking the node. ",
        BlockingTypes.NONE)
    {
        ActionParameters.Add("stationType", stationType);
        ActionParameters.Add("loadType", loadType);

        if (side != null)
            ActionParameters.Add("side", side);

        if (depth.HasValue)
            ActionParameters.Add("depth", depth.Value);

        if (height.HasValue)
            ActionParameters.Add("height", height.Value);

        if (loadId != null)
            ActionParameters.Add("loadId", loadId);

        if (stationName != null)
            ActionParameters.Add("stationName", stationName);

        if (lhd != null)
            ActionParameters.Add("lhd", lhd);
    }
}
