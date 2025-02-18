// Đây là nhánh "test-branch"
Console.WriteLine("Hello world!");

﻿Console.Write("Nhập tên: ");
string name;
name = Console.ReadLine() ?? throw new Exception("Vui lòng nhập tên");
Console.WriteLine($"Hello world, {name}");