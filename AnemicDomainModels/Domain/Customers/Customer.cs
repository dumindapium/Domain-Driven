using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Customers
{
    public class Customer
    {
        /// <summary>
        /// Anemic domian models are models those are having public setters.
        /// So that anybody can update a property value at any point of the code and cannot enforce domain logics at ease.
        /// 
        /// This model also has primitive data types in properties.
        /// which is another anti pattern called Primitive Obsession where code relies on too much primitive types.
        /// </summary>

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
