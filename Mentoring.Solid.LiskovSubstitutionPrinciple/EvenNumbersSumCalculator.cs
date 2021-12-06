using System.Linq;

namespace Mentoring.Solid.LiskovSubstitutionPrinciple
{
    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers)
            : base(numbers)
        {
        }
        public override int Calculate() => Numbers.Where(x => x % 2 == 0).Sum();
    }
}