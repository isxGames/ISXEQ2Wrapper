using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class EQ2UIPage : LavishScriptObject
    {
        public EQ2UIPage(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public EQ2UIElement Child(string ElementType, string ElementName)
        {
            LavishScriptObject Obj = GetMember("Child", ElementType, ElementName);
            return new EQ2UIElement(Obj);
        }

        public bool IsVisible
        {
            get
            {
                return GetMember<bool>("IsVisible");
            }
        }

    }
}
