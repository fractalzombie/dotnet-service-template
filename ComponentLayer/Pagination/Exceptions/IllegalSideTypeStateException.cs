using System;
using System.Text.Json;
using ComponentLayer.Pagination.Data;

namespace ComponentLayer.Pagination.Exceptions
{
    public class IllegalSideTypeStateException : Exception
    {
        public IllegalSideTypeStateException(PageData pageData)
            : base($"Illegal side state: {JsonSerializer.Serialize(pageData)}")
        {
        }
    }
}
