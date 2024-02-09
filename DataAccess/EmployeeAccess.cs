using DataAccess.Interfaces;
using Microsoft.Extensions.Logging;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess {
    public class EmployeeAccess : ICRUDAccess<Employee> {

        private readonly ILogger<ICRUDAccess<Employee>> logger;

        public EmployeeAccess(ILogger<ICRUDAccess<Employee>> logger = null) {
            this.logger = logger;
        }

        public Task<int> Create(Employee entity) {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id) {
            throw new NotImplementedException();
        }

        public Task<Employee> Get(int id) {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAll() {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id, Employee entity) {
            throw new NotImplementedException();
        }
    }
}
