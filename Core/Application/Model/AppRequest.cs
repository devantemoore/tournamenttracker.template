using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tournamenttracker.template.Core.Application.Model
{
    public class AppRequest<T1, T2> where T1 : class where T2 : class
    {
        public T1 Requester { get; set; }
        public T2 Receiver { get; set; }
        public RequestStatus RequestStatus { get; private set; }

        public AppRequest()
        {
            RequestStatus = RequestStatus.InReview;
        }
    }

    public enum RequestStatus
    {
        Approved = 1,
        Denied = 2,
        InReview = 3
    }
}
