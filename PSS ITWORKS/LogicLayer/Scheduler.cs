using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSS_ITWORKS.LogicLayer
{
    class Scheduler
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
            // return jobs for day in list
            return "";

        }
        
      
    
    }
}
