using System;

namespace Partial
{
    public class Store
    {
        private string name;
        private Employee[] employees =  new Employee[maxEmployees];
        private Product[] products = new Product[100];
        private int countProducts;
        private static int maxEmployees = 10;
        private int countEmployees;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void AddProduct(Product product)
        {
            if (countProducts <= 100)
                products[countProducts++] = product;
            else
                Console.WriteLine("S-a depasit limita de 100 de produse");
        }

        public Product GetProduct(int index)
        {
            if (index < 0 || index > countProducts)
                return null;

            return products[index];

        }

        public void AddEmployee(Employee employee)
        {
            if (countEmployees >= maxEmployees)
            {
                maxEmployees++;
                Employee[] employeesNew = new Employee[maxEmployees];
                employees.CopyTo(employeesNew, 0);
                employees = new Employee[maxEmployees];
                employeesNew.CopyTo(employees, 0);
            }
            employees[countEmployees++] = employee;

            employee.SetStoreMember(this);
        }

        public Employee[] GetEmployees()
        {
            return employees;
        }

        public string GetName()
        {
            return name;
        }
    }
}
