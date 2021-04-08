namespace BackendAcademico.Core.CustomEntities.Response
{
    using Newtonsoft.Json;
    using System.Net;

    public class ResponsePost
    {
        public Message[] Messages { get; set; }
        public ResponsePostDetail Response { get; set; }
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
    }
}
