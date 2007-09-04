using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections.Generic;

using InnerSpaceAPI;
using LavishScriptAPI;
using LavishVMAPI;

namespace EQ2.ISXEQ2
{
    public class Extension
    {
        public Extension()
        {
        }

        public EQ2 EQ2()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2");
            return new EQ2(Obj);
        }

        public Character Me()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Me");
            return new Character(Obj);
        }

        public Actor Actor(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Actor", Arg.ToString());
            return new Actor(Obj);
        }

        public Actor Actor(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Actor", Args);
            return new Actor(Obj);
        }

        public Actor CustomActor(int Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("CustomActor", Arg.ToString());
            return new Actor(Obj);
        }

        public Actor CustomActor(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("CustomActor", Args);
            return new Actor(Obj);
        }

        public Actor Target()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Target");
            return new Actor(Obj);
        }

        public Zone Zone()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Zone");
            return new Zone(Obj);
        }

        public void Face()
        {
            LavishScript.ExecuteCommand("Face");
        }

        public void Face(string Args)
        {
            LavishScript.ExecuteCommand("Face " + Args);
        }

        public void Target(string Args)
        {
            LavishScript.ExecuteCommand("Target " + Args);
        }
    }
}