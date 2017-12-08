namespace RedisTest.Models
{
    public class EasyResult
    {
        public EasyResult()
        {
            
        }

        public EasyResult(string result)
        {
            Result = result;
        }

        public EasyResult(string result, object data) : this(result)
        {
            Data = data;
        }

        public string Result { get; set; }
        public object Data { get; set; }
    }
}