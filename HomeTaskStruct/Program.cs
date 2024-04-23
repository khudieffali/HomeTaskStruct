
using HomeTaskStruct;
using System.Xml.Linq;
CustomCollection<Employee> customColllection = new();
headProcess:
Console.WriteLine("Zehmet olmasa etmek istediyiniz emeliyyati uygun nomreye gore secin: ");
Console.WriteLine("--------------------------------");
Console.WriteLine("Isci elave et - 1");
Console.WriteLine("Id-ye gore iscini tap - 2");
Console.WriteLine("Iscilerin siyahisini goster - 3");
Console.WriteLine("Emeliyyati dayandirin - 0");
Console.WriteLine("--------------------------------");
process:
Console.WriteLine("Secim edin: ");
string inputProcess = Console.ReadLine();
bool checkProcess = byte.TryParse(inputProcess, out byte process);
if (!checkProcess) goto process;

switch (process)
{
    case 1:
        if (!AddEmployee()) goto headProcess;
        else Console.WriteLine("Emeliyyat sona catdi");
        break;
    case 2:
    IdHead:
        Console.WriteLine("Id daxil edin: ");
        string inputId = Console.ReadLine();
        bool check = int.TryParse(inputId, out int id);
        if (!check) goto IdHead;
         customColllection.GetById(id);
        Console.WriteLine("Davam etmek isteyirsiniz? beli ve ya xeyr");
        string yesOrNo = Console.ReadLine();
        if (yesOrNo.ToLower() == "beli")
            goto headProcess;
        else Console.WriteLine("Emeliyyat sona catdi");
        break;
    case 3:
        GetAllEmployee();
        Console.WriteLine("Davam etmek isteyirsiniz? beli ve ya xeyr");
        string choose = Console.ReadLine();
        if (choose.ToLower() == "beli")
            goto headProcess;
        else Console.WriteLine("Emeliyyat sona catdi");
        break;
    case 0:
        Console.WriteLine("Emeliyyat sona catdi");
        break;
}




#region Task 1
 bool AddEmployee()
{
    bool checking = false;
    nameHead:
        Console.WriteLine("Adinizi qeyd edin: ");
        string name = Console.ReadLine();
        if (name == null || name.Length == 0) goto nameHead;
        surnameHead:
        Console.WriteLine("Soyadinizi qeyd edin: ");
        string surname = Console.ReadLine();
        if (surname == null || surname.Length == 0) goto surnameHead;
        head:
        Console.WriteLine("Yasinizi qeyd edin: ");
        string input = Console.ReadLine();
        bool check = byte.TryParse(input, out byte age);
        if (!check) goto head;
        salaryHead:
        Console.WriteLine("Emek haqqinizi qeyd edin: ");
        string inputSalary = Console.ReadLine();
        bool checkSalary = double.TryParse(inputSalary, out double salary);
        if (!checkSalary) goto salaryHead;
        Employee employee = new(name, surname, age, salary);
        CustomCollection<Employee> customCollection = new();
        customCollection.Add(employee);
        Console.WriteLine("Isci ugurla elave edildi");
        Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.Surname + " " + employee.Salary);
        Console.WriteLine("Davam etmek isteyirsiniz? beli ve ya xeyr");
        string yesOrNo = Console.ReadLine();
        if (yesOrNo.ToLower() != "beli")
        {
             checking = true;
        }
        return checking;
    }

#endregion


#region Task 3

 void GetAllEmployee()
{
    Console.WriteLine("  Iscilerin   melumatlari  ");
    foreach (var item in customColllection.GetAll())
    {
        Console.WriteLine(item.Id+" "+item.Name+" "+item.Surname+" "+item.Age+" "+item.Salary);
    }
}
#endregion

