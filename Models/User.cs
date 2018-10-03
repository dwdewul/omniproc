using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace omniproc.Models
{
    public class User
    {
        public Guid Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
    }


}