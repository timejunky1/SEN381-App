using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer.StrategyMethod
{
    public  class StrategyTechnician : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public void Create(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public List<IEntity> Get()
        {
            throw new NotImplementedException();
        }

        public IEntity Get(int ID)
        {
            EntityEmployee technician = api.GetEmployee(ID);
            List<EntityJob> jobs = new List<EntityJob>();
            List<int> jobIds = api.GetJobEmployeeRef(employeeId: ID);
            foreach(int id in jobIds)
            {
                jobs.Add(api.GetJob(id));
            }
            technician.SetJobs(jobs);
            return technician;
        }

        public void Update(IEntity entity)
        {
            EntityJob job = entity as EntityJob;
            api.UpdateJob(job);
        }
    }
}
