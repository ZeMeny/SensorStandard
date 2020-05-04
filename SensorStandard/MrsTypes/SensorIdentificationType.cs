using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorStandard.MrsTypes
{
    public partial class SensorIdentificationType
    {
        public override bool Equals(object obj)
        {
            bool result = true;
            if (obj is SensorIdentificationType sensorIdentification)
            {
                result &= sensorIdentification.SensorName == SensorName;
                result &= sensorIdentification.SensorType == SensorType;
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
