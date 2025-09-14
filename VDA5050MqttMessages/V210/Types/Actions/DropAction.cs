namespace VDA5050MqttMessages.V210.Types.Actions;

/// <summary>
/// Request the AGV to drop a load.
/// See action <see cref="PickAction"/> for more details.
/// </summary>
public class DropAction : Action
{
    /// <summary>
    /// Request the AGV to drop a load.
    /// See action <see cref="PickAction"/> for more details.
    /// </summary>
    public DropAction(string stationType, string loadType, string? side = null, double? depth = null, double? height = null, string? loadId = null, string? stationName = null, string? lhd = null) : base(
        "drop",
        Guid.NewGuid().ToString(),
        "Request the AGV to drop a load. See action pick for more details.",
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
