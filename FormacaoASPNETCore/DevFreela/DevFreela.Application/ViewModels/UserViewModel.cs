namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(int id, string fullname, bool active)
        {
            Id = id;
            Fullname = fullname;
            Active = active;
        }

        public int Id { get; private set; }
        public string Fullname { get; private set; }
        public bool Active { get; private set; }
    }
}
