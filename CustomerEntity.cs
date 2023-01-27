using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CustomerEntity : Customer
    {

        private static Random random = new Random();
        public Customer login (String email, String password)
        {

            using (var dbContext = new todoEntitiesEDM())
            {
                try
                {
                    Customer entCliente = dbContext.Customer.First(x => x.Email == email && x.Password == password);

                    if (entCliente != null)
                    {
                        return entCliente;
                    }
                    return null;
                } catch(ArgumentNullException ex)
                {
                    return null;
                }
                
            }
        }
        public void save(Customer customer)
        {
            using(var dbContext = new todoEntitiesEDM()) 
            {
                var entityCustomer = new Customer();
                entityCustomer.Name = customer.Name;
                entityCustomer.Email = customer.Email;
                entityCustomer.Password = customer.Password;
                entityCustomer.Uid = randomString(9);

                dbContext.Customer.Add(entityCustomer);

                dbContext.SaveChanges();
            }
        }

        public static string randomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
