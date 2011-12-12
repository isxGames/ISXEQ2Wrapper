// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class ISXEQ2 : LavishScriptObject
    {
        public ISXEQ2(LavishScriptObject Copy)
            : base(Copy)
        {
        }

        public ISXEQ2()
            : base(LavishScript.Objects.GetObject("ISXEQ2"))
        {
        }

        public string Version
        {
            get
            {
                return GetMember<string>("Version");
            }
        }

        public bool IsReady
        {
            get
            {
                return GetMember<bool>("IsReady");
            }
        }

        public int EQ2LocsCount
        {
            get
            {
                return GetMember<int>("EQ2LocsCount");
            }
        }

        public int EQ2LocsCountAllZones
        {
            get
            {
                return GetMember<int>("EQ2LocsCount", "AllZones");
            }
        }

        public bool InitializingActorEffects
        {
            get
            {
                return GetMember<bool>("InitializingActorEffects");
            }
        }

        public bool AfflictionEventsOn
        {
            get
            {
                return GetMember<bool>("AfflictionEventsOn");
            }
        }




        public bool IsValidEQ2PressKey(string KeyName)
        {
            return GetMember<bool>("IsValidEQ2PressKey",KeyName);
        }

        public void SetActorEventsRange(float Range)
        {
            ExecuteMethod("SetActorEventsRange",Range.ToString());
        }

        public enum BenefitToggle
        {
            enable,
            disable
        }

        public void EnduringBreath(BenefitToggle Benefits)
        {
            ExecuteMethod("EnduringBreath", Benefits.ToString());
        }

        public void SafeFall(BenefitToggle Benefits)
        {
            ExecuteMethod("EnduringBreath", Benefits.ToString());
        }

        public void NoFog(BenefitToggle Benefits)
        {
            ExecuteMethod("NoFog", Benefits.ToString());
        }

        public void SetActorEventsTimeInterval(float Time)
        {
            ExecuteMethod("SetActorEventsTimeInterval", Time.ToString());
        }

        public void ResetInternalVendingSystem()
        {
            ExecuteMethod("ResetInternalVendingSystem");
        }

        public void AddLoc(string Label)
        {
            ExecuteMethod("AddLoc", Label);
        }

        public void AddLoc(string Label, string Notes)
        {
            ExecuteMethod("AddLoc", Label, Notes);
        }

        public void Popup(params string[] Args)
        {
            ExecuteMethod("Popup", Args);
        }

        public void EnableAfflictionEvents()
        {
            ExecuteMethod("EnableAfflictionEvents");
        }

        public void DisableAfflictionEvents()
        {
            ExecuteMethod("DisableAfflictionEvents");
        }

        public void SetAfflictionEventsTimeInterval(int Milliseconds)
        {
            ExecuteMethod("SetAfflictionEventsTimeInterval", Milliseconds.ToString());
        }

        public void EnableActorEvents()
        {
            ExecuteMethod("EnableActorEvents");
        }

        public void DisableActorEvents()
        {
            ExecuteMethod("DisableActorEvents");
        }

    }
}
