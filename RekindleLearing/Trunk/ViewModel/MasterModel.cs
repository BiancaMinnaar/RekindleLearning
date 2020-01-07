using System.Collections.Generic;
using RekindleLearing.Trunk.ViewModel;

namespace RekindleLearing.Root.ViewModel
{
    public sealed class MasterModel
    {
        public bool Authenticated { get; set; }

        public List<CourseViewModel> CourseList { get; set; }
        //#Bonsai Snippets - Properties
    }
}

