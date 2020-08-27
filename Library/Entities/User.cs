namespace Gesk.Library.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }

        public bool Auth(string nameInput, string passInput)
        {
            if (nameInput == this.Name && passInput == this.Password) return true;
            else return false;
        }
    }
}
