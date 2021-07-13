using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tournamenttracker.template.Core.Application.Model
{
    public class AppRequest<T> where T : class
    {
        public Guid RequestId { get; private set; }
        public T Requester { get; set; }
        public RequestStatus RequestStatus { get; set; }
    }

    public enum RequestStatus
    {
        Approved = 1,
        Denied = 2,
        InReview = 3
    }
}
