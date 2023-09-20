namespace NumericAlgorithms.Helpers
{
    public record IntegratedFunction
    {
        public Func<float, float> Function { get; private set; }
        public float XMin { get; private set; }
        public float XMax { get; private set; }
        public float Segment { get => XMax - XMin; }

        public IntegratedFunction(Func<float, float> function, float xMin, float xMax) 
        {
            Function = function;
            XMin = xMin;
            XMax = xMax;
        }
    }
}
