using System;

class Program
{
    static void Main(string[] args)
    {       
        GoalManager manager = new GoalManager();    
            bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest Menu ---");
            Console.WriteLine("1. Show Goals");
            Console.WriteLine("2. Show Score");
            Console.WriteLine("3. Create New Goal");
            Console.WriteLine("4. Record Progress on a Goal");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            Console.Write("Choose an option: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    manager.ShowGoals();
                    break;
                case "2":
                    manager.ShowScore();
                    break;
                case "3":
                    CreateGoal();
                    break;
                case "4":
                    RecordProgress();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateGoal()
    {
        GoalManager manager = new GoalManager();    

        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1. Gym Goal");
        Console.WriteLine("2. Temple Vistation Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                manager.AddGoal(new GymGoal(name, description, points));
                break;
            case "2":
                manager.AddGoal(new TempleVisitationGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter number of times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points upon completion: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void RecordProgress()
    {
        GoalManager manager = new GoalManager();    

        Console.WriteLine("\nSelect a goal to record progress on:");
        manager.ShowGoals();
        Console.Write("Enter the number of the goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < manager.GoalCount())
        {
            manager.RecordGoal(index);
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    static void SaveGoals()
    {
        GoalManager manager = new GoalManager();    

        Console.Write("Enter filename to save to: ");
        string filename = Console.ReadLine();
        manager.SaveGoalsToFile(filename);
        Console.WriteLine("Goals saved!");
    }

    static void LoadGoals()
    {
        GoalManager manager = new GoalManager();    

        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();
        manager.LoadGoalsFromFile(filename);
        Console.WriteLine("Goals loaded!");
    }
}

   