namespace VDA5050MqttMessages.V210.Types.Actions;
public class StopChargingAction : Action
{
    public StopChargingAction() : base(
        "stopCharging",
        Guid.NewGuid().ToString(),
        "Deactivates the charging process to send a new order. The charging process can also be interrupted by the vehicle / charging station, e.g., if the battery is full. ",
        BlockingTypes.HARD)
    { }
}
