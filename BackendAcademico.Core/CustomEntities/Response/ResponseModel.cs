using System;
namespace BackendAcademico.Core.CustomEntities.Response
{
    using System.Collections.Generic;

    public class ResponseModel
    {
        public ResponseModel()
        {
            IsValid = true;
            ValidationMessages = new List<Message>();
        }
        public bool IsValid { get; set; }
        public List<Message> ValidationMessages { get; set; }
    }
}