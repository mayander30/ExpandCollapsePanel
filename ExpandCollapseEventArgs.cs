using System;

namespace pControlsDev.Headers
{
    public class ExpandCollapseEventArgs : EventArgs
    {
        public bool IsExpanded { get; private set; }

        public ExpandCollapseEventArgs(bool isExpanded)
        {
            IsExpanded = isExpanded;
        }
    }
}
