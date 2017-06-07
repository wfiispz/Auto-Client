
using System.Collections.Generic;

namespace AutoClientApplication {

    public enum MeasurementType { CPU, Network, Memory }

    public class Measurement {

        public string host;
        public MeasurementType metric;
        public string unit;
        public float maxValue;
        public bool complex;
        public List<Value> values;

    }
}