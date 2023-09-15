namespace Patterns
{
    public class Singleton
    {
        private static Singleton __instance;

        /// <summary>
        /// Classic realization of Singleton pattern
        /// </summary>    
        private Singleton() { }

        public Singleton GetInstance()
        {
            if (__instance == null)
                __instance = new Singleton();
            
            return __instance;
        }
    }
    
    // TODO: сделать generic реализацию, наподобие DI контейнера
    public class GenericSingleton<T, V> 
        where T : class
        where V : class
    {
        private Dictionary<T, V> _instances = new Dictionary<T,V>();

        public GenericSingleton()
        {

        }

        public void BindInstance(T inputInterface, V classTemplate)
        {
            if (!inputInterface.GetType().IsInterface)
                throw new ArgumentException("Invalid input");


        }

        public V GetInstance(T requestedInterface)
        {
            return _instances[requestedInterface];
        }
    }
}