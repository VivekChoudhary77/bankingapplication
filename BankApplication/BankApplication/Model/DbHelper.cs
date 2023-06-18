namespace BankApplication.Model
{
    public class DbHelper
    {
        private EF_DataContext _context;
        public DbHelper(EF_DataContext context)
        {
            _context = context;
        }
        /// <summary>
        /// GET
        /// </summary>
        /// <returns></returns>
        public List<CustomerModel> GetCustomers() 
        {
            List<CustomerModel> response = new List<CustomerModel>();
            var dataList = _context.Customers.ToList();
            dataList.ForEach(row => response.Add(new CustomerModel()
            {
                CustId = row.CustId,
                AccID = row.AccID,
                Name = row.Name,
                City = row.City,
                Address = row.Address,
                DOB = row.DOB,
                Open_bal = row.Open_bal,
                Mobileno = row.Mobileno,
                Astatus = row.Astatus,
                Atype = row.Atype,
                Occupation = row.Occupation,
            }));
            return response;
        }
        /// <summary>
        /// GET ID
        /// </summary>
        /// <returns></returns>
        public CustomerModel GetCustomersById(int id)
        {
            CustomerModel response = new CustomerModel();
            var row = _context.Customers.Where(d=>id.Equals(id)).FirstOrDefault();
            return new CustomerModel() {
                CustId = row.CustId,
                AccID = row.AccID,
                Name = row.Name,
                City = row.City,
                Address = row.Address,
                DOB = row.DOB,
                Open_bal = row.Open_bal,
                Mobileno = row.Mobileno,
                Astatus = row.Astatus,
                Atype = row.Atype,
                Occupation = row.Occupation,
            };
        }
        /// <summary>
        /// Serves the Post/Put/Patch
        /// </summary>
        public void SaveCustomer(CustomerModel customerModel)
        {
            Customer dbTable = new Customer();
            if(customerModel.CustId > 0)
            {
                //PUT
                dbTable = _context.Customers.Where(d=>d.CustId.Equals(customerModel.CustId)).FirstOrDefault();
                if(dbTable != null)
                {
                    dbTable.AccID = customerModel.AccID;
                    dbTable.Address = customerModel.Address;
                    dbTable.Atype = customerModel.Atype;
                    dbTable.Name = customerModel.Name;
                    dbTable.City = customerModel.City;
                    dbTable.Address = customerModel.Address;
                    dbTable.DOB = customerModel.DOB;
                    dbTable.Open_bal = customerModel.Open_bal;
                    dbTable.Mobileno = customerModel.Mobileno;
                    dbTable.Occupation = customerModel.Occupation;
                }
            }
            else
            {
                //Post
                dbTable.AccID = customerModel.AccID;
                dbTable.Name = customerModel.Name;
                dbTable.City = customerModel.City;
                dbTable.Address = customerModel.Address;
                dbTable.DOB = customerModel.DOB;
                dbTable.Open_bal = customerModel.Open_bal;
                dbTable.Mobileno = customerModel.Mobileno;
                dbTable.Astatus = customerModel.Astatus;
                dbTable.Atype = customerModel.Atype;
                dbTable.Occupation = customerModel.Occupation;
                _context.Customers.Add(dbTable);
            }
            _context.SaveChanges();
        }
        /// <summary>
        /// DELETE
        /// </summary>
        public void DeleteCustomer(int id)
        {
            var customer =  _context.Customers.Where(d => d.CustId.Equals(id)).FirstOrDefault();
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }
    }
}
