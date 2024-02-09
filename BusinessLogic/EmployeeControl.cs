using BusinessLogic.Interfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic {
    public class EmployeeControl : ICRUD<Employee> {
        private readonly ICRUD<Employee> _employee;

        public EmployeeControl(ICRUD<Employee> employee) {
            _employee = employee;
        }

        public Task<int> Create(Employee entity) {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id) {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAll() {
            throw new NotImplementedException();
        }

        public Task<Employee> GetValue(int id) {
            throw new NotImplementedException();
        }

        public Task<bool> Update(int id, Employee entity) {
            throw new NotImplementedException();
        }
    }
}
