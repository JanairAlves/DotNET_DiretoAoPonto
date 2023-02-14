using System;

namespace DevFreela.Application.ViewModels
{
    public class UserDetailsViewModel
    {
        public UserDetailsViewModel(int id, string fullname, string email, DateTime birthDate, DateTime createdAt, bool active)
        {
            Id = id;
            Fullname = fullname;
            Email = email;
            BirthDate = birthDate;
            CreatedAt = createdAt;
            Active = active;
        }

        public int Id { get; private set; }
        public string Fullname { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; private set; }
    }
}
