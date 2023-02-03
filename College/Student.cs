using System;
using System.componentModel.DataAnnotations;

namespace College {
    public class Student : Person {
        [Required]
        public string School { get; set; }
        public string Specialization { get; set; }

        public override string ToString(){
            return $"{Id} {FirstName} {LastName} {School} {Specialization}";
        }

    }
}