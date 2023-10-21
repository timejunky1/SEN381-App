// StrategyJobManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyJobManager : IStrategyAManagement
    {
        DatabaseAPI api;
        public BindingSource Get()
        {
            return api.GetJobSchedule();
        }

        public void Create(IEntity entity)
        {
            try
            {
                EntityJob job = entity as EntityJob;
                api.AssignJob(job);
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
                api.UpdateAssignedJob(job);
            }
            catch (Exception ex)
            {
                ErrorHandler.DisplayError(ex);
            }
        }

        public void Connect(string myString)
        {
            MessageBox.Show("Connect to or something");
        }

        public BindingSource Get(int ID)
        {
            throw new System.NotImplementedException();
        }

        public BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "")
        {
            if (!string.IsNullOrEmpty(s1))
            {
                try
                {
                    return api.GetJobsAssignedToEmployeeName(s1);
                }
                catch (Exception ex)
                {
                    ErrorHandler.DisplayError(ex);
                }
            }
            if (!string.IsNullOrEmpty(s2))
            {
                try
                {
                    DateTime date = DateTime.Parse(s1);
                    return api.UnassignedJobsOnDate(date);
                }catch(Exception ex)
                {
                    ErrorHandler.DisplayError(ex);
                }
            }
            throw new System.NotImplementedException();
        }
    }
}