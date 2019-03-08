using System;
using System.Collections.Generic;
using System.Text;

namespace Andgasm.Resources.Core
{
    public class AssociatedDeleteStatus
    {
        public int AssociatedId { get; set; }
        public string CanDeleteMessage { get; set; }

        public bool CanDelete
        {
            get
            {
                return string.IsNullOrWhiteSpace(CanDeleteMessage);
            }
        }
    }
}
