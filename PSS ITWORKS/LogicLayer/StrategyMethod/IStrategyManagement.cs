

using PSS_ITWORKS.LogicLayer;

namespace PSS_ITWORKS
{
    public interface IStrategyAManagement
    {
        // connect to api ?
        // void connectDB(); ?

        void Get();
        // get something


        void Create(IEntity entity); 
        // create something


        void Delete(int ID);
        // delete something


        void Update(IEntity entity);
        // update something

        void Connect(string myString);
        // connect to something



    }
}