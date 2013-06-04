// Disable all XML Comment warnings in this file // 
#pragma warning disable 1591 

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

using InnerSpaceAPI;
using LavishScriptAPI;
using EQ2.ISXEQ2.Extensions;

namespace EQ2.ISXEQ2
{
    public class Radar : LavishScriptObject
    {
        #region Construct

        public Radar(LavishScriptObject obj)
            : base(obj)
        {
        }

        public Radar(params string[] args)
            : base(LavishScript.Objects.GetObject("Radar", args))
        {
        }

        public Radar(int index)
            : base(LavishScript.Objects.GetObject("Radar", index.ToString(CultureInfo.InvariantCulture)))
        {
        }

        public Radar()
            : base(LavishScript.Objects.GetObject("Radar", "1"))
        {
        }

        #endregion

        #region "Showing" Booleans

        /// <summary>
        /// True if the radar is showing the client
        /// </summary>
        public bool ShowingMe
        {
            get
            {
                return this.GetBoolFromLSO("ShowingMe");
            }
        }

        /// <summary>
        /// True if the radar is showing NPCs
        /// </summary>
        public bool ShowingNPCs
        {
            get
            {
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
                return this.GetBoolFromLSO("ShowingPCs");
            }
        }

        /// <summary>
        /// True if the radar is showing Specials
        /// </summary>
        public bool ShowingSpecials
        {
            get
            {
                return this.GetBoolFromLSO("ShowingSpecials");
            }
        }

        /// <summary>
        /// True if the radar is showing Resources
        /// </summary>
        public bool ShowingResources
        {
            get
            {
                return this.GetBoolFromLSO("ShowingResources");
            }
        }

        /// <summary>
        /// True if the radar is displaying NPCs that cannot be attacked
        /// </summary>
        public bool ShowingNoKillNPCs
        {
            get
            {
                return this.GetBoolFromLSO("ShowingNoKillNPCs");
            }
        }

        /// <summary>
        /// True if the radar is displaying corpses
        /// </summary>
        public bool ShowingCorpses
        {
            get
            {
                return this.GetBoolFromLSO("ShowingCorpses");
            }
        }

        /// <summary>
        /// True if the radar is showing labels
        /// </summary>
        public bool ShowingLabels
        {
            get
            {
                return this.GetBoolFromLSO("ShowingLabels");
            }
        }

        /// <summary>
        /// The name of the object on the radar
        /// </summary>
        public string Name
        {
            get
            {
                return this.GetStringFromLSO("Name");
            }
        }

        /// <summary>
        /// True if the radar is displaying Tradeskill units
        /// </summary>
        public bool ShowingTSUnits
        {
            get
            {
                return this.GetBoolFromLSO("ShowingTSUnits");
            }
        }

        /// <summary>
        /// True if the radar is displaying Aggro NPCs
        /// </summary>
        public bool ShowingAggroNPCs
        {
            get
            {
                return this.GetBoolFromLSO("ShowingAggroNPCs");
            }
        }

        /// <summary>
        /// True if the radar is showing Named NPCs
        /// </summary>
        public bool ShowingNamedNPCs
        {
            get
            {
                return this.GetBoolFromLSO("ShowingNamedNPCs");
            }
        }

        /// <summary>
        /// True if the radar is displaying pets
        /// </summary>
        public bool ShowingPets
        {
            get
            {
                return this.GetBoolFromLSO("ShowingPets");
            }
        }

        /// <summary>
        /// True if the radar is displating chests
        /// </summary>
        public bool ShowingChests
        {
            get
            {
                return this.GetBoolFromLSO("ShowingChests");
            }
        }

        /// <summary>
        /// True if the radar is showing doors
        /// </summary>
        public bool ShowingDoors
        {
            get
            {
                return this.GetBoolFromLSO("ShowingDoors");
            }
        }

        /// <summary>
        /// True if the radar is displaying unknowns
        /// </summary>
        public bool ShowingUnknowns
        {
            get
            {
                return this.GetBoolFromLSO("ShowingUnknowns");
            }
        }

        /// <summary>
        /// True if the radar is displaying client's pet
        /// </summary>
        public bool ShowingMyPet
        {
            get
            {
                return GetMember<bool>("ShowingMyPet");
            }
        }

        #endregion

        #region Custom Filter Data

        /// <summary>
        /// Returns the number of filters active on the radar
        /// </summary>
        public int NumCustomFilters
        {
            get
            {
                return GetMember<int>("NumCustomFilters");
            }
        }

        /// <summary>
        /// Returns true if the if the selected custom filter is active
        /// </summary>
        /// <param name="text">Custom Filter Name</param>
        /// <returns>If the custom filter is active</returns>
        public bool IsCustomFilter(string text)
        {
            return this.GetBoolFromLSO("CustomFilter", text);
        }

        /// <summary>
        /// Returns the filter at the selected index
        /// </summary>
        /// <param name="index">the index</param>
        /// <returns>custom filter</returns>
        public string CustomFilter(int index)
        {
            return this.GetStringFromLSO("CustomFilter", index.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// A list of the custom filters in effect
        /// </summary>
        public string CustomFiltersList
        {
            get
            {
                return this.GetStringFromLSO("CustomFiltersList");
            }
        }

        #endregion

        /// <summary>
        /// The value used for "zooming"
        /// </summary>
        public int Size
        {
            get
            {
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
                return this.GetBoolFromLSO("YAxisClippingOn");
            }
        }

        /// <summary>
        /// True if radius clipping is on
        /// </summary>
        public bool ClipRadiusOn
        {
            get
            {
                return this.GetBoolFromLSO("ClipRadiusOn");
            }
        }

        /// <summary>
        /// True if text clipping is on
        /// </summary>
        public bool ClippingTextOn
        {
            get
            {
                return this.GetBoolFromLSO("ClippingTextOn");
            }
        }

        /// <summary>
        /// True if radar rotation is on
        /// </summary>
        public bool RotationOn
        {
            get
            {
                return this.GetBoolFromLSO("RotationOn");
            }
        }

        /// <summary>
        /// True if labels are colorized
        /// </summary>
        public bool ColorizingLabels
        {
            get
            {
                return this.GetBoolFromLSO("ColorizingLabels");
            }
        }

        /// <summary>
        /// Toggles the custom filter "Show Me"
        /// </summary>
        public void FilterMe()
        {
            ExecuteMethod("FilterMe");
        }

        /// <summary>
        /// Toggles the custom filter "Show NPCs"
        /// </summary>
        public void FilterNPCs()
        {
            ExecuteMethod("FilterNPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show PCs"
        /// </summary>
        public void FilterPCs()
        {
            ExecuteMethod("FilterPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show Specials"
        /// </summary>
        public void FilterSpecials()
        {
            ExecuteMethod("FilterSpecials");
        }

        /// <summary>
        /// Toggles the custome filter "Show Resources"
        /// </summary>
        public void FilterResources()
        {
            ExecuteMethod("FilterResources");
        }

        /// <summary>
        /// Toggles the custom filter "Show No Kill NPCs"
        /// </summary>
        public void FilterNoKillNPCs()
        {
            ExecuteMethod("FilterNoKillNPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show Corpses"
        /// </summary>
        public void FilterCorpses()
        {
            ExecuteMethod("FilterCorpses");
        }

        /// <summary>
        /// Sets the "zoom" of the radar
        /// </summary>
        /// <param name="newSize">the new zoom</param>
        public void SetSize(int newSize)
        {
            ExecuteMethod("SetSize", newSize.ToString(CultureInfo.InvariantCulture));
        }

        /// <summary>
        /// Toggles the custom filter "Show Labels"
        /// </summary>
        public void ShowLabels()
        {
            ExecuteMethod("ShowLabels");
        }

        /// <summary>
        /// Toggles the custom filter "Y-axis Clipping"
        /// </summary>
        public void YAxisClipping()
        {
            ExecuteMethod("YAxisClipping");
        }

        /// <summary>
        /// Toggles the custom filter "Show Text"
        /// </summary>
        public void ClipText()
        {
            ExecuteMethod("ClipText");
        }

        /// <summary>
        /// Toggles the custom filter "Clip Radius"
        /// </summary>
        public void ClipRadius()
        {
            ExecuteMethod("ClipRadius");
        }

        /// <summary>
        /// Toggles radar rotation
        /// </summary>
        public void Rotation()
        {
            ExecuteMethod("Rotation");
        }

        /// <summary>
        /// Used to toggle a specific custom filter
        /// </summary>
        /// <param name="filter">The selected filter to toggle</param>
        public void SetCustomFilter(string filter)
        {
            ExecuteMethod("SetCustomFilter", filter);
        }

        /// <summary>
        /// Toggles the custom filter "Show Tradeskill"
        /// </summary>
        public void FilterTSUnits()
        {
            ExecuteMethod("FilterTSUnits");
        }

        /// <summary>
        /// Toggles the custom filter "Show Aggro"
        /// </summary>
        public void FilterAggroNPCs()
        {
            ExecuteMethod("FilterAggroNPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show Named"
        /// </summary>
        public void FilterNamedNPCs()
        {
            ExecuteMethod("FilterNamedNPCs");
        }

        /// <summary>
        /// Toggles the custom filter "Show Pets"
        /// </summary>
        public void FilterPets()
        {
            ExecuteMethod("FilterPets");
        }

        /// <summary>
        /// Toggles the custom filter "Show My Pet"
        /// </summary>
        public void FilterMyPet()
        {
            ExecuteMethod("FilterMyPet");
        }

        /// <summary>
        /// Toggles the custom filter "Show Chests"
        /// </summary>
        public void FilterChests()
        {
            ExecuteMethod("FilterChests");
        }

        /// <summary>
        /// Toggles the custom filter "Show Doors"
        /// </summary>
        public void FilterDoors()
        {
            ExecuteMethod("FilterDoors");
        }

        /// <summary>
        /// Toggles the custom filter "Show Unknowns"
        /// </summary>
        public void FilterUnknowns()
        {
            ExecuteMethod("FilterUnknowns");
        }

        /// <summary>
        /// Toggles the custom filter "Show Con Color"
        /// </summary>
        public void ColorizeLabels()
        {
            ExecuteMethod("ColorizeLabels");
        }

    }
}
