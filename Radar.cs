using System;
using System.Diagnostics;
using System.Globalization;
using LavishScriptAPI;
using EQ2.ISXEQ2.Extensions;

namespace EQ2.ISXEQ2
{
    /// <summary>
    /// This DataType includes all of the data available through ISXEQ2 that is related to your radar. 
    /// </summary>
    public class Radar : LavishScriptObject
    {

        #region Construct

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="copy">LS Object</param>
        public Radar(LavishScriptObject copy) : base(copy) { }


        #endregion

        #region Members

        /// <summary>
        /// True if text clipping is on
        /// </summary>
        public bool ClippingTextOn
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ClippingTextOn"));
                return this.GetBoolFromLSO("ClippingTextOn");
            }
        }

        /// <summary>
        /// True if radius clipping is on
        /// </summary>
        public bool ClipRadiusOn
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ClipRadiusOn"));
                return this.GetBoolFromLSO("ClipRadiusOn");
            }
        }

        /// <summary>
        /// True if labels are colorized
        /// </summary>
        public bool ColorizingLabels
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ColorizingLabels"));
                return this.GetBoolFromLSO("ColorizingLabels");
            }
        }

        /// <summary>
        /// Returns the filter at the selected index
        /// </summary>
        /// <param name="index">the index</param>
        /// <returns>custom filter</returns>
        public string CustomFilter(int index)
        {
            Trace.WriteLine(String.Format("Radar:CustomFilter"));
            return this.GetStringFromLSO("CustomFilter", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// A list of the custom filters in effect
        /// </summary>
        public string CustomFiltersList
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:CustomFiltersList"));
                return this.GetStringFromLSO("CustomFiltersList");
            }
        }

        /// <summary>
        /// The name of the object on the radar
        /// </summary>
        public string Name
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:Name"));
                return this.GetStringFromLSO("Name");
            }
        }

        /// <summary>
        /// Returns the number of filters active on the radar
        /// </summary>
        public int NumCustomFilters
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:NumCustomFilters"));
                return this.GetIntFromLSO("NumCustomFilters");
            }
        }

        /// <summary>
        /// True if radar rotation is on
        /// </summary>
        public bool RotationOn
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:RotationOn"));
                return this.GetBoolFromLSO("RotationOn");
            }
        }

        /// <summary>
        /// True if the radar is displaying Aggro NPCs
        /// </summary>
        public bool ShowingAggroNPCs
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingAggroNPCs"));
                return this.GetBoolFromLSO("ShowingAggroNPCs");
            }
        }

        /// <summary>
        /// True if the radar is displating chests
        /// </summary>
        public bool ShowingChests
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingChests"));
                return this.GetBoolFromLSO("ShowingChests");
            }
        }

        /// <summary>
        /// True if the radar is displaying corpses
        /// </summary>
        public bool ShowingCorpses
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingCorpses"));
                return this.GetBoolFromLSO("ShowingCorpses");
            }
        }

        /// <summary>
        /// True if the radar is showing doors
        /// </summary>
        public bool ShowingDoors
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingDoors"));
                return this.GetBoolFromLSO("ShowingDoors");
            }
        }

        /// <summary>
        /// True if the radar is showing labels
        /// </summary>
        public bool ShowingLabels
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingLabels"));
                return this.GetBoolFromLSO("ShowingLabels");
            }
        }

        /// <summary>
        /// True if the radar is showing the client
        /// </summary>
        public bool ShowingMe
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingMe"));
                return this.GetBoolFromLSO("ShowingMe");
            }
        }

        /// <summary>
        /// True if Showing Mercenaries
        /// </summary>
        public bool ShowingMercenaries
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingMercenaries"));
                return this.GetBoolFromLSO("ShowingMercenaries");
            }
        }

        /// <summary>
        /// True if the radar is displaying client's pet
        /// </summary>
        public bool ShowingMyPet
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingMyPet"));
                return this.GetBoolFromLSO("ShowingMyPet");
            }
        }

        /// <summary>
        /// True if the radar is showing Named NPCs
        /// </summary>
        public bool ShowingNamedNPCs
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingNamedNPCs"));
                return this.GetBoolFromLSO("ShowingNamedNPCs");
            }
        }

        /// <summary>
        /// True if the radar is displaying NPCs that cannot be attacked
        /// </summary>
        public bool ShowingNoKillNPCs
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingNoKillNPCs"));
                return this.GetBoolFromLSO("ShowingNoKillNPCs");
            }
        }

        /// <summary>
        /// True if the radar is showing NPCs
        /// </summary>
        public bool ShowingNPCs
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingNPCs"));
                return this.GetBoolFromLSO("ShowingNPCs");
            }
        }

        /// <summary>
        /// True if the radar is displaying PCs
        /// </summary>
        public bool ShowingPCs
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingPCs"));
                return this.GetBoolFromLSO("ShowingPCs");
            }
        }

        /// <summary>
        /// True if the radar is displaying pets
        /// </summary>
        public bool ShowingPets
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingPets"));
                return this.GetBoolFromLSO("ShowingPets");
            }
        }

        /// <summary>
        /// True if the radar is showing Resources
        /// </summary>
        public bool ShowingResources
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingResources"));
                return this.GetBoolFromLSO("ShowingResources");
            }
        }

        /// <summary>
        /// True if the radar is showing Specials
        /// </summary>
        public bool ShowingSpecials
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingSpecials"));
                return this.GetBoolFromLSO("ShowingSpecials");
            }
        }

        /// <summary>
        /// True if the radar is displaying Tradeskill units
        /// </summary>
        public bool ShowingTSUnits
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingTSUnits"));
                return this.GetBoolFromLSO("ShowingTSUnits");
            }
        }

        /// <summary>
        /// True if the radar is displaying unknowns
        /// </summary>
        public bool ShowingUnknowns
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:ShowingUnknowns"));
                return this.GetBoolFromLSO("ShowingUnknowns");
            }
        }

        /// <summary>
        /// The value used for "zooming"
        /// </summary>
        public int Size
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:Size"));
                return this.GetIntFromLSO("Size");
            }
        }

        /// <summary>
        /// True if Y Axis Clipping is on
        /// </summary>
        public bool YAxisClippingOn
        {
            get
            {
                Trace.WriteLine(String.Format("Radar:YAvisClippingOn"));
                return this.GetBoolFromLSO("YAxisClippingOn");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Toggles the custom filter "Clip Radius"
        /// </summary>
        /// <returns>call success</returns>
        public bool ClipRadius()
        {
            Trace.WriteLine(String.Format("Radar:ClipRadius()"));
            return this.ExecuteMethod("ClipRadius");
        }

        /// <summary>
        /// Toggles the custom filter "Show Text"
        /// </summary>
        /// <returns>call success</returns>
        public bool ClipText()
        {
            Trace.WriteLine(String.Format("Radar:ClipText()"));
            return this.ExecuteMethod("ClipText");
        }

        /// <summary>
        /// Toggles the custom filter "Show Con Color"
        /// </summary>
        /// <returns>call success</returns>
        public bool ColorizeLabels()
        {
            Trace.WriteLine(String.Format("Radar:ColorizeLabels()"));
            return this.ExecuteMethod("ColorizeLabels");
        }

        /// <summary>
        /// Toggles the custom filter "Show Aggro"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterAggroNPCs()
        {
            Trace.WriteLine(String.Format("Radar:FilterAggroNPCs()"));
            return this.ExecuteMethod("FilterAggroNPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show Chests"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterChests()
        {
            Trace.WriteLine(String.Format("Radar:FilterChests()"));
            return this.ExecuteMethod("FilterChests");
        }

        /// <summary>
        /// Toggles the custom filter "Show Corpses"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterCorpses()
        {
            Trace.WriteLine(String.Format("Radar:FilterCorpses()"));
            return this.ExecuteMethod("FilterCorpses");
        }

        /// <summary>
        /// Toggles the custom filter "Show Doors"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterDoors()
        {
            Trace.WriteLine(String.Format("Radar:FilterDoors()"));
            return this.ExecuteMethod("FilterDoors");
        }

        /// <summary>
        /// Toggles the custom filter "Show Me"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterMe()
        {
            Trace.WriteLine(String.Format("Radar:FilterMe()"));
            return this.ExecuteMethod("FilterMe");
        }

        /// <summary>
        /// Toggle the "Show Mercenaries" filter
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterMercenaries()
        {
            Trace.WriteLine(String.Format("Radar:FilterMercenaries()"));
            return this.ExecuteMethod("FilterMercenaries");
        }

        /// <summary>
        /// Toggles the custom filter "Show My Pet"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterMyPet()
        {
            Trace.WriteLine(String.Format("Radar:FilterMyPet()"));
            return this.ExecuteMethod("FilterMyPet");
        }

        /// <summary>
        /// Toggles the custom filter "Show Named"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterNamedNPCs()
        {
            Trace.WriteLine(String.Format("Radar:FilterNamedNPCs()"));
            return this.ExecuteMethod("FilterNamedNPCs");
        }

        /// <summary>
        /// Toggles the "Show NoKillNPCs" filter
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterNoKillNPCs()
        {
            Trace.WriteLine(String.Format("Radar:FilterNoKillNPCs()"));
            return this.ExecuteMethod("FilterNoKillNPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show NPCs"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterNPCs()
        {
            Trace.WriteLine(String.Format("Radar:FilterNPCs()"));
            return this.ExecuteMethod("FilterNPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show PCs"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterPCs()
        {
            Trace.WriteLine(String.Format("Radar:FilterNPCs()"));
            return this.ExecuteMethod("FilterPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show Pets"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterPets()
        {
            Trace.WriteLine(String.Format("Radar:FilterPets()"));
            return this.ExecuteMethod("FilterPets");
        }

        /// <summary>
        /// Toggles the custom filter "Show Resources"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterResources()
        {
            Trace.WriteLine(String.Format("Radar:FilterResources()"));
            return this.ExecuteMethod("FilterResources");
        }

        /// <summary>
        /// Toggles the custom filter "Show Specials"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterSpecials()
        {
            Trace.WriteLine(String.Format("Radar:FilterSpecials()"));
            return this.ExecuteMethod("FilterSpecials");
        }

        /// <summary>
        /// Toggles the custom filter "Show Tradeskill"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterTSUnits()
        {
            Trace.WriteLine(String.Format("Radar:FilterTSUnits()"));
            return this.ExecuteMethod("FilterTSUnits");
        }

        /// <summary>
        /// Toggles the custom filter "Show Unknowns"
        /// </summary>
        /// <returns>call success</returns>
        public bool FilterUnknowns()
        {
            Trace.WriteLine(String.Format("Radar:FilterUnknowns()"));
            return this.ExecuteMethod("FilterUnknowns");
        }

        /// <summary>
        /// Toggles radar rotation
        /// </summary>
        /// <returns>call success</returns>
        public bool Rotation()
        {
            Trace.WriteLine(String.Format("Radar:Rotation()"));
            return this.ExecuteMethod("Rotation");
        }

        /// <summary>
        /// Used to toggle a specific custom filter
        /// </summary>
        /// <param name="filter">The selected filter to toggle</param>
        /// <returns>call success</returns>
        public bool SetCustomFilter(string filter)
        {
            Trace.WriteLine(String.Format("Radar:SetCustomFilter({0})", filter));
            return this.ExecuteMethod("SetCustomFilter", filter);
        }

        /// <summary>
        /// Sets the "zoom" of the radar
        /// </summary>
        /// <param name="size">the new zoom</param>
        /// <returns>call success</returns>
        public bool SetSize(int size)
        {
            Trace.WriteLine(String.Format("Radar:SetSize({0})", size.ToString(CultureInfo.InvariantCulture)));
            return this.ExecuteMethod("SetSize", size.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Toggles the custom filter "Show Labels"
        /// </summary>
        /// <returns>call success</returns>
        public bool ShowLabels()
        {
            Trace.WriteLine(String.Format("Radar:ShowLabels()"));
            return this.ExecuteMethod("ShowLabels");
        }

        /// <summary>
        /// Toggles the custom filter "Y-axis Clipping"
        /// </summary>
        /// <returns>call success</returns>
        public bool YAxisClipping()
        {
            Trace.WriteLine(String.Format("Radar:YAxisClipping()"));
            return this.ExecuteMethod("YAxisClipping");
        }

        #endregion
   
    }
}
