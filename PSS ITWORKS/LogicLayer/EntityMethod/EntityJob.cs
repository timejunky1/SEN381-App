// EntityJob.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityJob : IEntity
    {
        private int Job_ID;
        private int Technician_ID;
        private int Client_ID;
        private int Service_ID;
        private DateTime Time_Begin;
        private DateTime Time_End;
        private string Status;
        private int Call_ID;

        
    }
}
