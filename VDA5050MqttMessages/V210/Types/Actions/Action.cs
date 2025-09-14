namespace VDA5050MqttMessages.V210.Types.Actions;

public class Action(string actionType, string actionId, string actionDescription, BlockingTypes blockingType)
{
    /// <summary>
    /// Name of the action as described in the first column of "Actions and Parameters".<br/>
    /// Identifies the function of the action.
    /// </summary>
    public string ActionType { get; set; } = actionType;

    /// <summary>
    /// Unique id to identify the action. this is useful for updates or cancallations later. <br></br>
    /// Suggestion: Use UUIDs
    /// </summary>
    public string ActionId { get; set; } = actionId;

    /// <summary>
    /// Additional information on the action
    /// </summary>
    public string ActionDescription { get; set; } = actionDescription;

    /// <summary>
    /// Gets or sets the blocking type. <br></br>
    /// This indicates what the vehicle can and can not do while this action. <br></br>
    /// Figure 17 Page 55 v2.1.0 VDA pdf <br></br>
    /// <see cref="BlockingTypes.SOFT"/> as example
    /// </summary>
    public string BlockingType { get; set; } = blockingType.ToString();

    /// <summary>
    /// Array of actionParameter objects for the indicated action, e.g., "deviceId", "loadId", "external triggers".
    /// </summary>
    public Dictionary<string, object> ActionParameters { get; set; } = [];

    public enum State
    {
        /// <summary>
        /// Action was received by the AGV but the node where it triggers was not yet reached or the edge where it is active was not yet entered.
        /// </summary>
        WAITING,
        /// <summary>
        /// Action was triggered, preparatory measures are initiated. 
        /// </summary>
        INITIALIZED,
        /// <summary>
        /// The action is running.
        /// </summary>
        RUNNING,
        /// <summary>
        /// The action is paused because of a pause instantAction or an external trigger (pause button on the AGV).
        /// </summary>
        PAUSED,
        /// <summary>
        /// The action is finished. <br></br>
        /// A result is reported via the <see cref="ActionState.ResultDescription"/>
        /// </summary>
        FINISHED,
        /// <summary>
        /// Action could not be finished for whatever reason.
        /// </summary>
        FAILED
    }
}
