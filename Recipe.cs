// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Recipe : LavishScriptObject
    {
        public Recipe(LavishScriptObject Obj)
            : base(Obj)
        {
        }
/*
        public Recipe()
            : base(LavishScript.Objects.GetObject("Recipe"))
        {
        }
*/
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

        public string Device
        {
            get
            {
                return GetMember<string>("Device");
            }
        }

        public string RecipeBook
        {
            get
            {
                return GetMember<string>("RecipeBook");
            }
        }

        public int Level
        {
            get
            {
                return GetMember<int>("Level");
            }
        }

        public long ID
        {
            get
            {
                return GetMember<long>("ID");
            }
        }

        public string Technique
        {
            get
            {
                return GetMember<string>("Technique");
            }
        }

        public string Knowledge
        {
            get
            {
                return GetMember<string>("Knowledge");
            }
        }

        public int NumClasses
        {
            get
            {
                return GetMember<int>("NumClasses");
            }
        }

        public Class Class(int ClassNum)
        {
            LavishScriptObject Obj = GetMember("Class", ClassNum.ToString());
            return new Class(Obj);
        }

        public string PrimaryComponent
        {
            get
            {
                return GetMember<string>("PrimaryComponent");
            }
        }

        public Component BuildComponent1()
        {
            LavishScriptObject Obj = GetMember("BuildComponent1");
            return new Component(Obj);
        }

        public Component BuildComponent2()
        {
            LavishScriptObject Obj = GetMember("BuildComponent2");
            return new Component(Obj);
        }

        public Component BuildComponent3()
        {
            LavishScriptObject Obj = GetMember("BuildComponent3");
            return new Component(Obj);
        }

        public Component BuildComponent4()
        {
            LavishScriptObject Obj = GetMember("BuildComponent4");
            return new Component(Obj);
        }

        public Component Fuel()
        {
            LavishScriptObject Obj = GetMember("Fuel");
            return new Component(Obj);
        }

        public bool Create()
        {
            return ExecuteMethod("Create");
        }

        public bool Examine()
        {
            return ExecuteMethod("Examine");
        }
    }
}
