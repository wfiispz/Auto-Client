using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace AutoClientApplication {

    [Serializable]
    class ResourcesRespond {
        public List<ResourceRespond> resources;
        public PageRespond page;
    }

    [Serializable]
    class ResourceRespond {
        public string id;
        public string name;
        public string description;
        public List<string> measurementsGuids;
    }

    [Serializable]
    class PageRespond {
        public int size;
        public int number;
        public int totalCount;
    }

    [Serializable]
    public class MeasurementRespond {

        public string host;
        [JsonConverter(typeof(StringEnumConverter))]
        public MeasurementType metric;
        public string unit;
        public float maxValue;
        public bool complex;
        public string values;

    }

    [Serializable]
    public class Value {

        public float value;

        [JsonConverter(typeof(SqlDateTimeConverter))]
        public DateTime datatime;
    }


}
