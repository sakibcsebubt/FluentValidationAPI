﻿namespace FluentAPI.Models
{
    public class UserModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string Designation { get; set; }
        public long RoleId { get; set; }

    }
}
