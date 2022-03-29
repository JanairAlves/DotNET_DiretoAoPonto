﻿
using System;

namespace DevFreela.Application.ViewModels
{
    public class UpdateUserInputModel
    {
        public int Id { get; private set; }
        public string Fullname { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public bool Active { get; private set; }
    }
}
