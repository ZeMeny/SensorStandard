using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorStandard.MrsTypes
{
    public partial class DeviceConfiguration : MrsMessage
    {
        public DeviceConfiguration()
        {
            MrsMessageType = MrsMessageTypes.DeviceConfiguration;
        }
    }
}
