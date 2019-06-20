using System;

namespace Partial
{
    public class Employee
    {
        private Store storeMember;
        private string name;
        private int age;
        private long id;

        public void PrintInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("ID : " + id);
        }

        static long GetId(Employee employee)
        {
            return employee.id;
        }

        public string GetName()
        {
            return name;
        }

        public void SetInfo(string name, int age)
        {
            id++;
            this.name = name;
            this.age = age;
        }

        public void SetStoreMember(Store store)
        {
            storeMember = store;
        }
    }
}
