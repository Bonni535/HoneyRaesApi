namespace HoneyRaesAPI.Models;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public List<ServiceTickets> ServiceTickets { get; set; }
    public List<Customer> Customer { get; set; }
}

