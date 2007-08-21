using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;
using LavishVMAPI;

namespace EQ2.ISXEQ2
{
    public class EQ2 : LavishScriptObject
    {
        public EQ2()
            :
            base(LavishScript.Objects.GetObject("EQ2"))
        {
        }

        public EQ2(LavishScriptObject Copy)
            :
            base(Copy)
        {
        }

        public void CreateCustomActorArray(params string[] Args)
        {
            ExecuteMethod("CreateCustomActorArray", Args);
        }

        public int CustomActorArraySize
        {
            get { return GetMember<int>("CustomActorArraySize"); }
        }
    }
}
