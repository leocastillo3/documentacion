namespace BackendAcademico.Core.CustomEntities.Response
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Net;

    public class ResponseGet
    {
        public IEnumerable<object> Data { get; set; }
        public Message[] Messages { get; set; }
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
    }
}
