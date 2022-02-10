using System;
using System.Collections.Generic;

namespace Party.Models
{
    public class Repository:IRepository
    {
        List<GetResponse> responses=new();
        public Repository()
        {
            responses.Add(new GetResponse() { Name = "Marina", Email = "Marina.yandex.com", Phone = "+375333775510", WillAttend = true });
        }

        public IEnumerable<GetResponse> Responses => responses;

        public void AddResponse(GetResponse response)
        {
            responses.Add(response);
        }
    }
}
