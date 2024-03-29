﻿using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace CraftPro_REST_Service.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase {

        private readonly ICRUD<Employee> _employeeControl;
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ICRUD<Employee> employeeControl, ILogger<EmployeeController> logger = null) {
            _employeeControl = employeeControl;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] Employee employee) {
            IActionResult foundResult;
            int insertedId = await _employeeControl.Create(employee);
            if (insertedId == -1) {
                foundResult = StatusCode(500);
            } else {
                employee.EmployeeId = insertedId;
                foundResult = CreatedAtAction(nameof(Get), new {id = insertedId}, employee);
            }
            return foundResult;
        }

        private object Get() {
            throw new NotImplementedException();
        }
    }
}
