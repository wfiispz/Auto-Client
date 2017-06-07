using Newtonsoft.Json;
using System;

namespace AutoClientApplication {

    public class SqlDateTimeConverter : JsonConverter {

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer){
            return Deserialize(reader.Value.ToString());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) {
            writer.WriteValue(Serialize((DateTime)value));
        }

        public override bool CanConvert(Type objectType) {
            return objectType == typeof(DateTime);
        }

        public static DateTime Deserialize(string value) {
            return DateTime.ParseExact(value, Utils.SQL_DATE_FORMAT, null);
        }

        public static string Serialize(DateTime value) {
            return value.ToString(Utils.SQL_DATE_FORMAT);
        }
    }
}