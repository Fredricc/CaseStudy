namespace Employee
{
    public class Employees : Utility
    {
        //Fields
        private int _id;
        private string _name;
        private string _designation;
        private int _salary;
        private DateTime _dateOfJoining;

        public Employees()
        {
        }

        //Parametrized Constructor
        public Employees(int Id, string Name, string Designation, int Salary, DateTime DateOfJoining)
            {
            this._id = Id;
            this._name = Name;
            this._designation = Designation;
            this._salary = Salary;
            this._dateOfJoining = DateOfJoining;
            }

        //Properties
        public int Id
        {
            set {
                if(value >= 1 && value <= 1000)
                {
                    _id = value;
                }
                else
                {
                    Console.WriteLine("Please enter id with a value between 1 and 1000");
                }
                }
            get { return _id; }
        }

        public string Name
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Employee name");
                }
            }
            get { return _name; }
        }

        public string Designation
        {
            set
            {
                if (value != null)
                {
                    _designation = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Employee name");
                }
            }
            get { return _designation; }
        }

        public int Salary
        {
            set {
                if (value >= 20000 && value <= 300000)
                {
                    _salary = value;
                }
                else
                {
                    Console.WriteLine("Please enter a valid Employee name");
                }
            }
            get { return _salary; }
        }

        public DateTime DateOfJoining
        {
            set {
                if (value <= DateTime.Now)
                {
                    _dateOfJoining = value;
                }
                else if (value > DateTime.Now)
                {
                    Console.WriteLine("Date of Joining cannot be a future date");
                } else
                {
                    Console.WriteLine("Please enter a valid date of joining");
                }
            }
            get { return _dateOfJoining;}
        }
    }
}