using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgilCourse
{
    public class User
    {
        public int id_worker_ { get; }
        public int id_post_ { get; }
        public string name_ { get; }
        public string post_ { get; }
        public int age_ { get; }
        public int salary_ { get; }

        public User(int id_worker, 
                    int id_post, 
                    string name, 
                    string post, 
                    int age, 
                    int salary)
        {
            this.id_worker_ = id_worker;
            this.id_post_ = id_post;
            this.name_ = name;
            this.post_ = post;
            this.age_ = age;
            this.salary_ = salary;
        }
    }
}
