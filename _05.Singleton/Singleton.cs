namespace _05.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            
        }

        public static Singleton Instange
        {
            get
            {
                if(_instance == null)
                    _instance = new Singleton();

                return _instance;
            }
        }
    }
}