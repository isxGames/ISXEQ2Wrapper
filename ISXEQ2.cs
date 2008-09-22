using System;
using System.Collections.Generic;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    public class ISXEQ2 : LavishScriptObject
    {

        public ISXEQ2(LavishScriptObject Obj)
            : base(Obj)
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

        public int EQ2LocsCount(bool AllZones)
        {
            if (AllZones)
                return GetMember<int>("EQ2LocsCount", "AllZones");
            return GetMember<int>("EQ2LocsCount");
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

    }
}
