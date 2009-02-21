using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class Radar : LavishScriptPersistentObject
    {
        public Radar(LavishScriptPersistentObject Obj)
            : base(Obj)
        {
        }

        public Radar(params string[] Args)
            : base(LavishScript.Objects.GetPersistentObject("Radar", Args))
        {
        }

        public Radar(int Index)
            : base(LavishScript.Objects.GetPersistentObject("Radar", Index.ToString()))
        {
        }

        public Radar()
            : base(LavishScript.Objects.GetPersistentObject("Radar", "1"))
        {
        }

        public bool ShowingMe
        {
            get
            {
                return GetMember<bool>("ShowingMe");
            }
        }

        public bool ShowingNPCs
        {
            get
            {
                return GetMember<bool>("ShowingNPCs");
            }
        }

        public bool ShowingPCs
        {
            get
            {
                return GetMember<bool>("ShowingPCs");
            }
        }

        public bool ShowingSpecials
        {
            get
            {
                return GetMember<bool>("ShowingSpecials");
            }
        }

        public bool ShowingResources
        {
            get
            {
                return GetMember<bool>("ShowingResources");
            }
        }

        public bool ShowingNoKillNPCs
        {
            get
            {
                return GetMember<bool>("ShowingNoKillNPCs");
            }
        }

        public bool ShowingCorpses
        {
            get
            {
                return GetMember<bool>("ShowingCorpses");
            }
        }

        public int NumCustomFilters
        {
            get
            {
                return GetMember<int>("NumCustomFilters");
            }
        }

        public bool IsCustomFilter(string Text)
        {
            return GetMember<bool>("CustomFilter", Text);
        }

        public string CustomFilter(int Index)
        {
            return GetMember<string>("CustomFilter", Index.ToString());
        }

        public string CustomFiltersList
        {
            get
            {
                return GetMember<string>("CustomFiltersList");
            }
        }

        public bool ShowingLabels
        {
            get
            {
                return GetMember<bool>("ShowingLabels");
            }
        }

        public int Size
        {
            get
            {
                return GetMember<int>("Size");
            }
        }

        public bool YAxisClippingOn
        {
            get
            {
                return GetMember<bool>("YAxisClippingOn");
            }
        }

        public bool ClipRadiusOn
        {
            get
            {
                return GetMember<bool>("ClipRadiusOn");
            }
        }

        public bool ClippingTextOn
        {
            get
            {
                return GetMember<bool>("ClippingTextOn");
            }
        }

        public bool RotationOn
        {
            get
            {
                return GetMember<bool>("RotationOn");
            }
        }

        public string Name
        {
            get
            {
                return GetMember<string>("Name");
            }
        }

        public bool ShowingTSUnits
        {
            get
            {
                return GetMember<bool>("ShowingTSUnits");
            }
        }

        public bool ShowingAggroNPCs
        {
            get
            {
                return GetMember<bool>("ShowingAggroNPCs");
            }
        }

        public bool ShowingNamedNPCs
        {
            get
            {
                return GetMember<bool>("ShowingNamedNPCs");
            }
        }

        public bool ShowingPets
        {
            get
            {
                return GetMember<bool>("ShowingPets");
            }
        }

        public bool ShowingMyPet
        {
            get
            {
                return GetMember<bool>("ShowingMyPet");
            }
        }

        public bool ShowingChests
        {
            get
            {
                return GetMember<bool>("ShowingChests");
            }
        }

        public bool ShowingDoors
        {
            get
            {
                return GetMember<bool>("ShowingDoors");
            }
        }

        public void FilterMe()
        {
            ExecuteMethod("FilterMe");
        }

        public void FilterNPCs()
        {
            ExecuteMethod("FilterNPCs");
        }

        public void FilterPCs()
        {
            ExecuteMethod("FilterPCs");
        }

        public void FilterSpecials()
        {
            ExecuteMethod("FilterSpecials");
        }

        public void FilterResources()
        {
            ExecuteMethod("FilterResources");
        }

        public void FilterNoKillNPCs()
        {
            ExecuteMethod("FilterNoKillNPCs");
        }

        public void FilterCorpses()
        {
            ExecuteMethod("FilterCorpses");
        }

        public void SetSize(int NewSize)
        {
            ExecuteMethod("SetSize", NewSize.ToString());
        }

        public void ShowLabels()
        {
            ExecuteMethod("ShowLabels");
        }

        public void YAxisClipping()
        {
            ExecuteMethod("YAxisClipping");
        }

        public void ClipText()
        {
            ExecuteMethod("ClipText");
        }

        public void ClipRadius()
        {
            ExecuteMethod("ClipRadius");
        }

        public void Rotation()
        {
            ExecuteMethod("Rotation");
        }

        public void SetCustomFilter(string Filter)
        {
            ExecuteMethod("SetCustomFilter", Filter);
        }

        public void FilterTSUnits()
        {
            ExecuteMethod("FilterTSUnits");
        }

        public void FilterAggroNPCs()
        {
            ExecuteMethod("FilterAggroNPCs");
        }

        public void FilterNamedNPCs()
        {
            ExecuteMethod("FilterNamedNPCs");
        }

        public void FilterPets()
        {
            ExecuteMethod("FilterPets");
        }

        public void FilterMyPet()
        {
            ExecuteMethod("FilterMyPet");
        }

        public void FilterChests()
        {
            ExecuteMethod("FilterChests");
        }

        public void FilterDoors()
        {
            ExecuteMethod("FilterDoors");
        }

    }
}
