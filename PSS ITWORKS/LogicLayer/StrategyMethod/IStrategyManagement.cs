// IStrategyAManagement.cs
using PSS_ITWORKS.LogicLayer;
using System;
using System.Windows.Forms;

namespace PSS_ITWORKS
{
    public interface IStrategyAManagement
    {
        BindingSource Get();
        BindingSource Get(int ID);
        BindingSource GetSpecific(int id1 = 0, int id2 = 0, string s1 = "", string s2 = "");
        BindingSource GetSpecific1(string s1);
        BindingSource GetSpecific2(string s2);
        BindingSource GetSpecific1(int n1);
        BindingSource GetSpecific2(int n1);
        void Create(IEntity entity);
        void Delete(int ID);
        void Update(IEntity entity);
        void Connect(string myString);
    }
}