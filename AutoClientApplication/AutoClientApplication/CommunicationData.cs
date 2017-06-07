using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AutoClientApplication {

    [Serializable]
    class ResourcesRespond {
        public List<ResourceRespond> resources { get; set; }
        public PageRespond page { get; set; }
    }

    [Serializable]
    class ResourceRespond {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<string> measurements { get; set; }
    }

    [Serializable]
    class PageRespond {
        public int size { get; set; }
        public int number { get; set; }
        public int totalCount { get; set; }
    }

    [Serializable]
    public class MeasurementRespond {

        public string host { get; set; }
        public string metric { get; set; }
        public string unit { get; set; }
        public float maxValue { get; set; }
        public bool complex { get; set; }
        public string values { get; set; }

    }

    [Serializable]
    public class ValueRespond {

        public List<Value> values { get; set; }
        public string measurements { get; set; }
    }

    [Serializable]
    public class Value {

        public float value { get; set; }

        [JsonConverter(typeof(SqlDateTimeConverter))]
        public DateTime timestamp { get; set; }

        [JsonIgnore]
        public float procentageValue;

    }


}
