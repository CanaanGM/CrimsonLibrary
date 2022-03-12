using Newtonsoft.Json;

namespace CrimsonLibrary.Data.Errors
{
    public class Error
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString() => JsonConvert.SerializeObject(this);
        
    }
}
