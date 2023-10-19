// EntityService.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityService : IEntity
    {
        private int Service_ID;
        private string Title;
        private string Duration;
        private string Priority;
        private decimal Cost;

    }
}
