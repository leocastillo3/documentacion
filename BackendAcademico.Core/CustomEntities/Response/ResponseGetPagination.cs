namespace BackendAcademico.Core.CustomEntities.Response
{
    using Newtonsoft.Json;
    using System.Net;

    public class ResponseGetPagination
    {
        public ListaPaginada<object> Paginations { get; set; }
        public Message[] Messages { get; set; }
        [JsonIgnore]
        public HttpStatusCode StatusCode { get; set; }
    }
}
