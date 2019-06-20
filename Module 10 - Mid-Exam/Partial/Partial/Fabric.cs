namespace Partial
{
    public class Fabric
    {
        Store[] stores;
        string name;
        int maxStores;
        int countStores;

        public void CreateFabric(string name, int maxStores)
        {
            this.name = name;
            this.maxStores = maxStores;
        }

        public Store GetStore(string name)
        {
            for (int i = 0; i < stores.Length; i++)
            {
                if(stores[i].GetName() == name)
                {
                    return stores[i];
                }
            }
            return null;
        }

    }
}
