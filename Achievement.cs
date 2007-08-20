using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Achievement : LavishScriptObject
    {
        public Achievement(LavishScriptObject Obj)
            : base(Obj)
        {
        }

        public Achievement()
            : base(LavishScript.Objects.GetObject("Achievement"))
        {
        }

        public int ID
        {
            get
            {
                return GetMember<int>("ID");
            }
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public string Description
        {
            get
            {
                return GetMember<string>("Description");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public int MaxLevel
        {
            get
            {
                return GetMember<int>("MaxLevel");
            }
        }

        public int PointCostPerLevel
        {
            get
            {
                return GetMember<int>("PointCostPerLevel");
            }
        }

        public int ReqLevelToBuy
        {
            get
            {
                return GetMember<int>("ReqLevelToBuy");
            }
        }

        public Ability ToAbility()
        {
            LavishScriptObject Obj = GetMember("ToAbility");
            return new Ability(Obj);
        }

        public bool Examine()
        {
            return ExecuteMethod("Examine");
        }

    }
}
