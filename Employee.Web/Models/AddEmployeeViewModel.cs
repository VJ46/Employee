﻿namespace Employee.Web.Models
{
    public class AddEmployeeViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public bool Subscribed { get; set; }

    }
}
