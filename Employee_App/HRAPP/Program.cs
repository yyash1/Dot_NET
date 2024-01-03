using HRAPP.Entities;
using HRAPP.Services;
using HRAPP.Controllers;
using HRAPP.Views;

IEmployeeService svc=new EmployeeService();
EmployeesController controller=new EmployeesController(svc);
bool flag=false;
while(!flag){
Console.WriteLine("\n1.Add Employee \n2.Get All Emp List \n3.Find emp by ID \n4.Update Employee Details \n5.Delete Emp by Id \n6.Exit ");
    switch(int.Parse(Console.ReadLine())){
        case 1:
                Console.WriteLine("Enter Employee ID");
                int empid=int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Name");
                string empName=Console.ReadLine();
                Employee emp=new Employee{Id=empid, Name=empName};
                controller.Insert(emp);
        break;
        case 2:
                List<Employee> model=controller.GetAll();
                ListView view=new ListView(model);
                view.Render();
        break;
        case 3:
                Console.WriteLine("To Search, Enter Employee ID");
                int empid3=int.Parse(Console.ReadLine());
                Employee? emp3 =controller.GetById(empid3);
                if(emp3.Id>0){
                    DetailsView detail=new DetailsView(emp3);
                    detail.Render();
                }
                else{
                    Console.WriteLine("You Enter Invalid ID");
                }
        break;
        case 4:
                Console.WriteLine("Enter ID For modification");
                int id=int.Parse(Console.ReadLine());
                List<Employee> listemp=controller.GetAll();
                foreach(Employee empl in listemp){
                        if(empl.Id==id){
                            Console.WriteLine("Enter new ID and Name");
                            empl.Id=int.Parse(Console.ReadLine()); empl.Name=Console.ReadLine();
                        }
                }
                controller.UpdateList(listemp);
        break;
        case 5:
                Console.WriteLine("To Delete, Enter Employee ID");
                int empid5=int.Parse(Console.ReadLine());
                controller.Delete(empid5);
        break;
        case 6:
        flag=true;
        break;
    }

}