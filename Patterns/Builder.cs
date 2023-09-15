namespace Patterns
{
    /// <summary>
    /// Abstract builder. Determines algorithms which constructs result entity Product
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuildPartA(string partA);
        public abstract void BuildPartB(string partB);
        public abstract void BuildPartC(string partC);
        public abstract Product Build();
    }

    /// <summary>
    /// This class provides data, but not constructing them. Functionality of filling 
    /// parts object (part A, part B, part C) with concrete configuration are provided 
    /// to side classes.
    /// </summary>
    public class Product
    {
        List<string> parts = new List<string>(); 
        
        public void Add(string part)
        {
            parts.Add(part);
        }

        public IReadOnlyList<string> GetParts() => parts.AsReadOnly();
    }

    /// <summary>
    /// Concrete builder. Implements abstract builder class
    /// </summary>
    public class ConcreteBuilder : Builder 
    {
        Product product = new Product();

        public override void BuildPartA(string partA)
        {
            product.Add(partA);
        }

        public override void BuildPartB(string partB)
        {
            product.Add(partB);
        }

        public override void BuildPartC(string partC)
        {
            product.Add(partC);
        }

        public override Product Build()
        {
            return product;
        }
    }

    /// <summary>
    /// Class, which methods are responsible to construct concrete realization
    /// in concrete builder.
    /// </summary>
    public class Director
    {
        private Builder _builder;
        public Director(Builder builder)
        {
            _builder = builder;
        }

        public void ConstructBAC()
        {
            _builder.BuildPartB("PartB");
            _builder.BuildPartA("PartA");
            _builder.BuildPartC("PartC");
        }

        public void ConstructBC()
        {
            _builder.BuildPartB("PartB");
            _builder.BuildPartC("PartC");
        }
    }
}
