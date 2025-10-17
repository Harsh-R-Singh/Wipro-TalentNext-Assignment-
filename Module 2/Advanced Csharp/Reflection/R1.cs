using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Console.Write("Enter the full path of the Movie Mini Project assembly (DLL): ");
        string assemblyPath = Console.ReadLine();

        if (!System.IO.File.Exists(assemblyPath))
        {
            Console.WriteLine("Assembly file not found.");
            return;
        }

        try
        {
            Assembly assembly = Assembly.LoadFrom(assemblyPath);

            // 1. Assembly Information
            Console.WriteLine($"••• Assembly Name: {assembly.FullName}");

            // 2. Module Information
            foreach (Module module in assembly.GetModules())
            {
                Console.WriteLine($"••••• Module Name: {module.Name}");

                // 3. Classes Information
                foreach (Type type in module.GetTypes())
                {
                    if (type.IsClass)
                    {
                        Console.WriteLine($"••••••• Class Name: {type.FullName}");

                        // 4. Constructors Information
                        ConstructorInfo[] constructors = type.GetConstructors();
                        foreach (ConstructorInfo ctor in constructors)
                        {
                            Console.Write($"••••••••• Constructor: {type.Name}(");
                            ParameterInfo[] parameters = ctor.GetParameters();
                            PrintParameters(parameters);
                            Console.WriteLine(")");
                        }

                        // 5. Methods Information
                        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        foreach (MethodInfo method in methods)
                        {
                            Console.Write($"••••••••• Method: {method.Name}(");
                            ParameterInfo[] parameters = method.GetParameters();
                            PrintParameters(parameters);
                            Console.WriteLine(")");
                        }

                        // 6. Properties Information
                        PropertyInfo[] properties = type.GetProperties();
                        foreach (PropertyInfo prop in properties)
                        {
                            Console.WriteLine($"••••••••• Property: {prop.Name} ({prop.PropertyType.Name})");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading assembly: {ex.Message}");
        }
    }

    static void PrintParameters(ParameterInfo[] parameters)
    {
        for (int i = 0; i < parameters.Length; i++)
        {
            Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
            if (i < parameters.Length - 1)
                Console.Write(", ");
        }
    }
}
