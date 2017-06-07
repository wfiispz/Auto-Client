
using System.Collections.Generic;

namespace AutoClientApplication {

    public class Measurement {

        public string host;
        public string metric;
        public string unit;
        public float maxValue;
        public bool complex;
        public List<Value> values;

    }
}