using Newtonsoft.Json;

namespace VDA5050MqttMessages.V210.Types;
public class MaxArrayLens
{
    [JsonProperty("order.nodes")]
    public uint OrderNodes {  get; set; }

    [JsonProperty("order.edges")]
    public uint OrderEdges { get; set; }

    [JsonProperty("node.actions")]
    public uint NodeActions { get; set; }

    [JsonProperty("edge.actions")]
    public uint EdgeActions { get; set; }

    [JsonProperty("action.actionParameters")]
    public uint ActionActionsParameters { get; set; }

    [JsonProperty("instantActions")]
    public uint InstantActions { get; set; }

    [JsonProperty("trajectory.knotVector")]
    public uint TrajectoryKnotVector { get; set; }

    [JsonProperty("trajectory.controlPoints")]
    public uint TrajectoryControlPoints { get; set; }

    [JsonProperty("state.nodeStatus")]
    public uint StateNodeStates { get; set; }

    [JsonProperty("state.edgeStates")]
    public uint StateEdgeStates { get; set; }

    [JsonProperty("state.loads")]
    public uint StateLoads { get; set; }

    [JsonProperty("state.errors")]
    public uint StateErrors { get; set; }

    [JsonProperty("state.information")]
    public uint StateInformation { get; set; }

    [JsonProperty("error.errorReferences")]
    public uint ErrorErrorReferences { get; set; }

    [JsonProperty("information.infoReferences")]
    public uint InformationInfoReferences { get; set; }
}
