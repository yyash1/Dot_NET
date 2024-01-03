using HRAPP.Entities;

namespace HRAPP.Services;

public interface IEmployeeService{
    public List<Employee> GetAll();
    public void UpdateList(List<Employee> list);
    public Employee? GetById(int id);
    public void Insert(Employee emp);
    public void Update(Employee emp);
     public void Delete(int id);
}