using System.Collections.Generic;

namespace NSubstitute.Core
{
    public interface ICallSpecification
    {
        bool IsSatisfiedBy(ICall call);
        string Format(ICallFormatter callFormatter);
        IEnumerable<int> NonMatchingArgumentIndicies(ICall call);
    }
}