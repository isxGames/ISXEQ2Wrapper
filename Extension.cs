// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

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

        public EQ2Location EQ2Loc(int Index)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2Loc", Index.ToString());
            return new EQ2Location(Obj);
        }

        public EQ2Location EQ2LocAllZones(int Index)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2Loc", Index.ToString(), "AllZones");
            return new EQ2Location(Obj);
        }

        public EQ2Location EQ2Loc(string Label)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2Loc", Label);
            return new EQ2Location(Obj);
        }

        public EQ2Location EQ2LocAllZones(string Label)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("EQ2Loc", Label, "AllZones");
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

        public ChoiceWindow ChoiceWindow()
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("ChoiceWindow");
            return new ChoiceWindow(Obj);
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
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Radar", Index.ToString());
            return new Radar(Obj);
        }

        public Radar Radar(string Name)
        {
            LavishScriptObject Obj = LavishScript.Objects.GetObject("Radar", Name);
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

        public void EQ2Press(string Args)
        {
            LavishScript.ExecuteCommand("EQ2Press " + Args);
        }

        public void EQ2Ignore(string Args)
        {
            LavishScript.ExecuteCommand("EQ2Ignore " + Args);
        }

        public void EQ2Announce(string Announcement)
        {
            LavishScript.ExecuteCommand("EQ2Announce \"" + Announcement + "\"");
        }

        public void EQ2Announce(string Announcement, float Time)
        {
            LavishScript.ExecuteCommand("EQ2Announce \"" + Announcement + "\" " + Time.ToString());
        }

        public enum AnnouncementSound
        {
            SkillUp = 1,
            QuestUpdate,
            LevelDing,
            CallForHelp,
            HarvestRare,
            QuestComplete,
            LocationDiscovery,
            SendMailFailed,
            SendMailSuccess
        }

        public void EQ2Announce(string Announcement, float Time, AnnouncementSound Sound)
        {
            LavishScript.ExecuteCommand("EQ2Announce \"" + Announcement + "\" " + Time.ToString() + " " + ((int)Sound).ToString());
        }

        public void EQ2Announce(string Announcement, AnnouncementSound Sound)
        {
            LavishScript.ExecuteCommand("EQ2Announce \"" + Announcement + "\" 4.5 " + ((int)Sound).ToString());
        }

    }
}