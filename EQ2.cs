// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System.Collections.Generic;
using System.Globalization;
using LavishScriptAPI;
using EQ2.ISXEQ2.Extensions;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes miscellaneous data that is available to ISXEQ2 that does not fit into any other ISXEQ2 DataType
    /// </summary>
    public class EQ2 : LavishScriptObject
    {

        #region Constructor
        public EQ2()
            :
            base(LavishScript.Objects.GetObject("EQ2"))
        {
        }

        public EQ2(LavishScriptObject copy)
            :
            base(copy)
        {
        }
        #endregion

        /// <summary>
        /// Returns the name of the server. This is only available when in the game proper.
        /// </summary>
        public string ServerName
        {
            get
            {
                return this.GetStringFromLSO("ServerName");
            }
        }

        /// <summary>
        /// Returns the size of the custom actor array.
        /// </summary>
        public int CustomActorArraySize
        {
            get { return this.GetIntFromLSO("CustomActorArraySize"); }
        }

        /// <summary>
        /// Returns an integer indicating the zoning status of the character. -1 = unsure, 0 = not zoning, 1 = zoning
        /// </summary>
        public int Zoning
        {
            get
            {
                return this.GetIntFromLSO("Zoning");
            }
        }

        /// <summary>
        /// Returns a boolean indicating whether or not the Heroic Opportunity window is active
        /// </summary>
        public bool HOWindowActive
        {
            get
            {
                return this.GetBoolFromLSO("HOWindowActive");
            }
        }

        /// <summary>
        /// Returns the name of the Heroic Opportunity
        /// </summary>
        public string HoName
        {
            get
            {
                return this.GetStringFromLSO("HOName");
            }
        }

        /// <summary>
        /// Returns the description of the Heroic Opportunity
        /// </summary>
        public string HODescription
        {
            get
            {
                return this.GetStringFromLSO("HODescription");
            }
        }

        /// <summary>
        /// Returns the ID# of the wheel
        /// </summary>
        public int HOWheelID
        {
            get
            {
                return this.GetIntFromLSO("HOWheelID");
            }
        }

        /// <summary>
        /// Current state of the Heroic Opportunity window
        /// </summary>
        public int HOWindowState
        {
            get
            {
                return this.GetIntFromLSO("HOWindowState");
            }
        }

        /// <summary>
        /// Returns the total time allowed for the cuurent Heroic Opportunity
        /// </summary>
        public float HOTimeLimit
        {
            get
            {
                return this.GetFloatFromLSO("HOTimeLimit");
            }
        }

        /// <summary>
        /// Returns the total time elapsed on the current Heroic Opportunity
        /// </summary>
        public float HOTimeElapsed
        {
            get
            {
                return this.GetFloatFromLSO("HOTimeElapsed");
            }
        }

        /// <summary>
        /// Returns the time remaining on the current Heroic Opportunity
        /// </summary>
        public float HOTimeRemaining
        {
            get
            {
                return this.GetFloatFromLSO("HOTimeRemaining");
            }
        }

        /// <summary>
        /// Returns the last actor to initialize/manipulate the Heroic Opportunity window/wheel
        /// </summary>
        public Actor HOLastManipulator
        {
            get
            {
                return this.GetActorFromLSO("HOLastManipulator");
            }
        }

        /// <summary>
        /// Returns the last known active Heroic Opportunity wheel slot
        /// </summary>
        public int HOCurrentWheelSlot
        {
            get
            {
                return this.GetIntFromLSO("HOCurrentWheelSlot");
            }
        }

        /// <summary>
        /// Returns the last known state of the Heroic Opportunity wheel
        /// </summary>
        public int HOWheelState
        {
            get
            {
                return this.GetIntFromLSO("HOWheelState");
            }
        }

        /// <summary>
        /// Returns the IconID of slot 1
        /// </summary>
        public int HOIconID1
        {
            get
            {
                return this.GetIntFromLSO("HOIconID1");
            }
        }

        /// <summary>
        /// Returns the IconID of slot 2
        /// </summary>
        public int HOIconID2
        {
            get
            {
                return this.GetIntFromLSO("HOIconID2");
            }
        }

        /// <summary>
        /// Returns the IconID of slot 3
        /// </summary>
        public int HOIconID3
        {
            get
            {
                return this.GetIntFromLSO("HOIconID3");
            }
        }

        /// <summary>
        /// Returns the IconID of slot 4
        /// </summary>
        public int HOIconID4
        {
            get
            {
                return this.GetIntFromLSO("HOIconID4");
            }
        }

        /// <summary>
        /// Returns the IconID of slot 5
        /// </summary>
        public int HOIconID5
        {
            get
            {
                return this.GetIntFromLSO("HOIconID5");
            }
        }

        /// <summary>
        /// Returns the IconID of slot 6
        /// </summary>
        public int HOIconID6
        {
            get
            {
                return this.GetIntFromLSO("HOIconID6");
            }
        }

        /// <summary>
        /// Returns the number of active radars
        /// </summary>
        public int NumRadars
        {
            get
            {
                return this.GetIntFromLSO("NumRadars");
            }
        }

        /// <summary>
        /// Returns the current master volume as a percentage
        /// </summary>
        public float MasterVolume
        {
            get
            {
                return this.GetFloatFromLSO("MasterVolume");
            }
        }

        /// <summary>
        /// Returns the name of the quest currently being offered.
        /// Returns "none" if no quest is currently being offered.
        /// </summary>
        public string PendingQuestName
        {
            get
            {
                return this.GetStringFromLSO("PendingQuestName");
            }
        }

        /// <summary>
        /// Returns the description of the quest currently being offered
        /// </summary>
        public string PendingQuestDescription
        {
            get
            {
                return this.GetStringFromLSO("PendingQuestDescription");
            }
        }

        /// <summary>
        /// Returns the number of mail items in the character's inbox.
        /// The mailbox must have been opened at least once.
        /// </summary>
        public int InboxMailCount
        {
            get
            {
                return this.GetIntFromLSO("InboxMailCount");
            }
        }


        public bool RewardPending
        {
            get
            {
                return this.GetBoolFromLSO("RewardPending");
            }
        }

        /// <summary>
        /// Returns a boolean stating whether or not two points (1 and 2) have Line of Sight.
        /// Please note that this checks a direct line between two points for a collision.
        /// This is subject to false positives or negativesdue to railings (seeing between the rails,
        /// false negative) or staircases (top to bottom, false positive).
        /// </summary>
        /// <param name="x1">x-coordinate of 1</param>
        /// <param name="y1">y-coordinate of 1</param>
        /// <param name="z1">z-coordinate of 1</param>
        /// <param name="x2">x-coordinate of 2</param>
        /// <param name="y2">y-coordinate of 2</param>
        /// <param name="z2">z-coordinate of 2</param>
        /// <returns></returns>
        public bool CheckCollision(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            return this.GetBoolFromLSO("CheckCollision",
                x1.ToString(CultureInfo.InvariantCulture), y1.ToString(CultureInfo.InvariantCulture), z1.ToString(CultureInfo.InvariantCulture),
                x2.ToString(CultureInfo.InvariantCulture), y2.ToString(CultureInfo.InvariantCulture), z2.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns the true heading from the "from" point (1) to the "to" point (2).
        /// </summary>
        /// <param name="fromX">x-coordinate of 1</param>
        /// <param name="fromY">y-coordinate of 1</param>
        /// <param name="fromZ">z-coordinate of 1</param>
        /// <param name="toX">x-coordinate of 2</param>
        /// <param name="toY">y-coordinate of 2</param>
        /// <param name="toZ">z-coordinate of 2</param>
        /// <returns></returns>
        public float HeadingTo(float fromX, float fromY, float fromZ, float toX, float toY, float toZ)
        {
            return this.GetFloatFromLSO("HeadingTo",
                fromX.ToString(CultureInfo.InvariantCulture), fromY.ToString(CultureInfo.InvariantCulture), fromZ.ToString(CultureInfo.InvariantCulture),
                toX.ToString(CultureInfo.InvariantCulture), toY.ToString(CultureInfo.InvariantCulture), toZ.ToString(CultureInfo.InvariantCulture));
        }


        public List<Actor> GetActors()
        {
            return Util.GetListFromMethod<Actor>(this, "GetActors", "actor");

            //LavishScriptObject Index = LavishScript.Objects.NewObject("index:actor");

            //int Count = GetMember<int>("GetActors", Index.GetLSReference());
            //List<Actor> List = new List<Actor>(Count);

            //for (int i = 1; i < Count; i++)
            //{
            //    List.Add(new Actor(Index.GetIndex(i.ToString())));
            //}

            //return List;
        }

// ReSharper disable MethodOverloadWithOptionalParameter
        public List<Actor> GetActors(params string[] args)
// ReSharper restore MethodOverloadWithOptionalParameter
        {
            return Util.GetListFromMethod<Actor>(this, "GetActors", "actor", args);
            //LavishScriptObject Index = LavishScript.Objects.NewObject("index:actor");

            //string[] allargs = new string[Args.Length + 1];

            //allargs[0] = Index.GetLSReference();
            //for (int i = 0; i < Args.Length; i++)
            //{
            //    allargs[i + 1] = Args[i];
            //}

            //int Count = GetMember<int>("GetActors", allargs);
            //List<Actor> List = new List<Actor>(Count);

            //for (int i = 1; i < Count; i++)
            //{
            //    List.Add(new Actor(Index.GetIndex(i.ToString())));
            //}

            //return List;
        }

        /// <summary>
        /// Creates an array of actors based on the sort criteria submitted
        /// </summary>
        /// <param name="args">sort method, radius, type</param>
        public void CreateCustomActorArray(params string[] args)
        {
            ExecuteMethod("CreateCustomActorArray", args);
        }

        /// <summary>
        /// Sets the master sound volume
        /// </summary>
        /// <param name="volPct">float value between 0 and 100</param>
        public void SetMasterVolume(float volPct)
        {
            ExecuteMethod("SetMasterVolume", volPct.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Accepts the pending quest
        /// </summary>
        public void AcceptPendingQuest()
        {
            ExecuteMethod("AcceptPendingQuest");
        }

        /// <summary>
        /// Declines the pending quest
        /// </summary>
        public void DeclinePendingQuest()
        {
            ExecuteMethod("DeclinePendingQuest");
        }

        /// <summary>
        /// Sets the ambient light to the requested amount
        /// </summary>
        /// <param name="ambientPct">float value between 0 and 100</param>
        public void SetAmbientLight(float ambientPct)
        {
            ExecuteMethod("SetAmbientLight", ambientPct.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Accepts the current reward
        /// </summary>
        public void AcceptReward()
        {
            ExecuteMethod("AcceptReward");
        }

        /// <summary>
        /// Confirms the highlighted teleporter destination
        /// </summary>
        public void ConfirmZoneTeleporterDestination()
        {
            ExecuteMethod("ConfirmZoneTeleporterDestination");
        }

        /// <summary>
        /// Toggles the onscreen announcment that combat xp is disabled (if it is disabled)
        /// </summary>
        public void ShowAllOnScreenAnnouncements()
        {
            ExecuteMethod("ShowAllOnScreenAnnouncements");
        }

        /// <summary>
        /// Returns the Persistent Zone ID for a given zone name
        /// </summary>
        /// <param name="zoneName">The zone name</param>
        /// <returns></returns>
        public uint PersistentZoneID(string zoneName)
        {
            return GetMember<uint>("PersistentZoneID", zoneName);
        }


    }
}
