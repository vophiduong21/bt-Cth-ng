using System;
using System.Collections.Generic;
using System.Linq;

public class Department
{
    public string Name { get; set; }
    public string Description { get; set; }
}

public class Position
{
    public string Title { get; set; }
    public string Description { get; set; }
}

public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Position Position { get; set; }
    public Department Department { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Tạo danh sách các đối tượng
        var departments = new List<Department>
        {
            new Department { Name = "Phong A", Description = "Phong Kinh doanh" },
            new Department { Name = "Phong B", Description = "Phong Ke Toan" }
        };

        var positions = new List<Position>
        {
            new Position { Title = "Truong Phong", Description = "Tang 3" },
            new Position { Title = "Quan Ly", Description = "Tang 3" },
            new Position { Title = "pho phong", Description = "Tang 3" }
        };

        var employees = new List<Employee>
        {
            new Employee { Name = "Huy", Age = 30, Position = positions[0], Department = departments[0] },
            new Employee { Name = "Minh", Age = 25, Position = positions[2], Department = departments[1] },
            new Employee { Name = "Lien", Age = 25, Position = positions[0], Department = departments[0] },
            new Employee { Name = "Nam", Age = 25, Position = positions[2], Department = departments[1] },
            new Employee { Name = "Huyen", Age = 35, Position = positions[1], Department = departments[0] }
        };

        // Nhập từ khóa tìm kiếm từ bàn phím
        Console.Write("Tu khoa tim kiem : ");
        string keyword = Console.ReadLine();

        Console.Write("Tuoi tu (nhan Enter neu bo qua): ");
        string minAgeInput = Console.ReadLine();
        int? minAge = string.IsNullOrWhiteSpace(minAgeInput) ? (int?)null : int.Parse(minAgeInput);

        Console.Write("Tuoi den (nhan Enter neu bo qua): ");
        string maxAgeInput = Console.ReadLine();
        int? maxAge = string.IsNullOrWhiteSpace(maxAgeInput) ? (int?)null : int.Parse(maxAgeInput);

        Console.Write("Vi tri (nhan Enter neu bo qua): ");
        string positionKeyword = Console.ReadLine();

        Console.Write("Phong ban (nhan Enter neu bo qua): ");
        string departmentKeyword = Console.ReadLine();

        // Tìm kiếm và in ra kết quả
        var results = from emp in employees
                      where (minAge == null || emp.Age >= minAge) &&
                            (maxAge == null || emp.Age <= maxAge) &&
                            (string.IsNullOrWhiteSpace(positionKeyword) || emp.Position.Title.Contains(positionKeyword) || emp.Position.Description.Contains(positionKeyword)) &&
                            (string.IsNullOrWhiteSpace(departmentKeyword) || emp.Department.Name.Contains(departmentKeyword) || emp.Department.Description.Contains(departmentKeyword)) &&
                            (string.IsNullOrWhiteSpace(keyword) || emp.Name.Contains(keyword))
                      select emp;

        Console.WriteLine("\nKet qua tim kiem:");
        foreach (var result in results)
        {
            Console.WriteLine($"Ten: {result.Name}, Tuoi: {result.Age}, Vi tri: {result.Position.Title}, Phong ban: {result.Department.Name}");
        }
        Console.ReadLine();
    }
}