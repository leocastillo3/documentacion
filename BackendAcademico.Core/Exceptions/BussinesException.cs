namespace BackendAcademico.Core.Exceptions
{
    using System;

    public class BussinesException : Exception
    {
        public BussinesException()
        {

        }

        public BussinesException(string message) : base(message)
        {

        }

        public BussinesException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
