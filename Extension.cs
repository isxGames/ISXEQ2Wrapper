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

        public EQ2 EQ2()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2");
            return new EQ2(Obj);
        }

        public EQ2UIElement EQ2DataSourceContainer(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2DataSourceContainer", Args);
            return new EQ2UIElement(Obj);
        }

        public EQ2Location EQ2Loc(int Index, bool AllZones)
        {
            LavishScriptObject Obj;
            if (AllZones)
                Obj = LavishScript.Objects.GetObject("EQ2Loc", Index.ToString(), "AllZones");
            else
                Obj = LavishScript.Objects.GetObject("EQ2Loc", Index.ToString());
            return new EQ2Location(Obj);
        }

        public EQ2Location EQ2Loc(string Label, bool AllZones)
        {
            LavishScriptObject Obj;
            if (AllZones)
                Obj = LavishScript.Objects.GetObject("EQ2Loc", Label, "AllZones");
            else
                Obj = LavishScript.Objects.GetObject("EQ2Loc", Label);
            return new EQ2Location(Obj);
        }

        public EQ2Mail EQ2Mail(int Index)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2Mail", Index.ToString());
            return new EQ2Mail(Obj);
        }

        public enum EQ2MailArgs
        {
            opened,
            composing
        }

        public EQ2Mail EQ2Mail(EQ2MailArgs Arg)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2Mail", Arg.ToString());
            return new EQ2Mail(Obj);
        }

        public EQ2UIPage EQ2UIPage(params string[] Args)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2UIPage", Args);
            return new EQ2UIPage(Obj);
        }

        public ISXEQ2 ISXEQ2()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("ISXEQ2");
            return new ISXEQ2(Obj);
        }

        public LootWindow LootWindow()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("LootWindow");
            return new LootWindow(Obj);
        }

        public Character Me()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Me");
            return new Character(Obj);
        }

        public Radar Radar()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Radar");
            return new Radar(Obj);
        }

        public Radar Radar(int Index)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Radar",Index.ToString());
            return new Radar(Obj);
        }

        public Radar Radar(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Radar",Name);
            return new Radar(Obj);
        }

        public RewardWindow RewardWindow()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("RewardWindow");
            return new RewardWindow(Obj);
        }

        public string StripTags(string Text)
        {
            return LavishScript.Objects.GetObject<string>("StripTags", Text);
        }

        public Actor Target()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Target");
            return new Actor(Obj);
        }

        public Vendor Vendor()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Vendor");
            return new Vendor(Obj);
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

        public void EQ2Execute(string Args)
        {
            LavishScript.ExecuteCommand("EQ2Execute " + Args);
        }
    }
}