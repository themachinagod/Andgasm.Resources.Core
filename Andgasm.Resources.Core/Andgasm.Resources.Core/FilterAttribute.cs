using System;

namespace Andgasm.Resources.Core
{
    public class FilterAttribute : Attribute
    {
        public string AlternativeColumntoFilter { get; set; }
    }
}
