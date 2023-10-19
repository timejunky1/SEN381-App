// EntityContract.cs
using System;
using System.Data.SqlClient;

namespace PSS_ITWORKS.LogicLayer
{
    class EntityContract : IEntity
    {
        private int Contract_ID;
        private int Ref_ID;
        private string SLA;
        private int Duration;
        private string Priority;
    }
}
