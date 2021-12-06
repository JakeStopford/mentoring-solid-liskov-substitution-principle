using System.Linq;

namespace Mentoring.Solid.LiskovSubstitutionPrinciple
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        {
        }
        public override int Calculate() => Numbers.Sum();
    }
}