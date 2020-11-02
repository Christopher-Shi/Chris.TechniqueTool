using System;

namespace Chris.TechniqueTool.EntityGenerate.OperationPlatformTestModels
{
    public partial class LocationAlarmFlag
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public bool TriggerAfterTheEmergencyAlarmTouchesTheAlarmSwitch { get; set; }
        public bool SpeedAlarm { get; set; }
        public bool FatigueDriving { get; set; }
        public bool EarlyWarning { get; set; }
        public bool GnssmoduleFailure { get; set; }
        public bool GnsstheAntennaNotConnecteOrCut { get; set; }
        public bool GnssshortCircuit { get; set; }
        public bool TerminalMainsUndervoltage { get; set; }
        public bool TerminalMainPowerFailure { get; set; }
        public bool TerminalLcdorDisplayFailure { get; set; }
        public bool TtsmoduleFailure { get; set; }
        public bool CameraFailure { get; set; }
        public bool AccumulatedDrivingTimeoutNowday { get; set; }
        public bool OvertimeParking { get; set; }
        public bool AccessArea { get; set; }
        public bool AccessRoute { get; set; }
        public bool InsufficientTravelTimeOnRoadSction { get; set; }
        public bool RouteDeviationAlarm { get; set; }
        public bool VehicleVssmalfunction { get; set; }
        public bool VehicleAbnormalOilQuantity { get; set; }
        public bool VehicleStolen { get; set; }
        public bool VehicleIllegalIgnition { get; set; }
        public bool VehicleIllegalDisplacement { get; set; }

        public virtual Location Location { get; set; }
    }
}
