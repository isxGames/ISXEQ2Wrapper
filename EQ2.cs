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
        public string ServerName
        {
            get
            {
                return GetMember<string>("ServerName");
            }
        }

        public int CustomActorArraySize
        {
            get { return GetMember<int>("CustomActorArraySize"); }
        }

        public bool Zoning
        {
            get
            {
                return GetMember<bool>("Zoning");
            }
        }

        public bool HOWindowActive
        {
            get
            {
                return GetMember<bool>("HoWindowActive");
            }
        }

        public string HoName
        {
            get
            {
                return GetMember<string>("HOName");
            }
        }

        public string HODescription
        {
            get
            {
                return GetMember<string>("HODescription");
            }
        }

        public int HOWheelID
        {
            get
            {
                return GetMember<int>("HOWheelID");
            }
        }

        public int HOWindowState
        {
            get
            {
                return GetMember<int>("HOWindowState");
            }
        }

        public float HOTimeLimit
        {
            get
            {
                return GetMember<float>("HOTimeLimit");
            }
        }

        public float HOTimeElapsed
        {
            get
            {
                return GetMember<float>("HOTimeElapsed");
            }
        }

        public float HOTimeRemaining
        {
            get
            {
                return GetMember<float>("HOTimeRemaining");
            }
        }

        public Actor HOLastManipulator
        {
            get
            {
                LavishScriptObject Obj=GetMember("HoLastManipulator");
                return new Actor(Obj);
            }
        }

        public int HOCurrentWheelSlot
        {
            get
            {
                return GetMember<int>("HOCurrentWheelSlot");
            }
        }

        public int HOWheelState
        {
            get
            {
                return GetMember<int>("HOWheelState");
            }
        }

        public int HOIconID1
        {
            get
            {
                return GetMember<int>("HOIconID1");
            }
        }

        public int HOIconID2
        {
            get
            {
                return GetMember<int>("HOIconID2");
            }
        }

        public int HOIconID3
        {
            get
            {
                return GetMember<int>("HOIconID3");
            }
        }

        public int HOIconID4
        {
            get
            {
                return GetMember<int>("HOIconID4");
            }
        }

        public int HOIconID5
        {
            get
            {
                return GetMember<int>("HOIconID5");
            }
        }

        public int HOIconID6
        {
            get
            {
                return GetMember<int>("HOIconID6");
            }
        }

        public int NumRadars
        {
            get
            {
                return GetMember<int>("NumRadars");
            }
        }

        public float MasterVolume
        {
            get
            {
                return GetMember<float>("MasterVolume");
            }
        }

        public string PendingQuestName
        {
            get
            {
                return GetMember<string>("PendingQuestName");
            }
        }

        public string PendingQuestDescription
        {
            get
            {
                return GetMember<string>("PendingQuestDescription");
            }
        }

        public int InboxMailCount
        {
            get
            {
                return GetMember<int>("InboxMailCount");
            }
        }

        public bool RewardPending
        {
            get
            {
                return GetMember<bool>("RewardPending");
            }
        }

        public bool CheckCollision(float X1, float Y1, float Z1, float X2, float Y2, float Z2)
        {
            return GetMember<bool>("CheckCollision",X1.ToString(),Y1.ToString(),Z1.ToString(),X2.ToString(),Y2.ToString(),Z2.ToString());
        }

        public float HeadingTo(float From_X, float From_Y, float From_Z, float To_X, float To_Y, float To_Z)
        {
            return GetMember<float>("HeadingTo",From_X.ToString(),From_Y.ToString(),From_Z.ToString(),To_X.ToString(),To_Y.ToString(),To_Z.ToString());
        }

        public List<Actor> GetActors()
        {
            LavishScriptObject Index = LavishScript.Objects.NewObject("index:actor");

            int Count = GetMember<int>("GetActors", Index.GetLSReference());
            List<Actor> List = new List<Actor>(Count);

            for (int i = 1; i < Count; i++)
            {
                List.Add(new Actor(Index.GetIndex(i.ToString())));
            }

            return List;
        }

        public List<Actor> GetActors(params string[] Args)
        {
            LavishScriptObject Index = LavishScript.Objects.NewObject("index:actor");

            string[] allargs = new string[Args.Length + 1];

            allargs[0] = Index.GetLSReference();
            for (int i = 0; i < Args.Length; i++)
            {
                allargs[i + 1] = Args[i];
            }

            int Count = GetMember<int>("GetActors", allargs);
            List<Actor> List = new List<Actor>(Count);

            for (int i = 1; i < Count; i++)
            {
                List.Add(new Actor(Index.GetIndex(i.ToString())));
            }

            return List;
        }

        public void CreateCustomActorArray(params string[] Args)
        {
            ExecuteMethod("CreateCustomActorArray", Args);
        }

        public void SetMasterVolume(float VolPct)
        {
            ExecuteMethod("SetMasterVolume", VolPct.ToString());
        }

        public void AcceptPendingQuest()
        {
            ExecuteMethod("AcceptPendingQuest");
        }

        public void DeclinePendingQuest()
        {
            ExecuteMethod("DeclinePendingQuest");
        }

        public void SetAmbientLight(float AmbientPct)
        {
            ExecuteMethod("SetAmbientLight", AmbientPct.ToString());
        }

        public void AcceptReward()
        {
            ExecuteMethod("AcceptReward");
        }

        public void ConfirmZoneTeleporterDestination()
        {
            ExecuteMethod("ConfirmZoneTeleporterDestination");
        }

        public void ShowAllOnScreenAnnouncements()
        {
            ExecuteMethod("ShowAllOnScreenAnnouncements");
        }

    }
}
