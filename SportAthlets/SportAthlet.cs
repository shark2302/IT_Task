using System;

namespace SportAthlets
{
    public class SportAthlet
    {
        private string _name;

        private int _competitionCount;
        
        private int _points;
        
        public SportAthlet(string name, int competitionCount, int points)
        {
            _name = name;
            if (competitionCount < 0)
            {
                Console.WriteLine("Count must be > 0");
                competitionCount = 0;
            }

            if (points < 0)
            {
                Console.WriteLine("Points must be > 0");
                points = 0;
            }
            _competitionCount = competitionCount;
            _points = points;
        }

        protected virtual double CountQuality()
        {
            return _points  > 0 ? (double) _competitionCount / _points : 0;
        }

        public string GetInfoInString()
        {
            return "Name: " + _name + "\nCompetionCount: " + _competitionCount +
                   "\nPoints: " + _points + "\nQuality: " + CountQuality();
        }
    }
}