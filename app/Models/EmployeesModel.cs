using System.ComponentModel.DataAnnotations;

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

    [Required(ErrorMessage = "The field {0} is required")]
    public int Id { get; set; }

    [Required(ErrorMessage = "The field {0} is required")]
    public string Name { get; set; }

    [Required(ErrorMessage = "The field {0} is required")]
    public string Sector { get; set; }

    [Required(ErrorMessage = "The field {0} is required")]
    public string Role { get; set; }
  }
}
