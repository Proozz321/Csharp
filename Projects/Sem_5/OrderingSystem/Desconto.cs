namespace OrderingSystem
{
    public interface IDesconto
    {
        double CalcularDesconto(double totalOriginal);
    }

    public class SemDesc : IDesconto
    {
        public double CalcularDesconto(double totalOriginal) => 0;
    }

    public class DescVip : IDesconto
    {
        public double CalcularDesconto(double totalOriginal) => totalOriginal * 0.15;
    }

    public class DescSazonal : IDesconto
    {
        public double CalcularDesconto(double totalOriginal) => totalOriginal * 0.10;
    }
}