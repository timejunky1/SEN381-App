// Scheduler.cs
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer
{
    class Scheduler
    {
        private List<EntityJob> jobs;

        public void addJob(EntityJob job)
        {
            if (jobs.Contains(job))
            {
                return;
            }
            else
            {
                jobs.Add(job);
            }
        }

        public void SetJobs(List<EntityJob> jobs)
        {
            this.jobs = jobs;
        }

        public void GetSchedule(int maxDay, int Offset, DataGridView dgv)
        {
            dgv.RowCount = maxDay;
            int nr = 0;
            int s = 800;
            int e = 1600;
            int n = 0;
            int r = 0;
            foreach (EntityJob job in jobs)
            {
                try
                {
                    n = 0;
                    TimeSpan ts = job.GetTimeBegin() - (DateTime.Now.Add(new TimeSpan(-(DateTime.Now.Hour - 8), 0, 0)));
                    r = ts.Days + Offset;
                    if (r > maxDay || r < 0)
                    {
                        continue;
                    }
                    int timeStart = job.GetTimeBegin().Hour * 100 + job.GetTimeBegin().Minute / 60 * 100;
                    int timeEnd = job.GetTimeEnd().Hour * 100 + job.GetTimeEnd().Minute / 60 * 100;
                    for (int i = s; i < e; i += 50)
                    {
                        if (timeEnd < i)
                        {
                            break;
                        }
                        if (timeStart < i + 50)
                        {
                            dgv.Rows[r].Cells[0].Value = job.GetTimeBegin().DayOfWeek;
                            dgv.Rows[r].Cells[0].Style.BackColor = Color.Blue;
                            dgv.Rows[r].Cells[0].Style.ForeColor = Color.White;
                            dgv.Rows[r].Cells[n].Value = job.GetId().ToString();
                            dgv.Rows[r].Cells[n].Style.ForeColor = Color.White;
                            dgv.Rows[r].Cells[n].Style.BackColor = Color.Green;
                        }
                        n++;
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandler.DisplayError(ex);
                }
            }
        }
    }
}