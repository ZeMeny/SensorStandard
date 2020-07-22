using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SensorStandard.MrsTypes
{
    public partial class DeviceSubscriptionConfiguration : MrsMessage
    {
        public DeviceSubscriptionConfiguration()
        {
            MrsMessageType = MrsMessageTypes.DeviceSubscriptionConfiguration;
        }
    }
}
