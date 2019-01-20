namespace _12.CompoundPatterns.Geese.Factories
{
    public class GooseFactory : AbstractGooseFactory
    {
        public override Goose CreateGoose()
        {
            return new Goose();
        }
    }
}