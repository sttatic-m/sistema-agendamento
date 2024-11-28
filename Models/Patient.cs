namespace sistema_agendamento.Models;

public class Patient
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public DateTime RegisterDate { get; set; }

    public Patient(string name, string phone, string email)
    {
        Name = name;
        Phone = phone;
        Email = email;

        RegisterDate = DateTime.Now;
    }
}