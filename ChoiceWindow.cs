using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class ChoiceWindow : LavishScriptObject
    {
        public ChoiceWindow(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public EQ2UIPage ToEQ2UIPage
        {
            get
            {
                LavishScriptObject Obj = GetMember("ToEQ2UIPage");
                return new EQ2UIPage(Obj);
            }
        }

        public string Text
        {
            get
            {
                return GetMember<string>("Text");
            }
        }

        public string Choice1
        {
            get
            {
                return GetMember<string>("Choice1");
            }
        }

        public string Choice2
        {
            get
            {
                return GetMember<string>("Choice2");
            }
        }

        public void DoChoice1()
        {
            ExecuteMethod("DoChoice1");
        }

        public void DoChoice2()
        {
            ExecuteMethod("DoChoice2");
        }

    }
}
