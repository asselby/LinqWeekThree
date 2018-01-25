using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 m = new Model1();

            #region ClassWork
            //var whoIsBoss = from Employees in m.Employees
            //             let isBoss = (Employees.ReportsTo==null)
            //             select new
            //             {
            //                 Employees.EmployeeID,
            //                 Employees.FirstName,
            //                 isBoss
            //             };

            //foreach (var item in whoIsBoss)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();

            //var employeesHireAge = from Employees in m.Employees.ToList()
            //                let haredAge = ((Employees.HireDate - Employees.BirthDate).Value.Days / 365)
            //                orderby haredAge
            //                select new
            //                {
            //                    Employees.EmployeeID,
            //                    Employees.FirstName,
            //                    haredAge
            //                };

            //foreach (var item in employeesHireAge)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //decimal KZTRatioToUSD = 335;
            //var orderCostInKZT = from groupedItem in (from Orders in m.Order_Details.ToList()
            //                                          let costKZT = (Orders.Quantity * Orders.UnitPrice) * KZTRatioToUSD
            //                                          select new
            //                                          {
            //                                            Orders.OrderID,
            //                                            costKZT
            //                                          })
            //                     group groupedItem by groupedItem.OrderID;

            //var sumByOrderGroup = from item in orderCostInKZT
            //                      select new
            //                      {
            //                          orderId = item.Key,
            //                          totalSum = item.Sum(p => p.costKZT)
            //                      };

            //foreach (var item in sumByOrderGroup)
            //{ 
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //var youngEmployees = from Employees in m.Employees.ToList()
            //                     let age = ((DateTime.Now - Employees.BirthDate).Value.Days / 365)
            //                     let isYoung = (age >= 18 && age <= 40)
            //                     where isYoung == true
            //                     orderby age
            //                     select new
            //                     {
            //                         Employees.EmployeeID,
            //                         Employees.FirstName,
            //                         age
            //                     };

            //Console.WriteLine("Young employees:");
            //foreach (var item in youngEmployees)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //var middleEmployees = from Employees in m.Employees.ToList()
            //                      let age = ((DateTime.Now - Employees.BirthDate).Value.Days / 365)
            //                      let isMiddle = (age >= 41 && age <= 60)
            //                      where isMiddle == true
            //                      orderby age
            //                      select new
            //                      {
            //                          Employees.EmployeeID,
            //                          Employees.FirstName,
            //                          age
            //                      };

            //Console.WriteLine("Middle employees:");
            //foreach (var item in middleEmployees)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //var oldEmployees = from Employees in m.Employees.ToList()
            //                   let age = ((DateTime.Now - Employees.BirthDate).Value.Days / 365)
            //                   let isOld = (age >= 61)
            //                   where isOld == true
            //                   orderby age
            //                   select new
            //                   {
            //                       Employees.EmployeeID,
            //                       Employees.FirstName,
            //                       age
            //                   };

            //Console.WriteLine("Old employees:");
            //foreach (var item in oldEmployees)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();

            //var ordersByMonths = from Orders in m.Orders.ToList()
            //                     let month = Orders.OrderDate.Value.Month
            //                     orderby month
            //                     group Orders by month into o
            //                     select new
            //                     {
            //                         Key=o.Key,
            //                         Count=o.Count(),
            //                         Orders=from orders in o
            //                                select orders
            //                     };

            //foreach(var month in ordersByMonths)
            //{
            //    switch (month.Key)
            //    {
            //        case 1:
            //            Console.WriteLine("January");
            //            break;
            //        case 2:
            //            Console.WriteLine("February");
            //            break;
            //        case 3:
            //            Console.WriteLine("March");
            //            break;
            //        case 4:
            //            Console.WriteLine("April");
            //            break;
            //        case 5:
            //            Console.WriteLine("May");
            //            break;
            //        case 6:
            //            Console.WriteLine("June");
            //            break;
            //        case 7:
            //            Console.WriteLine("July");
            //            break;
            //        case 8:
            //            Console.WriteLine("August");
            //            break;
            //        case 9:
            //            Console.WriteLine("September");
            //            break;
            //        case 10:
            //            Console.WriteLine("October");
            //            break;
            //        case 11:
            //            Console.WriteLine("November");
            //            break;
            //        case 12:
            //            Console.WriteLine("December");
            //            break;
            //    };
            //    Console.WriteLine("Orders quantity: " + month.Count);
            //    foreach (Orders order in month.Orders)
            //    {
            //        Console.WriteLine(order.OrderID);
            //    }
            //    Console.WriteLine();
            //}

            //var ordersByShippingCompany = from Orders in m.Orders.ToList()
            //                              orderby Orders.ShipVia
            //                              group Orders by Orders.ShipVia into o
            //                              select new
            //                              {
            //                                  Key = o.Key,
            //                                  Count = o.Count(),
            //                                  Orders = from orders in o
            //                                           select orders
            //                              };
            //foreach(var item in ordersByShippingCompany)
            //{
            //    Console.WriteLine("ShipVia: "+item.Key);
            //    foreach(Orders order in item.Orders)
            //    {
            //        Console.WriteLine(order.OrderID);
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Homework

            // Task 1 

            var employeesCustomers = from groupedItem in m.Orders.ToList()
                                     group groupedItem by groupedItem.EmployeeID into o
                                     select new
                                     {
                                         Employee = o.Key,
                                         Customers = from customers in o
                                                     select customers.CustomerID
                                     };

            foreach (var item in employeesCustomers)
            {
                Console.WriteLine("EmployeeID: " + item.Employee);
                Console.WriteLine("CustomerIDs:");
                foreach (var customer in item.Customers)
                {
                    Console.WriteLine(customer);
                }
                Console.WriteLine();
            }

            // Task 2

            var employeesProductIDs = from orders in m.Orders.ToList()
                                    join orderDetails in m.Order_Details.ToList() 
                                    on orders.OrderID equals orderDetails.OrderID
                                    join employee in m.Employees.ToList()
                                    on orders.EmployeeID equals employee.EmployeeID
                                    select new
                                     {
                                         EmployeeId = orders.EmployeeID,
                                         EmployeeFirstName=employee.FirstName,
                                         ProductId=orderDetails.ProductID
                                     };

            var employeesProducts = from employeeProdIds in employeesProductIDs
                                    join products in m.Products.ToList()
                                    on employeeProdIds.ProductId equals products.ProductID
                                    select new
                                    {
                                        Employee = employeeProdIds.EmployeeFirstName,
                                        Product = products.ProductName
                                    };

            var groupedProductsByEmployees = from ep in employeesProducts
                                             group ep by ep.Employee into g
                                             select new
                                             {
                                                 Employee=g.Key,
                                                 Products=from products in g
                                                          select products.Product
                                             };

            foreach(var employee in groupedProductsByEmployees)
            {
                Console.WriteLine("EmployeeName: "+employee.Employee);
                Console.WriteLine("Products:");
                foreach(var products in employee.Products)
                {
                    Console.WriteLine(products);
                }
                Console.WriteLine();
            }


            // Task 3
            var ordersByCountry = from orders in m.Orders.ToList()
                                  join customers in m.Customers.ToList()
                                  on orders.CustomerID equals customers.CustomerID
                                  select new
                                  {
                                      Country = customers.Country,
                                      OrderId = orders.OrderID
                                  };
            var ordersSum=from groupedItem in (from Orders in m.Order_Details.ToList()
                                               let cost = (Orders.Quantity * Orders.UnitPrice) 
                                               join ordersCountry in ordersByCountry
                                               on Orders.OrderID equals ordersCountry.OrderId
                                               select new
                                               {
                                                   ordersCountry.Country,
                                                   cost
                                               })
                          group groupedItem by groupedItem.Country;

            var sumByCountry = from item in ordersSum
                                  select new
                                  {
                                      Country = item.Key,
                                      TotalSum = item.Sum(p => p.cost)
                                  };

            foreach(var country in sumByCountry)
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();

            // Task 4

            var customerCity = from customers in m.Customers.ToList()
                               group customers by customers.City into c
                               select new
                               {
                                   City = c.Key,
                                   CompanyName = from cn in c select cn.CompanyName
                               };
            var employeeCity = from employees in m.Employees.ToList()
                               group employees by employees.City into e
                               select new
                               {
                                   City = e.Key,
                                   Name = from n in e select new { n.FirstName, n.LastName }
                               };
            Console.WriteLine("Customers: ");
            foreach (var item in customerCity)
            {
                Console.WriteLine(item.City);
                foreach(var customer in item.CompanyName)
                {
                    Console.WriteLine(customer);
                }
            }

            Console.WriteLine("Employees: ");
            foreach (var item in employeeCity)
            {
                Console.WriteLine(item.City);
                foreach (var employee in item.Name)
                {
                    Console.WriteLine(employee.FirstName+" "+employee.LastName);
                }
            }

            // Task 5
            var ordersByShipCity = from orders in m.Orders.ToList()
                                  group orders by orders.ShipCity into o
                                  select new
                                  {
                                      ShipCity = o.Key,
                                      Order = from ord in o select ord
                                  };

            foreach(var shipCity in ordersByShipCity)
            {
                Console.WriteLine("Ship city: "+ shipCity.ShipCity);
                Console.WriteLine("Orders");
                foreach(var item in shipCity.Order)
                {
                    Console.WriteLine(item.OrderID);
                }
                Console.WriteLine();
            }

            // Task 6
            var customerCities = from customers in m.Customers.ToList()
                                 join orders in m.Orders.ToList()
                                 on customers.City equals orders.ShipCity
                                 select new
                                 {
                                     CustomerID = customers.CustomerID,
                                     CompanyName = customers.CompanyName,
                                     City = orders.ShipCity
                                 };
            var groupedCustomers = from customers in customerCities
                                   group customers by customers.City into c
                                   select new
                                   {
                                       City = c.Key,
                                       Customers = (from cust in c select cust.CompanyName).Distinct()
                                   };

            foreach(var city in groupedCustomers)
            {
                Console.WriteLine("City: "+city.City);
                foreach(var customer in city.Customers)
                {
                    Console.WriteLine(customer);
                }
                Console.WriteLine();
            }

            // Task 7
            var employeeCities = from employees in m.Employees.ToList()
                                 join orders in m.Orders.ToList()
                                 on employees.City equals orders.ShipCity
                                 select new
                                 {
                                     CustomerID = employees.EmployeeID,
                                     OrderID = orders.OrderID,
                                     Name = employees.FirstName,
                                     City = orders.ShipCity
                                 };
            var groupedEmployees = from employees in employeeCities
                                   group employees by employees.City into e
                                   select new
                                   {
                                       City = e.Key,
                                       Employees = (from emp in e select emp.Name).Distinct(),
                                   };
            foreach(var item in groupedEmployees)
            {
                Console.WriteLine("City: "+item.City);
                foreach(var employee in item.Employees)
                {
                    Console.WriteLine("EmployeeName: "+employee);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            // Task 8

            var supplierCities = from suppliers in (from suppliers in (from suppliers in m.Suppliers.ToList()
                                                                       join products in m.Products.ToList()
                                                                       on suppliers.SupplierID equals products.SupplierID
                                                                       select new
                                                                       {
                                                                           products.ProductID,
                                                                           suppliers.CompanyName,
                                                                           suppliers.City
                                                                       })
                                                    join orderDetails in m.Order_Details.ToList()
                                                    on suppliers.ProductID equals orderDetails.ProductID
                                                    select new
                                                    {
                                                        suppliers.ProductID,
                                                        orderDetails.OrderID,
                                                        suppliers.CompanyName,
                                                        suppliers.City
                                                    })
                                 join orders in m.Orders.ToList()
                                 on suppliers.OrderID equals orders.OrderID
                                 where suppliers.City == orders.ShipCity
                                 select new
                                 {
                                     suppliers.OrderID,
                                     suppliers.CompanyName,
                                     suppliers.City
                                 };

            foreach(var item in supplierCities)
            {
                Console.WriteLine($"{item.OrderID}-{item.CompanyName}-{item.City}");
            }


            #endregion

            Console.ReadLine();
        }
    }
}
