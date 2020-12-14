using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace gh_test_internal
{
    public class gh_test_internalInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "ghtestinternal";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("35dc121c-6882-4f70-b6c4-739761d0c455");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
