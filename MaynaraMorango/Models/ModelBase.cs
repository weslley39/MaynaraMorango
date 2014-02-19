using System.ComponentModel.DataAnnotations;

namespace br.com.arcnet.spedstockweb.Models
{
    public class ModelBase
    {
        [ScaffoldColumn(false)]
        public string Id { get; set; }

        public T ToType<T>()
        {
            var str = Newtonsoft.Json.JsonConvert.SerializeObject(this);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(str, new Newtonsoft.Json.JsonSerializerSettings());
        }
        public static T FromType<T>(object obj)
        {
            var o = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            var objRet = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(o);
            return objRet;
        }
    }
}