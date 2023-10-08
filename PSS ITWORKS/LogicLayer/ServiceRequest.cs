// ServiceRequest.cs
using System;
using System.Collections.Generic;

namespace PSS_ITWORKS.LogicLayer
{
    class ServiceRequest
    {
        private List<EntityJob> jobs;

        public bool addJob(EntityJob job)
        {
            if (jobs.Contains(job))
            {
                return false;
            }
            else
            {
                jobs.Add(job);
                return true;
            }
        }

        public string GetSchedule()
        {
            return "";
        }
    }
}