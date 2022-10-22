using Lab_Week_2;

EmployeeManager employeeManager = new EmployeeManager();
Employee employee = new Employee { Id=1,FirstName="Emir",LastName="Karataş"};
employeeManager.Add(employee);

Console.WriteLine(employeeManager.getEmps().Count);

employeeManager.Remove(1);
Console.WriteLine(employeeManager.getEmps().Count);