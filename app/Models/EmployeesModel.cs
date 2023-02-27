namespace app.Models
{
  public class EmployeesModel
    {
    public EmployeesModel(int id, string name, string sector, string role)
    {
        this.Id = id;
        this.Name = name;
        this.Sector = sector;
        this.Role = role;
    }

    public int Id { get; set; }
      public string Name { get; set; }
      public string Sector { get; set; }
      public string Role { get; set; }
    }
}
