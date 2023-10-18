// IStrategyAManagement.cs
using PSS_ITWORKS.LogicLayer;

namespace PSS_ITWORKS
{
    public interface IStrategyAManagement
    {
        void Get();
        void Get(int ID);
        void Get(string s1 = "", string s2 = "");
        void Create(IEntity entity);
        void Delete(int ID);
        void Update(IEntity entity);
        void Connect(string myString);
    }
}