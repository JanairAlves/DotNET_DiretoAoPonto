using System;
using System.Collections.Generic;

namespace DevFreela.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullname, string email, DateTime birthDate)
        {
            Fullname = fullname;
            Email = email;
            BirthDate = birthDate;
            Active = true;

            CreatedAt = DateTime.Now;
            Skills = new List<UserSkill>();
            OwnedProjects = new List<Project>();
            FreelanceProjects = new List<Project>();
        }

        public string Fullname { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; set; }

        public List<UserSkill> Skills { get; private set; }
        public List<Project> OwnedProjects { get; private set; }
        public List<Project> FreelanceProjects { get; set; }

        public void Update(string fullName, string email, DateTime bithDate, bool active)
        {
            Fullname = fullName;
            Email = email;
            BirthDate = bithDate;
            Active = active;
        }

        public void Cancel()
        {
            if(Active == true)
            {
                Active = false;
            }
        }
    }
}
