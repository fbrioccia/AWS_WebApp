using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Core.Iot
{
    public class Data
{
    public int light { get; set; }
    public DateTime light_ts { get; set; }
    public int temperature { get; set; }
    public DateTime temperature_ts { get; set; }
    public int soil_moisture { get; set; }
    public DateTime soil_moisture_ts { get; set; }
    public int humidity { get; set; }
    public DateTime humidity_ts { get; set; }
}

public class WeekSchedule
{
    public List<string> scheduled_days { get; set; }
}

public class DailySchedule
{
    public List<List<string>> awake_intervals { get; set; }
    public List<List<string>> sleep_intervals { get; set; }
}

public class DataAction
{
}

public class AwakeMeasurement
{
    public string action { get; set; }
    public DataAction data_action { get; set; }
}

public class DataAction2
{
}

public class EventMeasurement
{
    public string action { get; set; }
    public DataAction2 data_action { get; set; }
    public string measurement { get; set; }
    public string @operator { get; set; }
    public string value { get; set; }
}

public class State2
{
    public bool is_on { get; set; }
    public int battery_level { get; set; }
    public bool is_scheduled_weekly { get; set; }
    public bool is_Scheduled_daily { get; set; }
    public WeekSchedule week_schedule { get; set; }
    public DailySchedule daily_schedule { get; set; }
    public bool measure_on_awake_intervals { get; set; }
    public List<AwakeMeasurement> awake_measurements { get; set; }
    public bool measure_on_events { get; set; }
    public List<EventMeasurement> event_measurements { get; set; }
    public bool send_data_on_awake_intervals { get; set; }
    public bool send_data_on_measurements { get; set; }
    public int send_data_on_hours_interval { get; set; }
    public bool action_on_events { get; set; }
    public DateTime last_on { get; set; }
    public DateTime last_off { get; set; }
    public DateTime last_sensor_check { get; set; }
    public DateTime last_humidity_check { get; set; }
    public DateTime last_soil_moisture_check { get; set; }
    public DateTime last_temperature_check { get; set; }
    public DateTime last_light_check { get; set; }
    public DateTime last_measurement_update { get; set; }
    public DateTime oldest_measurement_update { get; set; }
}

public class Desired
{
    public string welcome { get; set; }
    public Data data { get; set; }
    public State2 state { get; set; }
}

public class Data2
{
    public int light { get; set; }
    public DateTime light_ts { get; set; }
    public int temperature { get; set; }
    public DateTime temperature_ts { get; set; }
    public int soil_moisture { get; set; }
    public DateTime soil_moisture_ts { get; set; }
    public int humidity { get; set; }
    public DateTime humidity_ts { get; set; }
}

public class WeekSchedule2
{
    public List<string> scheduled_days { get; set; }
}

public class DailySchedule2
{
    public List<List<string>> awake_intervals { get; set; }
    public List<List<string>> sleep_intervals { get; set; }
}

public class DataAction3
{
}

public class AwakeMeasurement2
{
    public string action { get; set; }
    public DataAction3 data_action { get; set; }
}

public class DataAction4
{
}

public class EventMeasurement2
{
    public string action { get; set; }
    public DataAction4 data_action { get; set; }
    public string measurement { get; set; }
    public string @operator { get; set; }
    public string value { get; set; }
}

public class State3
{
    public bool is_on { get; set; }
    public int battery_level { get; set; }
    public bool is_scheduled_weekly { get; set; }
    public bool is_Scheduled_daily { get; set; }
    public WeekSchedule2 week_schedule { get; set; }
    public DailySchedule2 daily_schedule { get; set; }
    public bool measure_on_awake_intervals { get; set; }
    public List<AwakeMeasurement2> awake_measurements { get; set; }
    public bool measure_on_events { get; set; }
    public List<EventMeasurement2> event_measurements { get; set; }
    public bool send_data_on_awake_intervals { get; set; }
    public bool send_data_on_measurements { get; set; }
    public int send_data_on_hours_interval { get; set; }
    public bool action_on_events { get; set; }
    public DateTime last_on { get; set; }
    public DateTime last_off { get; set; }
    public DateTime last_sensor_check { get; set; }
    public DateTime last_humidity_check { get; set; }
    public DateTime last_soil_moisture_check { get; set; }
    public DateTime last_temperature_check { get; set; }
    public DateTime last_light_check { get; set; }
    public DateTime last_measurement_update { get; set; }
    public DateTime oldest_measurement_update { get; set; }
}

public class Reported
{
    public string welcome { get; set; }
    public Data2 data { get; set; }
    public State3 state { get; set; }
}

public class State
{
    public Desired desired { get; set; }
    public Reported reported { get; set; }
}

public class Welcome
{
    public int timestamp { get; set; }
}

public class Light
{
    public int timestamp { get; set; }
}

public class LightTs
{
    public int timestamp { get; set; }
}

public class Temperature
{
    public int timestamp { get; set; }
}

public class TemperatureTs
{
    public int timestamp { get; set; }
}

public class SoilMoisture
{
    public int timestamp { get; set; }
}

public class SoilMoistureTs
{
    public int timestamp { get; set; }
}

public class Humidity
{
    public int timestamp { get; set; }
}

public class HumidityTs
{
    public int timestamp { get; set; }
}

public class Data3
{
    public Light light { get; set; }
    public LightTs light_ts { get; set; }
    public Temperature temperature { get; set; }
    public TemperatureTs temperature_ts { get; set; }
    public SoilMoisture soil_moisture { get; set; }
    public SoilMoistureTs soil_moisture_ts { get; set; }
    public Humidity humidity { get; set; }
    public HumidityTs humidity_ts { get; set; }
}

public class IsOn
{
    public int timestamp { get; set; }
}

public class BatteryLevel
{
    public int timestamp { get; set; }
}

public class IsScheduledWeekly
{
    public int timestamp { get; set; }
}

public class IsScheduledDaily
{
    public int timestamp { get; set; }
}

public class ScheduledDay
{
    public int timestamp { get; set; }
}

public class WeekSchedule3
{
    public List<ScheduledDay> scheduled_days { get; set; }
}

public class DailySchedule3
{
    public List<List<object>> awake_intervals { get; set; }
    public List<List<object>> sleep_intervals { get; set; }
}

public class MeasureOnAwakeIntervals
{
    public int timestamp { get; set; }
}

public class Action
{
    public int timestamp { get; set; }
}

public class DataAction5
{
}

public class AwakeMeasurement3
{
    public Action action { get; set; }
    public DataAction5 data_action { get; set; }
}

public class MeasureOnEvents
{
    public int timestamp { get; set; }
}

public class Action2
{
    public int timestamp { get; set; }
}

public class DataAction6
{
}

public class Measurement
{
    public int timestamp { get; set; }
}

public class Operator
{
    public int timestamp { get; set; }
}

public class Value
{
    public int timestamp { get; set; }
}

public class EventMeasurement3
{
    public Action2 action { get; set; }
    public DataAction6 data_action { get; set; }
    public Measurement measurement { get; set; }
    public Operator @operator { get; set; }
    public Value value { get; set; }
}

public class SendDataOnAwakeIntervals
{
    public int timestamp { get; set; }
}

public class SendDataOnMeasurements
{
    public int timestamp { get; set; }
}

public class SendDataOnHoursInterval
{
    public int timestamp { get; set; }
}

public class ActionOnEvents
{
    public int timestamp { get; set; }
}

public class LastOn
{
    public int timestamp { get; set; }
}

public class LastOff
{
    public int timestamp { get; set; }
}

public class LastSensorCheck
{
    public int timestamp { get; set; }
}

public class LastHumidityCheck
{
    public int timestamp { get; set; }
}

public class LastSoilMoistureCheck
{
    public int timestamp { get; set; }
}

public class LastTemperatureCheck
{
    public int timestamp { get; set; }
}

public class LastLightCheck
{
    public int timestamp { get; set; }
}

public class LastMeasurementUpdate
{
    public int timestamp { get; set; }
}

public class OldestMeasurementUpdate
{
    public int timestamp { get; set; }
}

public class State4
{
    public IsOn is_on { get; set; }
    public BatteryLevel battery_level { get; set; }
    public IsScheduledWeekly is_scheduled_weekly { get; set; }
    public IsScheduledDaily is_Scheduled_daily { get; set; }
    public WeekSchedule3 week_schedule { get; set; }
    public DailySchedule3 daily_schedule { get; set; }
    public MeasureOnAwakeIntervals measure_on_awake_intervals { get; set; }
    public List<AwakeMeasurement3> awake_measurements { get; set; }
    public MeasureOnEvents measure_on_events { get; set; }
    public List<EventMeasurement3> event_measurements { get; set; }
    public SendDataOnAwakeIntervals send_data_on_awake_intervals { get; set; }
    public SendDataOnMeasurements send_data_on_measurements { get; set; }
    public SendDataOnHoursInterval send_data_on_hours_interval { get; set; }
    public ActionOnEvents action_on_events { get; set; }
    public LastOn last_on { get; set; }
    public LastOff last_off { get; set; }
    public LastSensorCheck last_sensor_check { get; set; }
    public LastHumidityCheck last_humidity_check { get; set; }
    public LastSoilMoistureCheck last_soil_moisture_check { get; set; }
    public LastTemperatureCheck last_temperature_check { get; set; }
    public LastLightCheck last_light_check { get; set; }
    public LastMeasurementUpdate last_measurement_update { get; set; }
    public OldestMeasurementUpdate oldest_measurement_update { get; set; }
}

public class Desired2
{
    public Welcome welcome { get; set; }
    public Data3 data { get; set; }
    public State4 state { get; set; }
}

public class Welcome2
{
    public int timestamp { get; set; }
}

public class Light2
{
    public int timestamp { get; set; }
}

public class LightTs2
{
    public int timestamp { get; set; }
}

public class Temperature2
{
    public int timestamp { get; set; }
}

public class TemperatureTs2
{
    public int timestamp { get; set; }
}

public class SoilMoisture2
{
    public int timestamp { get; set; }
}

public class SoilMoistureTs2
{
    public int timestamp { get; set; }
}

public class Humidity2
{
    public int timestamp { get; set; }
}

public class HumidityTs2
{
    public int timestamp { get; set; }
}

public class Data4
{
    public Light2 light { get; set; }
    public LightTs2 light_ts { get; set; }
    public Temperature2 temperature { get; set; }
    public TemperatureTs2 temperature_ts { get; set; }
    public SoilMoisture2 soil_moisture { get; set; }
    public SoilMoistureTs2 soil_moisture_ts { get; set; }
    public Humidity2 humidity { get; set; }
    public HumidityTs2 humidity_ts { get; set; }
}

public class IsOn2
{
    public int timestamp { get; set; }
}

public class BatteryLevel2
{
    public int timestamp { get; set; }
}

public class IsScheduledWeekly2
{
    public int timestamp { get; set; }
}

public class IsScheduledDaily2
{
    public int timestamp { get; set; }
}

public class ScheduledDay2
{
    public int timestamp { get; set; }
}

public class WeekSchedule4
{
    public List<ScheduledDay2> scheduled_days { get; set; }
}

public class DailySchedule4
{
    public List<List<object>> awake_intervals { get; set; }
    public List<List<object>> sleep_intervals { get; set; }
}

public class MeasureOnAwakeIntervals2
{
    public int timestamp { get; set; }
}

public class Action3
{
    public int timestamp { get; set; }
}

public class DataAction7
{
}

public class AwakeMeasurement4
{
    public Action3 action { get; set; }
    public DataAction7 data_action { get; set; }
}

public class MeasureOnEvents2
{
    public int timestamp { get; set; }
}

public class Action4
{
    public int timestamp { get; set; }
}

public class DataAction8
{
}

public class Measurement2
{
    public int timestamp { get; set; }
}

public class Operator2
{
    public int timestamp { get; set; }
}

public class Value2
{
    public int timestamp { get; set; }
}

public class EventMeasurement4
{
    public Action4 action { get; set; }
    public DataAction8 data_action { get; set; }
    public Measurement2 measurement { get; set; }
    public Operator2 @operator { get; set; }
    public Value2 value { get; set; }
}

public class SendDataOnAwakeIntervals2
{
    public int timestamp { get; set; }
}

public class SendDataOnMeasurements2
{
    public int timestamp { get; set; }
}

public class SendDataOnHoursInterval2
{
    public int timestamp { get; set; }
}

public class ActionOnEvents2
{
    public int timestamp { get; set; }
}

public class LastOn2
{
    public int timestamp { get; set; }
}

public class LastOff2
{
    public int timestamp { get; set; }
}

public class LastSensorCheck2
{
    public int timestamp { get; set; }
}

public class LastHumidityCheck2
{
    public int timestamp { get; set; }
}

public class LastSoilMoistureCheck2
{
    public int timestamp { get; set; }
}

public class LastTemperatureCheck2
{
    public int timestamp { get; set; }
}

public class LastLightCheck2
{
    public int timestamp { get; set; }
}

public class LastMeasurementUpdate2
{
    public int timestamp { get; set; }
}

public class OldestMeasurementUpdate2
{
    public int timestamp { get; set; }
}

public class State5
{
    public IsOn2 is_on { get; set; }
    public BatteryLevel2 battery_level { get; set; }
    public IsScheduledWeekly2 is_scheduled_weekly { get; set; }
    public IsScheduledDaily2 is_Scheduled_daily { get; set; }
    public WeekSchedule4 week_schedule { get; set; }
    public DailySchedule4 daily_schedule { get; set; }
    public MeasureOnAwakeIntervals2 measure_on_awake_intervals { get; set; }
    public List<AwakeMeasurement4> awake_measurements { get; set; }
    public MeasureOnEvents2 measure_on_events { get; set; }
    public List<EventMeasurement4> event_measurements { get; set; }
    public SendDataOnAwakeIntervals2 send_data_on_awake_intervals { get; set; }
    public SendDataOnMeasurements2 send_data_on_measurements { get; set; }
    public SendDataOnHoursInterval2 send_data_on_hours_interval { get; set; }
    public ActionOnEvents2 action_on_events { get; set; }
    public LastOn2 last_on { get; set; }
    public LastOff2 last_off { get; set; }
    public LastSensorCheck2 last_sensor_check { get; set; }
    public LastHumidityCheck2 last_humidity_check { get; set; }
    public LastSoilMoistureCheck2 last_soil_moisture_check { get; set; }
    public LastTemperatureCheck2 last_temperature_check { get; set; }
    public LastLightCheck2 last_light_check { get; set; }
    public LastMeasurementUpdate2 last_measurement_update { get; set; }
    public OldestMeasurementUpdate2 oldest_measurement_update { get; set; }
}

public class Reported2
{
    public Welcome2 welcome { get; set; }
    public Data4 data { get; set; }
    public State5 state { get; set; }
}

public class Metadata
{
    public Desired2 desired { get; set; }
    public Reported2 reported { get; set; }
}

public class RootObject
{
    public State state { get; set; }
    public Metadata metadata { get; set; }
    public int version { get; set; }
    public int timestamp { get; set; }
}
}