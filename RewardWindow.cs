// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class RewardWindow : LavishScriptObject
    {
        public RewardWindow(LavishScriptObject Obj)
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

        public void Receive()
        {
            ExecuteMethod("Receive");
        }

        public void Accept()
        {
            ExecuteMethod("Accept");
        }

        public void Cancel()
        {
            ExecuteMethod("Cancel");
        }

    }
}
