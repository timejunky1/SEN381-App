// StrategyJobManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyJobManager : IStrategyAManagement
    {
        DatabaseAPI api = new DatabaseAPI();
        public BindingSource Get()
        {
            return api.GetJobSchedule();
        }

        public void Create(IEntity entity)
        {
            try
            {
                EntityJob job = entity as EntityJob;
                foreach(EntityUser user in job.GetEmployees())
                {
                    api.AssignJob(user.GetID(), job.GetId());
                }
            }catch(Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
            
        }

        public void Delete(int ID)
        {
            MessageBox.Show("Delete something");
        }

        public void Update(IEntity entity)
        {
            try
            {
                EntityJob job = entity as EntityJob;
                api.DeleteEmployeeJobRef(job.GetId());
                foreach (EntityUser employee in job.GetEmployees())
                {
                    api.AddEmployeeJobRef(job.GetId(), employee.GetID());
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void Connect(string myString)
        {
            api.SetConnection(myString);
        }

        public BindingSource Get(int ID)
        {
            throw new System.NotImplementedException();
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            BindingSource bs = new BindingSource();
            bs = api.GetUnasignedJobs();
            return bs;
            if (!string.IsNullOrEmpty(s1))
            {
                try
                {
                    bs = api.GetJobsAssignedToEmployeeName(s1);
                }
                catch (Exception ex)
                {
                    ErrorHandler.DisplayError(ex);
                }
            }
            else if (!string.IsNullOrEmpty(s2))
            {
                try
                {
                    DateTime date = DateTime.Parse(s2);
                    bs = api.GetJobsOnDate(date);
                }
                catch (Exception ex)
                {
                    ErrorHandler.DisplayError(ex);
                }
            }
            return bs;
        }

        public BindingSource GetSpecific1(string s1)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific2(string s2)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific1(int n1)
        {
            throw new NotImplementedException();
        }

        public BindingSource GetSpecific2(int n1)
        {
            throw new NotImplementedException();
        }
    }
}