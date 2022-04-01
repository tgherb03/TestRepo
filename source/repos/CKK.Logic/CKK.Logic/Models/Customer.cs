namespace CKK.Logic
{
    public class Customer
    {

        // Id int {get; set;}
        // Name string {get; set;}
        // Address string {get; set;}
        private int _Id;
        private string _Name;
        private string _Address;

        public Customer(int Id, string Name, string Address)
        {
            _Id = Id;
            _Name = Name;
            _Address = Address;
        }

        public int GetId(int Id)
        {
            return Id;
        }
        public void SetId(int ID)
        {
            _Id = ID;
        }

        public string GetName(string Name)
        {
            return Name;
        }

        public void SetName(string Name)
        {
            _Name = Name;
        }

        public string GetAdress(string Adress)
        {
            return Adress;
        }

        public void SetAddress(string Address)
        {
            _Address = Address;
        }

    }

}
