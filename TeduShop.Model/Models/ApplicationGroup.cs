﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("ApplicationGroups")]
    public class ApplicationGroup
    {
        public ApplicationGroup()
        {
            this.Id = Guid.NewGuid().ToString();
            this.ApplicationRoles = new List<ApplicationGroupRole>();
            this.ApplicationUsers = new List<ApplicationUserGroup>();
        }

        public ApplicationGroup(string name)
            : this()
        {
            this.Name = name;
        }

        public ApplicationGroup(string name, string description)
            : this(name)
        {
            this.Description = description;
        }

        [Key]
        public string Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public virtual ICollection<ApplicationGroupRole> ApplicationRoles { get; set; }

        public virtual ICollection<ApplicationUserGroup> ApplicationUsers { get; set; }
    }
}