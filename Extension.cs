using System;
using System.Diagnostics;
using System.Globalization;
using EQ2.ISXEQ2.AbilityEffect;
using EQ2.ISXEQ2.CharacterActor;
using EQ2.ISXEQ2.InventoryConsignment;
using EQ2.ISXEQ2.Recipe;
using EQ2.ISXEQ2.UI;
using EQ2.ISXEQ2.Utility;
using InnerSpaceAPI;
using LavishScriptAPI;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This class is used to access all of the features of ISXEQ2.
    /// </summary>
    public static class Extension
    {

        #region Top Level Objects

        /// <summary>
        /// Allows interaction with Achievements. Accepts the arguments from EQ2_ExamineAchievment Event.
        /// </summary>
        /// <param name="type">achievement type</param>
        /// <param name="id">achievement id</param>
        /// <returns>Achievement</returns>
        public static Achievement Achievement(string type, int id)
        {
            Trace.WriteLine(String.Format("Extension:Achievement({0}, {1})", type, id.ToString(CultureInfo.InvariantCulture)));
            return new Achievement(LavishScript.Objects.GetObject("Achievement", type, id.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the actor by id.
        /// </summary>
        /// <param name="id">actor id</param>
        /// <returns>Actor</returns>       
        public static Actor Actor(int id)
        {
            Trace.WriteLine(String.Format("Extension:Actor({0})", id.ToString(CultureInfo.InvariantCulture)));
            return new Actor(LavishScript.Objects.GetObject("Actor", id.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the actor by search criteria.
        /// </summary>
        /// <param name="search">search criteria</param>
        /// <returns>Actor</returns>
        /// /// <remarks>
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
        /// </remarks>
        public static Actor Actor(params string[] search)
        {
            Trace.WriteLine(String.Format("Extension:Actor({0})", String.Join(", ", search)));
            return new Actor(LavishScript.Objects.GetObject("Actor", search));
        }

        /// <summary>
        /// Retrieves the Beastlord window when one is currently open, otherwise NULL.
        /// </summary>
        public static BeastlordWindow BeastlordWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:BeastlordWindow"));
                return new BeastlordWindow(LavishScript.Objects.GetObject("BeastlordWindow"));
            }
        }

        /// <summary>
        /// Retrieves the Broker window (eq2brokerwindow / eq2marketwindow) when one is
        /// currently open, otherwise NULL.
        /// </summary>
        public static BrokerWindow BrokerWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:BrokerWindow"));
                return new BrokerWindow(LavishScript.Objects.GetObject("BrokerWindow"));
            }
        }

        /// <summary>
        /// Retrieves the Channeler window when one is currently open, otherwise NULL.
        /// </summary>
        public static ChannelerWindow ChannelerWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:ChannelerWindow"));
                return new ChannelerWindow(LavishScript.Objects.GetObject("ChannelerWindow"));
            }
        }

        /// <summary>
        /// Retrieves a choice window object from the game world. This TLO returns the last choice window opened
        ///  or the only one, if you only have one choice window up.
        /// (If you have no choice windows up, then it returns NULL)
        /// </summary>
        public static ChoiceWindow ChoiceWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:ChoiceWindow"));
                return new ChoiceWindow(LavishScript.Objects.GetObject("ChoiceWindow"));
            }
        }

        /// <summary>
        /// Retrieves the last container window opened (or the only one, if you only
        /// have one container window up), or the container window matching a specific
        /// ID as supplied by the EQ2_onContainerWindowAppeared event. Returns NULL when
        /// no container window is open.
        /// </summary>
        /// <param name="windowID">window id (0 = latest)</param>
        public static ContainerWindow ContainerWindow(int windowID = 0)
        {
            Trace.WriteLine((windowID == 0) ? String.Format("Extension:ContainerWindow()")
                : String.Format("Extension:ContainerWindow({0})", windowID.ToString(CultureInfo.InvariantCulture)));
            return windowID == 0
                ? new ContainerWindow(LavishScript.Objects.GetObject("ContainerWindow"))
                : new ContainerWindow(LavishScript.Objects.GetObject("ContainerWindow",
                    windowID.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the Crafting TLO, exposing the live state of the in-progress
        /// crafting reaction (Quality, Progress, Durability, etc.) plus the custom
        /// crafting-variable key-value store.
        /// </summary>
        public static Crafting Crafting
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:Crafting"));
                return new Crafting(LavishScript.Objects.GetObject("Crafting"));
            }
        }

        /// <summary>
        /// Retrieves the actor from the CustomActorArray by id.
        /// </summary>
        /// <param name="id">actor id</param>
        /// <returns>Actor</returns>
        public static Actor CustomActor(int id)
        {
            Trace.WriteLine(String.Format("Extension:CustomActor({0})", id.ToString(CultureInfo.InvariantCulture)));
            return new Actor(LavishScript.Objects.GetObject("CustomActor", id.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the actor from the CustomActorArray by search criteria.
        /// </summary>
        /// <param name="search">search criteria</param>
        /// <returns>Actor</returns>
        /// /// <remarks>
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
        /// </remarks>
        public static Actor CustomActor(params string[] search)
        {
            Trace.WriteLine(String.Format("Extension:CustomActor({0})", String.Join(", ", search)));
            return new Actor(LavishScript.Objects.GetObject("CustomActor", search));
        }

        /// <summary>
        /// Retrieves information that does not fit into any other datatype.
        /// </summary>
        public static Utility.EQ2 EQ2
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:EQ2"));
                return new Utility.EQ2(LavishScript.Objects.GetObject("EQ2"));
            }
        }

        /// <summary>
        /// Returns an EQ2UIElement of type DataSourceContainer from the xml file named.
        /// </summary>
        /// <param name="parent">top level parent of xml file</param>
        public static EQ2Widget EQ2DataSourceContainer(string parent)
        {
            Trace.WriteLine(String.Format("Extension:EQ2DataSourceContainer({0})", parent));
            return new EQ2Widget(LavishScript.Objects.GetObject("EQ2DataSourceContainer", parent));
        }

        /// <summary>
        /// Returns the EQ2Location from the saved list of locations at the specified index 
        /// in the current zone (1 to ISXEQ2.EQ2LocsCount()) or all zones (1 to ISXEQ2.EQ2LocsCount(true)).
        /// </summary>
        /// <param name="index">index</param>
        /// <param name="allZones">include all zones</param>
        public static EQ2Location EQ2Loc(int index, bool allZones = false)
        {
            Trace.WriteLine(String.Format("Extension:EQ2Location({0}, {1})", index.ToString(CultureInfo.InvariantCulture),
                allZones.ToString()));
            return !allZones
                ? new EQ2Location(LavishScript.Objects.GetObject("EQ2Loc", index.ToString(CultureInfo.InvariantCulture)))
                : new EQ2Location(LavishScript.Objects.GetObject("EQ2Loc", index.ToString(CultureInfo.InvariantCulture),
                    "AllZones"));
        }

        /// <summary>
        /// Returns the EQ2Location that matches the supplied label in the current zone or all zones.
        /// </summary>
        /// <param name="label">label</param>
        /// <param name="allZones">include all zones</param>
        public static EQ2Location EQLoc(string label, bool allZones = false)
        {
            Trace.WriteLine(String.Format("Extension:EQ2Location({0}, {1})", label, allZones.ToString()));
            return !allZones
                ? new EQ2Location(LavishScript.Objects.GetObject("EQ2Loc",label))
                : new EQ2Location(LavishScript.Objects.GetObject("EQ2Loc", label, "AllZones"));
        }

        /// <summary>
        /// Returns the EQ2Window that matches the parent and page names provided.
        /// </summary>
        /// <param name="parent">parent name</param>
        /// <param name="page">page name</param>
        /// <remarks>
        /// This data member takes two arguments. The first argument is the top level 
        /// parent 'page' name from the xml file to which the UIPage's configuration 
        /// is saved (this is usually the second part of the xml filename..see below for 
        /// explanation). The second argument could be any of the top level 'Page' names 
        /// found embedded under the first argument 'page' name. I know that sounds 
        /// complicated, but see below for a couple of examples that should make this 
        /// more clear to you.
        /// First of all, all of the information you need is located in your EQ2 UI 
        /// subdirectory and contains the extension .xml. (ie, eq2ui_inventory_market.xml). 
        /// All of the files that correspond to this TLO begin with the phrase 'eq2ui_'. 
        /// Then, the second word in the file name will always be the ParentPageName 
        /// (in this case, 'inventory'), and then the third word in the file name will 
        /// typically be your second argument (or PageName. If a file only has two parts 
        /// (ie, eq2ui_proxyactor.xml). Then "ProxyActor" would be your ParentPageName 
        /// and then you would need to look inside the file to find your second argument. 
        /// </remarks>
        public static EQ2Window EQ2UIPage(string parent, string page)
        {
            Trace.WriteLine(String.Format("Extension:EQ2UIPage({0}, {1})", parent, page));
            return new EQ2Window(LavishScript.Objects.GetObject("EQ2UIPage", parent, page));
        }

        /// <summary>
        /// Returns information about the examine item window with the specified ID 
        /// (retrieved via the EQ2_ExamineItemWindowAppeared event)
        /// </summary>
        /// <param name="windowID">Window ID</param>
        public static ExamineItemWindow ExamineItemWindow(int windowID)
        {
            Trace.WriteLine(String.Format("Extension:ExamineItemWindow({0})", windowID.ToString(CultureInfo.InvariantCulture)));
            return new ExamineItemWindow(LavishScript.Objects.GetObject("ExamineItemWindow", windowID.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves information about ISXEQ2
        /// </summary>
        public static Utility.ISXEQ2 ISXEQ2
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:ISXEQ2"));
                return new Utility.ISXEQ2(LavishScript.Objects.GetObject("ISXEQ2"));
            }
        }

        /// <summary>
        /// Returns the last loot window opened (or the only one, if you only have one loot window up), 
        /// or the loot window that corresponds with a specific ID as supplied by the EQ2_onLootWindowAppeared event. 
        /// (If you have no loot windows up, then it returns NULL) 
        /// </summary>
        /// <param name="windowID">window id</param>
        public static LootWindow LootWindow(int windowID = 0)
        {
            Trace.WriteLine((windowID == 0) ? String.Format("Extension:LootWindow()") : String.Format("Extension:LootWindow({0})", windowID.ToString(CultureInfo.InvariantCulture)));
            return windowID == 0
                ? new LootWindow(LavishScript.Objects.GetObject("LootWindow"))
                : new LootWindow(LavishScript.Objects.GetObject("LootWindow",
                    windowID.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the Mail window (player mail inbox) when the player is in a mail
        /// transaction at a post office or mailbox.
        /// </summary>
        public static MailWindow MailWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:MailWindow"));
                return new MailWindow(LavishScript.Objects.GetObject("MailWindow"));
            }
        }

        /// <summary>
        /// Retrieves the main Map window (eq2mapwindow) when one is currently open,
        /// otherwise NULL.
        /// </summary>
        public static MapWindow MapWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:MapWindow"));
                return new MapWindow(LavishScript.Objects.GetObject("MapWindow"));
            }
        }

        /// <summary>
        /// Retrieves the Merchant window (eq2merchantwindow) when one is currently open,
        /// otherwise NULL.
        /// </summary>
        public static MerchantWindow MerchantWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:MerchantWindow"));
                return new MerchantWindow(LavishScript.Objects.GetObject("MerchantWindow"));
            }
        }

        /// <summary>
        /// Retrieves the player character
        /// </summary>
        public static Character Me
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:Me"));
                return new Character(LavishScript.Objects.GetObject("Me"));
            }
        }

        /// <summary>
        /// Retrieves the Opened Mail window (the singular per-message reading window)
        /// when the player has a mail item opened, otherwise NULL.
        /// </summary>
        public static OpenedMailWindow OpenedMailWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:OpenedMailWindow"));
                return new OpenedMailWindow(LavishScript.Objects.GetObject("OpenedMailWindow"));
            }
        }

        /// <summary>
        /// Retrieves the Quest Journal window (eq2questjournalwindow) when one is
        /// currently open, otherwise NULL.
        /// </summary>
        public static QuestJournalWindow QuestJournalWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:QuestJournalWindow"));
                return new QuestJournalWindow(LavishScript.Objects.GetObject("QuestJournalWindow"));
            }
        }

        /// <summary>
        /// Retrieves the radar at the specified index. If no index is provided, it returns the first/only
        /// radar in the array.
        /// </summary>
        /// <param name="index">index</param>
        public static Radar Radar(int index = 0)
        {
            Trace.WriteLine((index == 0) ? String.Format("Extension:Radar()") : String.Format("Extension:Radar({0})", index.ToString(CultureInfo.InvariantCulture)));
            return index == 0
                ? new Radar(LavishScript.Objects.GetObject("Radar"))
                : new Radar(LavishScript.Objects.GetObject("Radar", index.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Retrieves the radar that matches the supplied name.
        /// </summary>
        /// <param name="name">name</param>
        public static Radar Radar(string name)
        {
            Trace.WriteLine(String.Format("Extension:Radar({0}", name));
            return new Radar(LavishScript.Objects.GetObject("Radar", name));
        }

        /// <summary>
        /// Retrieves the Radial Menu window (eq2radialmenuwindow) when one is
        /// currently open, otherwise NULL.
        /// </summary>
        public static RadialMenuWindow RadialMenuWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:RadialMenuWindow"));
                return new RadialMenuWindow(LavishScript.Objects.GetObject("RadialMenuWindow"));
            }
        }

        /// <summary>
        /// Retrieves the Reforge window (eq2reforgewindow) when one is currently open,
        /// otherwise NULL.
        /// </summary>
        public static ReforgeWindow ReforgeWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:ReforgeWindow"));
                return new ReforgeWindow(LavishScript.Objects.GetObject("ReforgeWindow"));
            }
        }

        /// <summary>
        /// Retrieves the ReplyDialog with the supplied ID (from EQ2_ReplyDialogAppeared) or
        /// the last ReplyDialog if not ID is provided.
        /// </summary>
        /// <param name="windowID">window ID</param>
        public static ReplyDialog ReplyDialog(int windowID = 0)
        {
            Trace.WriteLine((windowID == 0) ? String.Format("Extension:ReplyDialog()") : 
                String.Format("Extension:ReplyDialog({0})", windowID.ToString(CultureInfo.InvariantCulture)));
            return windowID == 0
                ? new ReplyDialog(LavishScript.Objects.GetObject("ReplyDialog"))
                : new ReplyDialog(LavishScript.Objects.GetObject("ReplyDialog",
                    windowID.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Returns a rewardwindow datatype object representing any reward window that may be open.
        /// </summary>
        /// <remarks>
        /// NOTES:
        /// if ${RewardWindow} is NULL, then you do not have a pending quest reward.
        /// Using any other button besides 'Receive' when you have a reward item waiting, is not advised.
        /// At the moment, this supports only receiving rewards when there is no 'choice' to be made. That may be added in the future.
        /// </remarks>
        public static RewardWindow RewardWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:RewardWindow"));
                return new RewardWindow(LavishScript.Objects.GetObject("RewardWindow"));
            }
        }

        /// <summary>
        /// Strips the EQ2 hyperlink-type tags from a string.
        /// </summary>
        /// <param name="rawText">text</param>
        public static string StripTags(string rawText)
        {
            Trace.WriteLine(String.Format("Extension:StripTags({0})", rawText));
            return LavishScript.Objects.GetObject<string>("StripTags", rawText);
        }

        /// <summary>
        /// Retrieves the active target object
        /// </summary>
        public static Actor Target()
        {
            Trace.WriteLine(String.Format("Extension:Target"));
            return new Actor(LavishScript.Objects.GetObject("Target"));
        }

        /// <summary>
        /// Retrieves the Travel Map window (eq2travelmapwindow) when one is currently
        /// open, otherwise NULL.
        /// </summary>
        public static TravelMapWindow TravelMapWindow
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:TravelMapWindow"));
                return new TravelMapWindow(LavishScript.Objects.GetObject("TravelMapWindow"));
            }
        }

        /// <summary>
        /// Retrieves information about the current zone.
        /// </summary>
        public static Zone Zone
        {
            get
            {
                Trace.WriteLine(String.Format("Extension:Zone"));
                return new Zone(LavishScript.Objects.GetObject("Zone"));
            }
        }
        
        #endregion

        #region Commands
        /// TODO: Implement Craft
        /// TODO: Implement Dump
        /// TODO: Implement EQ2Ignore
        /// TODO: Implement ShowStats


        /// <summary>
        /// Activates an item that is currently equipped. (The command
        /// activates an item in the same way as if you placed the item
        /// in your hotbar and clicked on it, or, if you right-click on
        /// an item and select 'use'.)
        /// </summary>
        /// <param name="slot">equipment slot</param>
        public static int Activate(EquipSlot slot)
        {
            Trace.WriteLine(String.Format("Extension:Activate({0})", slot));
            return LavishScript.ExecuteCommand(String.Format("Activate {0}", slot.ToString().ToLower()));
        }

        /// <summary>
        /// Makes an in-game announcement for the supplied duration with the specified
        /// sound. Dispatches the source 'announce' command (lowercase).
        /// </summary>
        /// <param name="text">announcement text</param>
        /// <param name="timer">time (seconds) to remain on screen</param>
        /// <param name="sound">sound to play</param>
        public static int Announce(string text, float timer, AnnouncementSound sound = AnnouncementSound.QuestComplete)
        {
            Trace.WriteLine(String.Format("Extension:Announce({0}, {1}, {2})", text,
                timer.ToString(CultureInfo.InvariantCulture), sound));
            return LavishScript.ExecuteCommand(String.Format("announce {0} {1} {2}", text,
                timer.ToString(CultureInfo.InvariantCulture),
                ((int)sound).ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Performs a broker search because ISXEQ is stupid AF
        /// </summary>
        /// <param name="name">Name of broker</param>
        public static int Broker(string name)
        {
            Trace.WriteLine(String.Format("Extension:Broker({0})", name));
            return LavishScript.ExecuteCommandEx("broker","name", name);
        }

        /// <summary>
        /// Echoes a message directly to your chat window(s).
        /// </summary>
        /// <param name="message">message</param>
        /// <param name="type">chat type</param>
        /// <returns></returns>
        public static int EQ2Echo(string message, ChatType type = ChatType.None)
        {
            Trace.WriteLine((type != ChatType.None) ? String.Format("Extension:EQ2Echo({0}, {1})", message, type) 
                : String.Format("Extension:EQ2Echo({0})", message));
            return
                LavishScript.ExecuteCommand((type != ChatType.None) ? 
                String.Format("EQ2Echo {0} -chattype {1}", message, type.ToString().ToLower()) 
                : String.Format("EQ2Echo {0}", message));
        }

        /// <summary>
        /// Executes an EQ2 command directly.
        /// </summary>
        /// <param name="command">command</param>
        public static int EQ2Execute(params string[] command)
        {
            Trace.WriteLine(String.Format("Extension:EQ2Execute({0})", String.Join(", ", command)));
            return LavishScript.ExecuteCommand(String.Format("EQ2Execute {0}", String.Join(" ", command)));
        }

        /// <summary>
        /// This command allows you to specify particular key phrases that will cause
        /// isxeq2 to ignore an incoming chat channel text. If the given phrase will 
        /// trigger an ignore if it is found in the chat text, sender name, target name, 
        /// or customchannel name. You may also use the 'eq2ignore all' toggle to ignore 
        /// ALL incoming chat text (e.g. if you need complete silence.) Use the 
        /// 'eq2ignore all' command again to toggle things back to normal, which will 
        /// again use the ignores you already had set up. 
        /// </summary>
        /// <param name="args">parameters</param>
        /// <returns></returns>
        public static int EQ2Ignore(string args)
        {
            Trace.WriteLine(String.Format("Extension:EQ2Ignore({0})", args));
            return LavishScript.ExecuteCommand(String.Format("EQ2Ignore {0}", args));
        }

        /// <summary>
        /// Dispatches the 'eq2loc' console command, which is the command-side adder
        /// for saved locations. This is distinct from the EQ2Loc(int) / EQLoc(string)
        /// TLO accessors above, which retrieve already-saved locations.
        /// </summary>
        /// <param name="args">command arguments (label, notes, etc.)</param>
        public static int EQ2Loc(string args)
        {
            Trace.WriteLine(String.Format("Extension:EQ2Loc({0})", args));
            return LavishScript.ExecuteCommand(String.Format("eq2loc {0}", args));
        }

        /// <summary>
        /// Faces your current target.
        /// </summary>
        public static int Face()
        {
            Trace.WriteLine(String.Format("Extension:Face()"));
            return LavishScript.ExecuteCommand("Face");
        }

        /// <summary>
        /// Faces the nearest actor of the specified type.
        /// </summary>
        /// <param name="type">actor type</param>
        public static int Face(ActorType type)
        {
            Trace.WriteLine(String.Format("Extension:Face({0})", type));
            return LavishScript.ExecuteCommand(String.Format("Face {0}", type));
        }

        /// <summary>
        /// Faces the specified heading (0 to 360.0)
        /// </summary>
        /// <param name="heading">heading</param>
        public static int Face(float heading)
        {
            Trace.WriteLine(String.Format("Extension:Face({0})", heading.ToString(CultureInfo.InvariantCulture)));
            return LavishScript.ExecuteCommand(String.Format("Face {0}", heading.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Faces the supplied location on the XZ plane
        /// </summary>
        /// <param name="x">x-coordinate</param>
        /// <param name="z">z-coordinate</param>
        public static int Face(float x, float z)
        {
            Trace.WriteLine(String.Format("Extension:Face({0}, {1})", 
                x.ToString(CultureInfo.InvariantCulture), z.ToString(CultureInfo.InvariantCulture)));
            return LavishScript.ExecuteCommand(String.Format("Face {0} {1}",
                x.ToString(CultureInfo.InvariantCulture), z.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Faces the supplied location in the XZY plane.
        /// </summary>
        /// <param name="x">x-coordinate</param>
        /// <param name="y">y-coordinate</param>
        /// <param name="z">z-coordinate</param>
        public static int Face(float x, float y, float z)
        {
            Trace.WriteLine(String.Format("Extension:Face({0}, {1}, {2})", x.ToString(CultureInfo.InvariantCulture), 
                y.ToString(CultureInfo.InvariantCulture), z.ToString(CultureInfo.InvariantCulture)));
            return LavishScript.ExecuteCommand(String.Format("Face {0} {1} {2}", x.ToString(CultureInfo.InvariantCulture),
                y.ToString(CultureInfo.InvariantCulture), z.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Faces the nearest actor that has a name that is either a full or partial match.
        /// Supplting the name "nocamera" allows you to decide if you want the camera to
        /// adjust its heading or not when you are in 3rd person. By default, your camera 
        /// will adjust when you adjust your player's heading with /face. However, if you 
        /// type "/face nocamera", then your player will change heading, but the camera 
        /// will remain where it was. '/face nocamera' will toggle it again if you change 
        /// your mind. 
        /// </summary>
        /// <param name="name">name</param>
        public static int Face(string name)
        {
            Trace.WriteLine(String.Format("Extension:Face({0})", name));
            return LavishScript.ExecuteCommand(String.Format("Face {0}", name));
        }

        /// <summary>
        /// Issues a GET HTTP request. The optional contentType argument was added
        /// 2024-07-06 (per ISXEQ2Changes.txt) and corresponds to the third positional
        /// parameter of the underlying GetURL command. Responses arrive via the
        /// isxGames_onHTTPResponse event.
        /// </summary>
        /// <param name="url">target URL (http or https)</param>
        /// <param name="contentType">optional Content-Type header value</param>
        public static int GetURL(string url, string contentType = null)
        {
            Trace.WriteLine((contentType == null) ? String.Format("Extension:GetURL({0})", url)
                : String.Format("Extension:GetURL({0}, {1})", url, contentType));
            return LavishScript.ExecuteCommand((contentType == null)
                ? String.Format("GetURL \"{0}\"", url)
                : String.Format("GetURL \"{0}\" \"{1}\"", url, contentType));
        }

        /// <summary>
        /// Re-initializes ISXEQ2's command bindings. Useful after dynamic command
        /// registration or after certain reload scenarios.
        /// </summary>
        public static int InitCommands()
        {
            Trace.WriteLine(String.Format("Extension:InitCommands()"));
            return LavishScript.ExecuteCommand("InitCommands");
        }

        /// <summary>
        /// Issues a POST HTTP request with the supplied body. The optional contentType
        /// argument was added 2024-07-06 (per ISXEQ2Changes.txt) and corresponds to the
        /// fourth positional parameter of the underlying PostURL command. Responses
        /// arrive via the isxGames_onHTTPResponse event.
        /// </summary>
        /// <param name="url">target URL (http or https)</param>
        /// <param name="body">POST body / post_data</param>
        /// <param name="contentType">optional Content-Type header value (e.g. "application/json")</param>
        public static int PostURL(string url, string body, string contentType = null)
        {
            Trace.WriteLine((contentType == null) ? String.Format("Extension:PostURL({0})", url)
                : String.Format("Extension:PostURL({0}, ..., {1})", url, contentType));
            return LavishScript.ExecuteCommand((contentType == null)
                ? String.Format("PostURL \"{0}\" \"{1}\"", url, body)
                : String.Format("PostURL \"{0}\" \"{1}\" \"{2}\"", url, body, contentType));
        }

        /// <summary>
        /// Used to issue commands to the Radar. Custom radar name is
        /// not used for on and off and is optional for zoomin and zoomout
        /// </summary>
        /// <param name="command">command</param>
        /// <param name="name">custom radar name</param>
        public static int Radar(RadarCommand command, string name = null)
        {
            Trace.WriteLine((name == null) ? String.Format("Extension:Radar({0})", command.ToString().ToLower())                 
                : String.Format("Extension:Radar({0}, {1})", command, name));
            return
                LavishScript.ExecuteCommand((name == null) ? String.Format("Radar {0}", command.ToString().ToLower()) 
                : String.Format("Radar {0} {1}", name, command.ToString().ToLower()));
        }

        /// <summary>
        /// Targets the nearest actor of the supplied type
        /// </summary>
        /// <param name="type">target type</param>
        public static int Target(TargetType type)
        {
            Trace.WriteLine(String.Format("Extension:Target({0})", type));
            return LavishScript.ExecuteCommand(String.Format("Target {0}", type.ToString().ToLower()));
        }

        /// <summary>
        /// Targets the entity with the matching ID.
        /// </summary>
        /// <param name="id">ID</param>
        public static int Target(int id)
        {
            Trace.WriteLine(String.Format("Extension:Target({0})", id.ToString(CultureInfo.InvariantCulture)));
            return LavishScript.ExecuteCommand(String.Format("Target {0}", id.ToString(CultureInfo.InvariantCulture)));
        }

        /// <summary>
        /// Targets the nearest entity that is a partial or full match with the name.
        /// </summary>
        /// <param name="name">name</param>
        public static int Target(string name)
        {
            Trace.WriteLine(String.Format("Extension:Target({0})", name));
            return LavishScript.ExecuteCommand(String.Format("Target {0}", name));
        }

        /// <summary>
        /// Dispatches the 'Where' command, which prints the player's current world
        /// position / zone information to the chat window.
        /// </summary>
        public static int Where()
        {
            Trace.WriteLine(String.Format("Extension:Where()"));
            return LavishScript.ExecuteCommand("Where");
        }

        /// <summary>
        /// Makes an in-game announcement for the supplied duration with the specified
        /// sound. Prefer the newer Announce(...) method going forward — this overload
        /// is retained for source-API parity with older script consumers.
        /// </summary>
        /// <param name="announcement">announcement text</param>
        /// <param name="timer">time (seconds) to remain on screen</param>
        /// <param name="sound">sound to play</param>
        [Obsolete("Use Announce(...) instead — this method is retained for backwards compatibility only.")]
        public static int EQ2Announce(string announcement, float timer, AnnouncementSound sound = AnnouncementSound.QuestComplete)
        {
            return LavishScript.ExecuteCommand(String.Format("announce {0} {1} {2}", announcement,
                timer.ToString(CultureInfo.InvariantCulture), ((int)sound).ToString(CultureInfo.InvariantCulture)));
        }

        #endregion

        #region Enums

        /// <summary>
        /// Actor Types
        /// </summary>
        public enum ActorType
        {
            /// <summary>
            /// Player Character
            /// </summary>
            PC,
            /// <summary>
            /// Non Player Character
            /// </summary>
            NPC,
            /// <summary>
            /// Named Non Player Character
            /// </summary>
            NamedNPC,
            /// <summary>
            /// No Kill Non Player Character
            /// </summary>
            NoKillNPC,
            /// <summary>
            /// Special
            /// </summary>
            Special,
            /// <summary>
            /// Resource
            /// </summary>
            Resource,
            /// <summary>
            /// Trade Skill Unit
            /// </summary>
            TSUnit,
            /// <summary>
            /// Corpse
            /// </summary>
            Corpse
        }

        /// <summary>
        /// Announcement Sounds
        /// </summary>
        public enum AnnouncementSound
        {
            /// <summary>
            /// Skill Up Sound
            /// </summary>
            SkillUp = 1,
            /// <summary>
            /// Quest Update Sound
            /// </summary>
            QuestUpdate,
            /// <summary>
            /// Level Ding Sound
            /// </summary>
            LevelDing,
            /// <summary>
            /// Call For Help Sound
            /// </summary>
            CallForHelp,
            /// <summary>
            /// Rare Harvest Sound
            /// </summary>
            HarvestRare,
            /// <summary>
            /// Quest Complete Sound
            /// </summary>
            QuestComplete,
            /// <summary>
            /// Location Discovery Sound
            /// </summary>
            LocationDiscovery,
            /// <summary>
            /// Send Mail Failed Sound
            /// </summary>
            SendMailFailed,
            /// <summary>
            /// Send Mail Success Sound
            /// </summary>
            SendMailSuccess
        }

        /// <summary>
        /// Chat Types
        /// </summary>
        public enum ChatType
        {
            /// <summary>
            /// Default Chat Type
            /// </summary>
            Default,
            /// <summary>
            /// Status Chat Type
            /// </summary>
            Status,
            /// <summary>
            /// System Chat Type
            /// </summary>
            System,
            /// <summary>
            /// Error Chat Type
            /// </summary>
            Error,
            /// <summary>
            /// Command Chat Type
            /// </summary>
            Cmd,
            /// <summary>
            /// Customer Service Tell Chat Type
            /// </summary>
            CSTell,
            /// <summary>
            /// Message of the Day Chat Type
            /// </summary>
            Motd,
            /// <summary>
            /// Guild Message of the Day Chat Type
            /// </summary>
            GMotd,
            /// <summary>
            /// Guild Chat Type
            /// </summary>
            Gu,
            /// <summary>
            /// Guild Officer Chat Type
            /// </summary>
            GOfficerChat,
            /// <summary>
            /// Guild Online Chat Type
            /// </summary>
            GOnline,
            /// <summary>
            /// Group Chat Type
            /// </summary>
            GSay,
            /// <summary>
            /// Raid Chat Type
            /// </summary>
            RSay,
            /// <summary>
            /// Say Chat Type
            /// </summary>
            Say,
            /// <summary>
            /// Emote Chat Type
            /// </summary>
            Emote,
            /// <summary>
            /// Tell Chat Type
            /// </summary>
            Tell,
            /// <summary>
            /// Yell For Help Chat Type
            /// </summary>
            YellForHelp,
            /// <summary>
            /// Death Chat Type
            /// </summary>
            Death,  
            /// <summary>
            /// Who Chat Type
            /// </summary>
            Who,
            /// <summary>
            /// Out of Character Chat Type
            /// </summary>
            OOC,
            /// <summary>
            /// Auction Chat Type
            /// </summary>
            Auction,  
            /// <summary>
            /// Shout Chat Type
            /// </summary>
            Shout,
            /// <summary>
            /// Narrative Chat Type
            /// </summary>
            Narrative,
            /// <summary>
            /// Non PC Tell Chat Type
            /// </summary>
            NonPCTell,
            /// <summary>
            /// Merchant Chat Type
            /// </summary>
            Merchant,
            /// <summary>
            /// Reward Chat Type
            /// </summary>
            Reward,
            /// <summary>
            /// Pet Chat Type
            /// </summary>
            PetChat,
            /// <summary>
            /// Spell Chat Type
            /// </summary>
            Spell,
            /// <summary>
            /// Spell Fail Chat Type
            /// </summary>
            SpellFail,
            /// <summary>
            /// Spell Fail to Cast Chat Type
            /// </summary>
            SpellFCast,
            /// <summary>
            /// Spell H Cast Chat Type
            /// </summary>
            SpellHCast,
            /// <summary>
            /// Spell Worn Off Chat Type
            /// </summary>
            SpellWOff,
            /// <summary>
            /// Spell Other Chat Type
            /// </summary>
            SpellOther,
            /// <summary>
            /// Skill Chat Type
            /// </summary>
            Skill,
            /// <summary>
            /// Damage Chat Type
            /// </summary>
            Dmg,
            /// <summary>
            /// Damage Shield
            /// </summary>
            DS,
            /// <summary>
            /// Melee Warning Chat Type
            /// </summary>
            MeleeWarning,
            /// <summary>
            /// Melee Hit Chat Type
            /// </summary>
            MeleeHit,
            /// <summary>
            /// Melee Hits Me Chat Type
            /// </summary>
            MeleeHitsMe,
            /// <summary>
            /// No Chat Type
            /// </summary>
            None
        }

        /// <summary>
        /// Equipment Slots
        /// </summary>
        public enum EquipSlot
        {
            /// <summary>
            /// Primary Slot
            /// </summary>
            Primary,
            /// <summary>
            /// Secondary Slot
            /// </summary>
            Secondary,
            /// <summary>
            /// Head Slot
            /// </summary>
            Head,
            /// <summary>
            /// Chest Slot
            /// </summary>
            Chest,
            /// <summary>
            /// Shoulders Slot
            /// </summary>
            Shoulders,
            /// <summary>
            /// Forearms Slot
            /// </summary>
            Forearms,
            /// <summary>
            /// Hands Slot
            /// </summary>
            Hands,
            /// <summary>
            /// Legs Slot
            /// </summary>
            Legs,
            /// <summary>
            /// Feet Slot
            /// </summary>
            Feet,
            /// <summary>
            /// Left Ring Slot
            /// </summary>
            Left_Ring,
            /// <summary>
            /// Right Ring Slot
            /// </summary>
            Right_Ring,
            /// <summary>
            /// Ears Slot
            /// </summary>
            Ears,
            /// <summary>
            /// Neck Slot
            /// </summary>
            Neck,
            /// <summary>
            /// Left Wrist Slot
            /// </summary>
            Left_Wrist,
            /// <summary>
            /// Right Wrist Slot
            /// </summary>
            Right_Wrist,
            /// <summary>
            /// Ranged Slot
            /// </summary>
            Ranged,
            /// <summary>
            /// Ammo Slot
            /// </summary>
            Ammo,
            /// <summary>
            /// Waist Slot
            /// </summary>
            Waist,
            /// <summary>
            /// Charm Slot 1
            /// </summary>
            Activate1,
            /// <summary>
            /// Charm Slot 2
            /// </summary>
            Activate2
        }

        /// <summary>
        /// Radar Commands
        /// </summary>
        public enum RadarCommand
        {
            /// <summary>
            /// On
            /// </summary>
            On,
            /// <summary>
            /// Off
            /// </summary>
            Off,
            /// <summary>
            /// ZoomIn
            /// </summary>
            ZoomIn,
            /// <summary>
            /// ZoomOut
            /// </summary>
            ZoomOut
        }

        /// <summary>
        /// Target Types
        /// </summary>
        public enum TargetType
        {
            /// <summary>
            /// Me
            /// </summary>
            Me,
            /// <summary>
            /// Player Character
            /// </summary>
            PC,
            /// <summary>
            /// Non Player Character
            /// </summary>
            NPC,
            /// <summary>
            /// No Kill Non Player Character
            /// </summary>
            NoKillNPC,
            /// <summary>
            /// Resource
            /// </summary>
            Resource,
            /// <summary>
            /// Trade Skill Unit
            /// </summary>
            TradeSkillUnit,
            /// <summary>
            /// Special
            /// </summary>
            Special
        }

        #endregion

    }
}