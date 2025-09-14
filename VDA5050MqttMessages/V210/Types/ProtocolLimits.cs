namespace VDA5050MqttMessages.V210.Types;
public class ProtocolLimits
{
    /// <summary>
    /// Maximum MQTT message length.
    /// </summary>
    public uint MsgLength { get; set; }

    /// <summary>
    /// Maximum length of the serial number part in MQTT topics.<br/>
    /// Affected parameters: order.serialNumber, instantActions.serialNumber, state.SerialNumber, visualization.serialNumber, connection.serialNumber.
    /// </summary>
    public uint TopicSerialLen { get; set; }

    /// <summary>
    /// Maximum length of all other parts in MQTT topics.<br/>
    /// Affected parameters:<br/>
    /// order.timestamp, order.version, order.manufacturer,<br/>
    /// instantActions.timestamp, instantActions.version, instantActions.manufacturer,<br/>
    /// state.timestamp, state.version, state.manufacturer,<br/>
    /// visualization.timestamp, visualization.version, visualization.manufacturer,<br/>
    /// connection.timestamp, connection.version, connection.manufacturer.
    /// </summary>
    public uint TopicElemLen { get; set; }

    /// <summary>
    /// Maximum length of ID strings.<br/>
    /// Affected parameters:<br/>
    /// order.orderId,<br/>
    /// order.zoneSetId,<br/>
    /// node.nodeId,<br/>
    /// nodePosition.mapId,<br/>
    /// action.actionId,<br/>
    /// edge.edgeId,<br/>
    /// edge.startNodeId.
    /// </summary>
    public uint IdLen { get; set; }

    /// <summary>
    /// If "true", ID strings need to contain numerical values only.
    /// </summary>
    public bool IdNumericalOnly { get; set; }

    /// <summary>
    /// Maximum length of enum and key strings.<br/>
    /// Affected parameters:<br/>
    /// action.actionType, action.blockingType,<br/>
    /// edge.direction,<br/>
    /// actionParameter.key,<br/>
    /// state.operatingMode,<br/>
    /// load.loadPosition, load.loadType,<br/>
    /// actionState.actionStatus,<br/>
    /// error.errorType, error.errorLevel,<br/>
    /// errorReference.referenceKey,<br/>
    /// info.infoType, info.infoLevel,<br/>
    /// safetyState.eStop,<br/>
    /// connection.connectionState.
    /// </summary
    public uint EnumLen { get; set; }

    /// <summary>
    /// Maximum length of loadId strings.
    /// </summary>
    public uint LoadIdLen { get; set; }
}
