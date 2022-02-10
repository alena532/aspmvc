using System;
using System.Collections.Generic;
namespace Party.Models
{
    public interface IRepository
    {
         IEnumerable<GetResponse> Responses { get; }
         void AddResponse(GetResponse response);
        

    }
}
