// IStrategyAManagement.cs
using PSS_ITWORKS.LogicLayer;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public interface IStrategyAManagement
    {
        BindingSource Get();
        BindingSource Get(int ID);
        BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "");
        void Create(IEntity entity);
        void Delete(int ID);
        void Update(IEntity entity);
        void Connect(string myString);
    }
}