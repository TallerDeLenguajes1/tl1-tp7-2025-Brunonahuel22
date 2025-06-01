// See https://aka.ms/new-console-template for more information
using EspacioEmpleados;

Empleado emp = new Empleado(
           "Bruno",
           "Córdoba",
           new DateTime(2000, 5, 20),
           'S',
           new DateTime(2022, 4, 1),
           200000,
           Cargo.Administrativo
       );

Console.WriteLine($"Empleado: {emp.Nombre} {emp.Apellido}, Cargo: {emp.Cargos}");

Console.WriteLine($"La antiguedad es de: {emp.Antiguedad()}");
Console.WriteLine($"La edad es de: {emp.CalcularEdad()}");