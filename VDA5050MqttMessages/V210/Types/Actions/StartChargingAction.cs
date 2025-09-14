namespace VDA5050MqttMessages.V210.Types.Actions;
public class StartChargingAction : Action
{
    public StartChargingAction() : base(
        "startCharging",
        Guid.NewGuid().ToString(),
        "Activates the charging process. Charging can be done on a charging spot (vehicle standing) or on a charging lane (while driving). Protection against overcharging is responsibility of the vehicle. ",
        BlockingTypes.HARD)
    { }
}
