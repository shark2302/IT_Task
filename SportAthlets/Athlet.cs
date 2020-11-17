namespace SportAthlets
{
    public class Athlet : SportAthlet
    {

        private bool _isFirstPlaceTaked;
        public Athlet(string name, int competitionCount, int points, bool isFirstPlaceTaked) : base(name, competitionCount, points)
        {
            _isFirstPlaceTaked = isFirstPlaceTaked;
        }

        protected override double CountQuality()
        {
            var quality = base.CountQuality();
            return _isFirstPlaceTaked ? quality * 1.5f : quality;
        }
    }
}