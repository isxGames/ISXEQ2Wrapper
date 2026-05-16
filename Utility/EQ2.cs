using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.CharacterActor;
using EQ2.ISXEQ2.Helpers;
using LavishScriptAPI;

namespace EQ2.ISXEQ2.Utility
{
    /// <summary>
    /// This DataType includes miscellaneous data that is available to ISXEQ2 that does not fit into any other ISXEQ2 DataType
    /// </summary>
    public class EQ2 : LavishScriptObject
    {

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public EQ2() : base(LavishScript.Objects.GetObject("EQ2")) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public EQ2(LavishScriptObject copy) : base(copy) { }

        #endregion

        #region Members

        /// <summary>
        /// Returns the localized name for the supplied ability tier (0-12). Returns
        /// empty when 'tier' is greater than 12.
        /// </summary>
        /// <param name="tier">ability tier (0-12)</param>
        /// <returns>tier name string</returns>
        public string AbilityTierString(int tier)
        {
            Trace.WriteLine(String.Format("EQ2:AbilityTierString({0})", tier.ToString(CultureInfo.InvariantCulture)));
            return this.GetStringFromLSO("AbilityTierString", tier.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns the account roster character at the given index (1 to
        /// <see cref="AccountRosterCount"/>).
        /// </summary>
        /// <param name="index">roster index (1-based)</param>
        /// <returns>AccountRosterRecord</returns>
        public AccountRosterRecord AccountRoster(int index)
        {
            Trace.WriteLine(String.Format("EQ2:AccountRoster({0})", index.ToString(CultureInfo.InvariantCulture)));
            return new AccountRosterRecord(this.GetMember("AccountRoster", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns the number of characters on the account roster.
        /// </summary>
        public ulong AccountRosterCount
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:AccountRosterCount"));
                return this.GetUInt64FromLSO("AccountRosterCount");
            }
        }

        /// <summary>
        /// Returns TRUE if the client is currently at the character-select screen
        /// </summary>
        public bool AtCharSelect
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:AtCharSelect"));
                return this.GetBoolFromLSO("AtCharSelect");
            }
        }

        /// <summary>
        /// Returns the unique ID of the currently-logged-in character.
        /// </summary>
        public ulong CharacterID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:CharacterID"));
                return this.GetUInt64FromLSO("CharacterID");
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
        public bool CheckCollision(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            Trace.WriteLine(String.Format("EQ2:CheckCollision({0}, {1}, {2}, {3}, {4}, {5})",
                x1.ToString(CultureInfo.InvariantCulture), y1.ToString(CultureInfo.InvariantCulture), z1.ToString(CultureInfo.InvariantCulture),
                x2.ToString(CultureInfo.InvariantCulture), y2.ToString(CultureInfo.InvariantCulture), z2.ToString(CultureInfo.InvariantCulture)));
            return this.GetBoolFromLSO("CheckCollision",
                x1.ToString(CultureInfo.InvariantCulture), y1.ToString(CultureInfo.InvariantCulture), z1.ToString(CultureInfo.InvariantCulture),
                x2.ToString(CultureInfo.InvariantCulture), y2.ToString(CultureInfo.InvariantCulture), z2.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns the size of the custom actor array.
        /// </summary>
        public int CustomActorArraySize
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:CustomActorArraySize"));
                return this.GetIntFromLSO("CustomActorArraySize");
            }
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
        public float HeadingTo(float fromX, float fromY, float fromZ, float toX, float toY, float toZ)
        {
            Trace.WriteLine(String.Format("EQ2:HeadingTo({0}, {1}, {2}, {3}, {4}, {5})",
                fromX.ToString(CultureInfo.InvariantCulture), fromY.ToString(CultureInfo.InvariantCulture), fromZ.ToString(CultureInfo.InvariantCulture),
                toX.ToString(CultureInfo.InvariantCulture), toY.ToString(CultureInfo.InvariantCulture), toZ.ToString(CultureInfo.InvariantCulture)));
            return this.GetFloatFromLSO("HeadingTo",
                fromX.ToString(CultureInfo.InvariantCulture), fromY.ToString(CultureInfo.InvariantCulture), fromZ.ToString(CultureInfo.InvariantCulture),
                toX.ToString(CultureInfo.InvariantCulture), toY.ToString(CultureInfo.InvariantCulture), toZ.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Returns the last known active Heroic Opportunity wheel slot
        /// </summary>
        public int HOCurrentWheelSlot
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOCurrentWheelSlot"));
                return this.GetIntFromLSO("HOCurrentWheelSlot");
            }
        }

        /// <summary>
        /// Returns the description of the Heroic Opportunity
        /// </summary>
        public string HODescription
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HODescription"));
                return this.GetStringFromLSO("HODescription");
            }
        }

        /// <summary>
        /// Returns the IconID of slot 1
        /// </summary>
        public int HOIconID1
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOIconID1"));
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
                Trace.WriteLine(String.Format("EQ2:HOIconID2"));
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
                Trace.WriteLine(String.Format("EQ2:HOIconID3"));
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
                Trace.WriteLine(String.Format("EQ2:HOIconID1"));
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
                Trace.WriteLine(String.Format("EQ2:HOIconID5"));
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
                Trace.WriteLine(String.Format("EQ2:HOIconID6"));
                return this.GetIntFromLSO("HOIconID6");
            }
        }

        /// <summary>
        /// Returns the last actor to initialize/manipulate the Heroic Opportunity window/wheel
        /// </summary>
        public Actor HOLastManipulator
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOLastManipulator"));
                return new Actor(this.GetMember("HOLastManipulator"));
            }
        }

        /// <summary>
        /// Returns the name of the Heroic Opportunity
        /// </summary>
        public string HOName
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOName"));
                return this.GetStringFromLSO("HOName");
            }
        }

        /// <summary>
        /// Returns the total time elapsed on the current Heroic Opportunity
        /// </summary>
        public float HOTimeElapsed
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOTimeElapsed"));
                return this.GetFloatFromLSO("HOTimeElapsed");
            }
        }

        /// <summary>
        /// Returns the total time allowed for the cuurent Heroic Opportunity
        /// </summary>
        public float HOTimeLimit
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOTimeLimit"));
                return this.GetFloatFromLSO("HOTimeLimit");
            }
        }

        /// <summary>
        /// Returns the time remaining on the current Heroic Opportunity
        /// </summary>
        public float HOTimeRemaining
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOTimeRemaining"));
                return this.GetFloatFromLSO("HOTimeRemaining");
            }
        }

        /// <summary>
        /// Returns the ID# of the wheel
        /// </summary>
        public int HOWheelID
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOWheelID"));
                return this.GetIntFromLSO("HOWheelID");
            }
        }

        /// <summary>
        /// Returns the last known state of the Heroic Opportunity wheel
        /// </summary>
        public int HOWheelState
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOWheelState"));
                return this.GetIntFromLSO("HOWheelState");
            }
        }

        /// <summary>
        /// Returns a boolean indicating whether or not the Heroic Opportunity window is active
        /// </summary>
        public bool HOWindowActive
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOWindowActive"));
                return this.GetBoolFromLSO("HOWindowActive");
            }
        }

        /// <summary>
        /// Current state of the Heroic Opportunity window
        /// </summary>
        public int HOWindowState
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:HOWindowState"));
                return this.GetIntFromLSO("HOWindowState");
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
                Trace.WriteLine(String.Format("EQ2:InboxMailCount"));
                return this.GetIntFromLSO("InboxMailCount");
            }
        }

        /// <summary>
        /// Returns a string describing the client's current login state. One of:
        /// "Unknown", "At Login", "At Char Select", "In Game", or "Unknown(N)" for
        /// any other underlying state value.
        /// </summary>
        public string LoginState
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:LoginState"));
                return this.GetStringFromLSO("LoginState");
            }
        }

        /// <summary>
        /// Returns the current master volume as a percentage
        /// </summary>
        public float MasterVolume
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:MasterVolume"));
                return this.GetFloatFromLSO("MasterVolume");
            }
        }

        /// <summary>
        /// Returns the number of active radars
        /// </summary>
        public int NumRadars
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:NumRadars"));
                return this.GetIntFromLSO("NumRadars");
            }
        }

        /// <summary>
        /// Returns the object currently being moved/placed in the world via the
        /// moveable-object placement system, or NULL when no such operation is active.
        /// </summary>
        public MoveableObject ObjectBeingMoved
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:ObjectBeingMoved"));
                return new MoveableObject(this.GetMember("ObjectBeingMoved"));
            }
        }

        /// <summary>
        /// Returns the description of the quest currently being offered
        /// </summary>
        public string PendingQuestDescription
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:PendingQuestDescription"));
                return this.GetStringFromLSO("PendingQuestDescription");
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
                Trace.WriteLine(String.Format("EQ2:PendingQuestName"));
                return this.GetStringFromLSO("PendingQuestName");
            }
        }

        /// <summary>
        /// Returns the Persistent Zone ID for a given zone name
        /// </summary>
        /// <param name="zoneName">zone name</param>
        /// <returns>zone id</returns>
        public uint PersistentZoneID(string zoneName)
        {
            Trace.WriteLine(String.Format("EQ2:PersistentZoneID({0})", zoneName));
            return this.GetUIntFromLSO("PersistentZoneID", zoneName);
        }

        /// <summary>
        /// Returns TRUE when an item has been targeted via the inventory window's
        /// 'refine/transmute/salvage' affordance and is therefore ready to act upon.
        /// </summary>
        public bool ReadyToRefineTransmuteOrSalvage
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:ReadyToRefineTransmuteOrSalvage"));
                return this.GetBoolFromLSO("ReadyToRefineTransmuteOrSalvage");
            }
        }

        /// <summary>
        /// Returns the name of the server. This is only available when in the game proper.
        /// </summary>
        public string ServerName
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:ServerName"));
                return this.GetStringFromLSO("ServerName");
            }
        }

        /// <summary>
        /// Returns an integer indicating the zoning status of the character. -1 = unsure, 0 = not zoning, 1 = zoning
        /// </summary>
        public int Zoning
        {
            get
            {
                Trace.WriteLine(String.Format("EQ2:Zoning"));
                return this.GetIntFromLSO("Zoning");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Accepts the pending quest
        /// </summary>
        /// <returns>call success</returns>
        public bool AcceptPendingQuest()
        {
            Trace.WriteLine(String.Format("EQ2:AcceptPendingQuest()"));
            return this.ExecuteMethod("AcceptPendingQuest");
        }

        /// <summary>
        /// Cancels the in-progress moveable-object placement operation, reverting
        /// the object to its prior state. No-op when nothing is being moved.
        /// </summary>
        /// <returns>call success</returns>
        public bool CancelMoveObject()
        {
            Trace.WriteLine(String.Format("EQ2:CancelMoveObject()"));
            return this.ExecuteMethod("CancelMoveObject");
        }

        /// <summary>
        /// Confirms the highlighted teleporter destination.
        /// NOTE: This should be used after selecting the appropriate
        /// destination using the 'HighlightRow' method of the
        /// EQ2UIElement datatype.
        /// </summary>
        /// <returns>call success</returns>
        public bool ConfirmZoneTeleporterDestination()
        {
            Trace.WriteLine(String.Format("EQ2:ConfirmZoneTeleporterDestination"));
            return this.ExecuteMethod("ConfirmZoneTeleporterDestination");
        }

        /// <summary>
        /// Creates an array of actors based on the sort criteria submitted
        /// </summary>
        /// <param name="args">sort method, radius, type</param>
        /// <returns>call success</returns>
        /// <remarks>
        /// Sort Methods:
        /// byDist, byLevel, byType, byName (byDist is defualt)
        /// Type refers to npc, etc.
        /// </remarks>
        public bool CreateCustomActorArray(params string[] args)
        {
            Trace.WriteLine(String.Format("EQ2:CreateCustomActorArray({0})", String.Join(", ", args)));
            return this.ExecuteMethod("CreateCustomActorArray", args);
        }

        /// <summary>
        /// Plays the named sound effect on the client.
        /// </summary>
        /// <param name="effectName">sound-effect name</param>
        /// <returns>call success</returns>
        public bool CreateSoundEffect(string effectName)
        {
            Trace.WriteLine(String.Format("EQ2:CreateSoundEffect({0})", effectName));
            return this.ExecuteMethod("CreateSoundEffect", effectName);
        }

        /// <summary>
        /// Declines the pending quest
        /// </summary>
        /// <returns>call success</returns>
        public bool DeclinePendingQuest()
        {
            Trace.WriteLine(String.Format("EQ2:DeclinePendingQuest()"));
            return this.ExecuteMethod("DeclinePendingQuest");
        }

        /// <summary>
        /// Returns the list of expansion / feature names attached to the current
        /// account (e.g. "Visions of Vetrovia", "Mercenaries", etc.).
        /// </summary>
        /// <returns>Enumerable of feature/expansion names</returns>
        public IEnumerable<string> GetAccountFeatures()
        {
            Trace.WriteLine(String.Format("EQ2:GetAccountFeatures()"));
            return Util.GetListFromMethod<string>(this, "GetAccountFeatures", "string");
        }

        /// <summary>
        /// Gets all actors in range
        /// </summary>
        /// <returns>Enumerable sorted by distance</returns>
        public IEnumerable<Actor> GetActors()
        {
            Trace.WriteLine(String.Format("EQ2:GetActors()"));
            return Util.GetListFromMethod<Actor>(this, "GetActors", "actor");

        }

        /// <summary>
        /// Gets all actors in range that meet the search criteria
        /// </summary>
        /// <param name="args"></param>
        /// <returns>Enumerable</returns>
        /// <remarks>
        /// Search Options:
        /// pc - nearest pc
        /// npc - nearest npc
        /// NamedNPC - nearest named npc
        /// guild, "guild" - nearest actor with that guild tag
        /// pet - nearest pet that is not your own
        /// mypet - your pet, or NULL
        /// tsunit - nearest trade skill unit
        /// resource - nearest resource node
        /// nokillnpc - nearest no kill npc
        /// special - nearest special actor
        /// corpse - nearest corpse
        /// me - me as actor
        /// chest - nearest chest
        /// door - nearest door
        /// level, # - nearest actor of that level
        /// levels, #, # - nearest actor between the two levels given
        /// id, # - returns the actor with the id given
        /// notid, # - excludes the actor with the id given
        /// class, "class" - nearest actor with class given
        /// race, "race" - nearest actor with race given
        /// radius, # - nearest actor within the radius given (you are the center)
        /// radiusr, #, # - nearest actor between the two radii (you are the center)
        /// xzrange, # - nearest actor within the 2 dimmensional range
        /// yrange, # - nearest actor within the supplied y range (vertical)
        /// nopcnear [, #] - nearest actor for which there is no PC within the given radius from it. If no argument is given, then it defaults to a range of 100
        /// loc,#,# [,#] - actor at the location provided X, Z, or X, Z, Y if third parameter provided
        /// "string" - nearest actor with that string in their name
        ///
        /// Implementation note: this method delegates to Util.GetListFromMethod&lt;Actor&gt;,
        /// which creates a transient LavishScript actor index and prepends its
        /// LSReference as argv[0] before invoking the method. This satisfies the
        /// EQ2:GetActors[indexRef, ...filter args...] LavishScript signature — argv[0]
        /// is validated as the index container; argv[1..n] are the filter / query
        /// tokens. Caller-supplied 'args' here become the filter tokens after the
        /// index reference.
        /// </remarks>
        public IEnumerable<Actor> GetActors(params string[] args)
        {
            Trace.WriteLine(String.Format("EQ2:GetActors({0})", String.Join(", ", args)));
            return Util.GetListFromMethod<Actor>(this, "GetActors", "actor", args);
        }

        /// <summary>
        /// Returns a list of Persistent Zones
        /// </summary>
        /// <returns>Enumerable</returns>
        public IEnumerable<string> GetPersistentZones()
        {
            Trace.WriteLine(String.Format("EQ2:GetPersistentZones()"));
            return Util.GetListFromMethod<string>(this, "GetPersistentZones", "string");
        }

        /// <summary>
        /// Opens the Fast Travel window (alias of OpenTravelMapWindow). Both methods
        /// dispatch the same underlying remote command.
        /// </summary>
        /// <returns>call success</returns>
        public bool OpenFastTravelWindow()
        {
            Trace.WriteLine(String.Format("EQ2:OpenFastTravelWindow()"));
            return this.ExecuteMethod("OpenFastTravelWindow");
        }

        /// <summary>
        /// Opens the Travel Map window (alias of OpenFastTravelWindow). Both methods
        /// dispatch the same underlying remote command.
        /// </summary>
        /// <returns>call success</returns>
        public bool OpenTravelMapWindow()
        {
            Trace.WriteLine(String.Format("EQ2:OpenTravelMapWindow()"));
            return this.ExecuteMethod("OpenTravelMapWindow");
        }

        /// <summary>
        /// Commits the in-progress moveable-object placement, locking the object to
        /// its currently-previewed location/heading/scale. No-op when nothing is being
        /// moved.
        /// </summary>
        /// <returns>call success</returns>
        public bool PlaceMoveableObject()
        {
            Trace.WriteLine(String.Format("EQ2:PlaceMoveableObject()"));
            return this.ExecuteMethod("PlaceMoveableObject");
        }

        /// <summary>
        /// Populates the supplied LavishScript actor index with all actors matching
        /// the given query expression. Pass an empty/null query to return all actors.
        /// </summary>
        /// <param name="queryExpr">query expression (e.g. "Type =- \"NPC\" &amp;&amp; Distance &lt;= 50") or empty for all</param>
        /// <returns>Enumerable of matching actors</returns>
        public IEnumerable<Actor> QueryActors(string queryExpr)
        {
            Trace.WriteLine(String.Format("EQ2:QueryActors({0})", queryExpr));
            return Util.GetListFromMethod<Actor>(this, "QueryActors", "actor", queryExpr);
        }

        /// <summary>
        /// Sets the master sound volume
        /// </summary>
        /// <param name="volPct">float value between 0 and 100</param>
        /// <returns>call success</returns>
        public bool SetMasterVolume(float volPct)
        {
            Trace.WriteLine(String.Format("EQ2:SetMasterVolume({0})",
                volPct.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SetMasterVolume", volPct.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Toggles the onscreen announcment that combat xp is disabled (if it is disabled)
        /// </summary>
        public bool ShowAllOnScreenAnnouncements()
        {
            Trace.WriteLine(String.Format("EQ2:ShowAllOnScreenAnnouncements()"));
            return this.ExecuteMethod("ShowAllOnScreenAnnouncements");
        }

        #endregion

    }
}
