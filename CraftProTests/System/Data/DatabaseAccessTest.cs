using DataAccess;
using DataAccess.Interfaces;
using FluentAssertions;
using Model;
using System.Data;
using System.Data.SqlClient;
using Xunit.Abstractions;

namespace CraftProTests.System.Data {
    public class DatabaseAccessTest : IDisposable {

        private readonly ICRUDAccess<Employee> _employeeAccess;

        // Connection test for DB
        private readonly string _connectionString = "Data Source=.;Database=CraftPro;integrated security=true;";

        public DatabaseAccessTest() {
            _employeeAccess = new EmployeeAccess(_connectionString);
        }

        [Fact]
        public void WasConnectedToDatabase() {
            // Arrange
            using (SqlConnection con = new SqlConnection(_connectionString)) {

                // Act
                con.Open();

                // Assert
                con.State.Should().Be(ConnectionState.Open);
            }
        }
        public void Dispose() {
            throw new NotImplementedException();
        }
    }
}
