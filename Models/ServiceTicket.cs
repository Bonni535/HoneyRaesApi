namespace HoneyRaesAPI.Models;

public class ServiceTicket
{
    public string Id { get; set; }
    public string CustomerId { get; set; }
    public int? EmployeeId { get; set; }
    public string Description { get; set; }
    public bool Emergency { get; set; }
    public DateTime? DateCompleted { get; set; }
    public Employee Employee { get; set; }
    public Customer Customer { get; set; }
}
