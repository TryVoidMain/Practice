using Patterns;

namespace TestPatterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var product = Builder();

            foreach (var item in product.GetParts())
            {
                Console.WriteLine(item);
            }

        }
          
        private static Product Builder()
        {
            var concreteBuilder = new ConcreteBuilder();
            
            var director = new Director(concreteBuilder);
            director.ConstructBAC();

            return concreteBuilder.Build();
        }
    }
}