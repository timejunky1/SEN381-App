// IEntity.cs
using System.Windows.Forms;

namespace PSS_ITWORKS.LogicLayer
{
    public interface IEntity
    {
        object GetCalls();
        int GetID();
    }
}