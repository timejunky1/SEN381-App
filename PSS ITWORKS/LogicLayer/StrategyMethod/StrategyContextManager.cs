// StrategyContextManager.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    class StrategyContextManager
    {
        private readonly IStrategyAManagement _strategy;
        private readonly IEntity entity;
        private readonly int id;
        private readonly string connectionString;

        public StrategyContextManager(IStrategyAManagement strategy)
        {
            _strategy = strategy;
        }

        public StrategyContextManager()
        {
        }

        public void ExecuteStrategy(string action)
        {
            switch (action.ToLower())
            {
                case "get":
                    _strategy.Get();
                    break;
                case "create":
                    _strategy.Create(entity);
                    break;
                case "delete":
                    _strategy.Delete(id);
                    break;
                case "update":
                    _strategy.Update(entity);
                    break;
                case "connect":
                    _strategy.Connect(connectionString);
                    break;
                default:
                    MessageBox.Show("No action");
                    break;
            }
        }

        void SetConnection(string conString)
        {
            // set connection
        }

        void SetEntity(string entity)
        {
            // set entity
        }

        void setId()
        {
            // set the id which will be used
        }

        public void ExecuteStrategyByUserRole(string userRole)
        {
            switch (userRole.ToLower())
            {
                case "jobmanager":
                    _strategy.Get();
                    _strategy.Create(entity);
                    break;
                case "servicemanager":
                    // Execute the strategy for ServiceManager
                    break;
                case "clientmanager":
                    // Execute the strategy for ClientManager
                    break;
                case "contractmanager":
                    // Execute the strategy for ContractManager
                    break;
                case "usermanager":
                    // Execute the strategy for UserManager
                    break;
                case "callmanager":
                    // Execute the strategy for CallManager
                    break;
                default:
                    MessageBox.Show("Invalid user role");
                    break;
            }
        }
    }
}
