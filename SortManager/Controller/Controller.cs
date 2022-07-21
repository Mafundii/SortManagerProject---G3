namespace SortManagerApp
{
    public class Controller
    {
        //Main menu:  select sorting algorithm or quit
        //if invalid input:  "invalid input" -> Main menu
        //if valid input:  select number of items in array
        //if invalid number:  "invalid input" -> select number of items in array
        //if valid number:  generate array, stopwatch and run sorting algorithm, return array -> Main
        private int _sortMethod;

        public string MainMenu(string input)
        {
            if (Int32.TryParse(input, out int num))
            {
                switch (num)
                {
                    case 1:
                        _sortMethod = 1;
                        break;
                    case 2:
                        _sortMethod = 2;
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}