using System;

namespace ActivitySelectionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Activity Selection Problem!");
            Console.WriteLine("---------------------------");

            Activity[] activities = GetActivities();
            PrintMaxActivitiesByAPerson(activities);

            Console.ReadLine();
        }

        private static Activity[] GetActivities()
        {
            Activity[] activities = null;

            Console.WriteLine("Enter the number of activities");
            try
            {
                int noActivities = int.Parse(Console.ReadLine());
                activities = new Activity[noActivities];
                for (int index = 0; index < noActivities; index++) {
                    Console.WriteLine("Enter the start-time, end-time " +
                        "separated by space");
                    String[] allElements = Console.ReadLine().Split(' ');
                    activities[index] = new Activity();
                    activities[index].SetActivityStartTime(int.Parse(allElements[0]));
                    activities[index].SetActivityEndTime(int.Parse(allElements[1]));
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Thrown exception is " + exception.Message);
            }

            return activities;
        }

        private static void PrintMaxActivitiesByAPerson(Activity[] activities) {
            Console.WriteLine("Chosen Activity 0:"+activities[0].GetActivityStartTime()
                +"->"+activities[0].GetActivityEndTime());

            int formerActivity = 0;

            for (int index = 1; index < activities.Length; index++) {
                if (activities[index].GetActivityStartTime() >=
                        activities[formerActivity].GetActivityEndTime()) {
                    formerActivity = index;
                    Console.WriteLine("Chosen Activity " + index +
                        ":" + activities[index].GetActivityStartTime() + "->" +
                        activities[index].GetActivityEndTime());
                }
            }
        }
    }
}
