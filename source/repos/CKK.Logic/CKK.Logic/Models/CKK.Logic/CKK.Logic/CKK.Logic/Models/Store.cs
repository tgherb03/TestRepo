namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void AddStoreItem(Product prod)
        {
            _product1 = prod;
            _product2 = prod;
            _product3 = prod;
        }

        public void RemoveStoreItem(int productNum) 
        {
            _id = productNum;

        }

        public Product GetStoreItem(int productNum)
        {
            return _product1;
            return _product2;
            return _product3;
        }

        public Product FindStoreItemById(int id)
        {
            return _product1;
            return _product2;
            return _product3;
        }


    }
}
