using HRAPP.Entities;
using HRAPP.Repositories;
namespace HRAPP.Services;

public class EmployeeService:IEmployeeService{
    public List<Employee> GetAll(){
       List<Employee> employees=new List<Employee>();
       RepositoryManager mgr=new RepositoryManager();
       string fileName=@"D:\GITHub\Dot_NET\Employee_App\employees.json";
       employees=mgr.DeSerialize(fileName);
       return employees;
    }
    public Employee? GetById(int id){
      List<Employee> employees=new List<Employee>();
       RepositoryManager mgr=new RepositoryManager();
       string fileName=@"D:\GITHub\Dot_NET\Employee_App\employees.json";
       employees=mgr.DeSerialize(fileName);
       foreach(Employee emp in employees){
            if(emp.Id==id){
               return emp;
            }
       }
         return null;
    }
    public void Insert(Employee emp){
       List<Employee> employees=new List<Employee>();
       RepositoryManager mgr=new RepositoryManager();
       string fileName=@"D:\GITHub\Dot_NET\Employee_App\employees.json";
       employees=mgr.DeSerialize(fileName);
       employees.Add(emp);
       mgr.Serialize(employees,fileName);
    }
     public void Update(Employee emp){}
     public void Delete(int id){
       List<Employee> employees=new List<Employee>();
       RepositoryManager mgr=new RepositoryManager();
       string fileName=@"D:\GITHub\Dot_NET\Employee_App\employees.json";
       employees=mgr.DeSerialize(fileName);
       Employee em =employees.Find(s=>s.Id==id);
       employees.Remove(em);
       mgr.Serialize(employees,fileName);
     }
      public void UpdateList(List<Employee> list){
       RepositoryManager mgr=new RepositoryManager();
       string fileName=@"D:\GITHub\Dot_NET\Employee_App\employees.json";
       mgr.Serialize(list,fileName);
      }
}
