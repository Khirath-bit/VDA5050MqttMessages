namespace VDA5050MqttMessages.V210.Types.Actions;

/// <summary>
/// On a node, the AGV will position exactly on a target.<br/>
/// The AGV is allowed to deviate from its node position.<br/>
/// On an edge, the AGV will, for example, align on stationary equipment while traversing the edge.<br/>
/// <b>InstantAction:</b> the AGV starts positioning exactly on a target.
/// </summary>
public class FinePositioningAction : Action
{
    /// <summary>
    /// On a node, the AGV will position exactly on a target.<br/>
    /// The AGV is allowed to deviate from its node position.<br/>
    /// On an edge, the AGV will, for example, align on stationary equipment while traversing the edge.<br/>
    /// <b>InstantAction:</b> the AGV starts positioning exactly on a target.
    /// </summary>
    public FinePositioningAction(string? stationType = null, string? stationName = null) : base(
        "finePositioning",
        Guid.NewGuid().ToString(),
        "On a node, AGV will position exactly on a target. The AGV is allowed to deviate from its node position. On an edge, AGV will e.g., align on stationary equipment while traversing an edge. InstantAction: AGV starts positioning exactly on a target. ",
        BlockingTypes.NONE)
    {
        if (stationType != null)
            ActionParameters.Add("stationType", stationType);

        if (stationName != null)
            ActionParameters.Add("stationName", stationName);
    }
}
