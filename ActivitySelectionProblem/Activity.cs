using System;
using System.Collections.Generic;
using System.Text;

namespace ActivitySelectionProblem
{
    class Activity
    {
        int StartTime;
        int EndTime;

        public Activity() { }

        public Activity(int startTime, int endTime, int profit) {
            StartTime = startTime;
            EndTime = endTime;
        }

        public int GetActivityStartTime() {
            return StartTime;
        }

        public int GetActivityEndTime() {
            return EndTime;
        }


        public void SetActivityStartTime(int startTime) {
            StartTime = startTime;
        }


        public void SetActivityEndTime(int endTime)
        {
            EndTime = endTime;
        }
        
    }
}
