using System;


namespace WpfAppTesting
{
    public class Person
    {
        //get obtener
        //set establecer

        public string ID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Email { get; set; }

        public string Birthday { get; set; }

        public string Gender { get; set; }



        //constructor

        public Person(string _id,string _name,string _lastname,string _email,string _birthday,string _gender)
        {
            ID = _id;
            Name = _name;
            Lastname = _lastname;
            Email = _email;
            Birthday = _birthday;
            Gender = _gender;

        }



    }
}
