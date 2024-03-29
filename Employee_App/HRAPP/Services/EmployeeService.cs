using HRAPP.Entities;
using HRAPP.Repositories;
namespace HRAPP.Services;

public class EmployeeService:IEmployeeService{
      List<Employee> employees=new List<Employee>();
      RepositoryManager mgr=new RepositoryManager();
      string fileName=@"D:\GITHub\Dot_NET\Employee_App\employees.json";
    public List<Employee> GetAll(){
       employees=mgr.DeSerialize(fileName);
       return employees;
    }
    public Employee? GetById(int id){
       employees=mgr.DeSerialize(fileName);
       foreach(Employee emp in employees){
            if(emp.Id==id){
               return emp;
            }
       }
         return null;
    }
    public void Insert(Employee emp){
       employees=mgr.DeSerialize(fileName);
       employees.Add(emp);
       mgr.Serialize(employees,fileName);
    }
     public void Update(Employee emp){}
     public void Delete(int id){
       employees=mgr.DeSerialize(fileName);
       Employee em =employees.Find(s=>s.Id==id);
       employees.Remove(em);
       mgr.Serialize(employees,fileName);
     }
      public void UpdateList(List<Employee> list){
       mgr.Serialize(list,fileName);
      }
}
