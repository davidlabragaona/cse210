public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private List<string> _menu = new List<string>();
    private List<string> _submenu = new List<string>();

    private int _score;

    public GoalManager() {
        _score = 0;
        _menu.Add("Create New Goal");
        _menu.Add("List Goals");
        _menu.Add("Save Goals");
        _menu.Add("Load Goals");
        _menu.Add("Record Event");
        _menu.Add("Quit");

        _submenu.Add("Simple Goal");
        _submenu.Add("Eternal Goal");
        _submenu.Add("Checklist Goal");
        _submenu.Add("Negative Goal");
    }

    public void Start() {
        bool exitMenu = false;
        string prompt = string.Empty;

        Console.Clear();

        while(!exitMenu) {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options:");
            for (int i = 0; i < _menu.Count; i++) {
                Console.WriteLine($"  {i + 1}. {_menu[i]}");
            }
            Console.Write("Select a choice from the menu: ");
            prompt = Console.ReadLine();

            switch (prompt) {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                default:
                    exitMenu = true;
                    break;
            }
        }

    }

    public void DisplayPlayerInfo() {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }

    public void ListGoalNames() {
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetShortName()}");
        }
    }

    public void ListGoalDetails() {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++) {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal() {
        string prompt = string.Empty;
        string name = string.Empty;
        string description = string.Empty;
        string points = string.Empty;

        Console.WriteLine("The types of Goals are:");
        for (int i = 0; i < _submenu.Count; i++) {
            Console.WriteLine($"  {i + 1}. {_submenu[i]}");
        }
        Console.Write("Which type of goal would you like to create? ");
        prompt = Console.ReadLine();

        //Since all goals need 3 basic elements, we capture those here:
        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        points = Console.ReadLine();

        if (prompt == "1") {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);
            _goals.Add(simpleGoal);
        } else if (prompt == "2") {
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        } else if (prompt == "3") {
            int target, bonus;
            Console.Write("How many times does this goal need be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(checklistGoal);
        } else {
            //Negative Goal
            NegativeGoal negativeGoal = new NegativeGoal(name, description, points);
            _goals.Add(negativeGoal);
        }
    }

    public void RecordEvent() {
        int option = -1;
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.Write("What goal did you accomplish? ");
        do {
            option = int.Parse(Console.ReadLine()) - 1;
        }
        while (option < 0 && option > _goals.Count - 1);
        if (!_goals[option].IsComplete()) {
            _goals[option].RecordEvent();
            _score += _goals[option].GetPoints();
        }
    }

    public void SaveGoals() {
        string filename = string.Empty;
        Console.Write("What is the filename for the goal file? ");
        filename = Console.ReadLine();
        using (StreamWriter streamWriter = new StreamWriter(filename)) {
            streamWriter.WriteLine(_score);
            foreach (Goal goal in _goals) {
                streamWriter.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals() {
        string filename = string.Empty;
        string line = string.Empty;
        string[] content;

        Console.Write("What is the filename for the goal file? ");
        filename = Console.ReadLine();
        using (StreamReader streamReader = new StreamReader(filename)) {
            _goals.Clear();
            //We expect to find the score as the first line
            _score = int.Parse(streamReader.ReadLine());
            while (!streamReader.EndOfStream) {
                line = streamReader.ReadLine();
                content = line.Split(":");
                string[] attributes = content[1].Split(",");
                switch (content[0]) {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(attributes[0], attributes[1], attributes[2], attributes[3] == "False" ? false : true);
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(attributes[0], attributes[1], attributes[2]);
                        _goals.Add(eternalGoal);
                        break;
                    case "ChecklistGoal":
                        ChecklistGoal checklistGoal = new ChecklistGoal(attributes[0], attributes[1], attributes[2], int.Parse(attributes[3]), int.Parse(attributes[4]));
                        _goals.Add(checklistGoal);
                        break;
                    case "NegativeGoal":
                        NegativeGoal negativeGoal = new NegativeGoal(attributes[0], attributes[1], attributes[2]);
                        _goals.Add(negativeGoal);
                        break;
                    default:
                        continue;
                }
            }

        }


    }
}