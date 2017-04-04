using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    public class Battery
    {
        private uint battHoursIdle;
        private uint battHoursTalk;
        private BatteryType batteryType;

        public uint BattHoursIdle { get; set; }
        public uint BattHoursTalk { get; set; }
        public BatteryType BatteryType { get; set; }

        public Battery()
        {
        }

        public Battery(uint battHoursIdle)
        {
            this.BattHoursIdle = battHoursIdle;
        }

        public Battery(uint battHoursIdle, uint battHourstalk)
        {
            this.BattHoursIdle = battHoursIdle;
            this.BattHoursTalk = battHourstalk;
        }

        public Battery(uint battHoursIdle, uint battHourstalk, BatteryType batteryType)
        {
            this.BattHoursIdle = battHoursIdle;
            this.BattHoursTalk = battHourstalk;
            this.BatteryType = batteryType;
        }


    }


    public enum BatteryType
    {
        LiIon = 1,
        NiMH = 2,
        NiCd = 3
    }
}
