using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using EQ2.ISXEQ2;
using LavishVMAPI;

namespace ISXEQ2WrapperTest
{
    public partial class MainWindow : Window
    {
        private void TestISXEQ2TLO()
        {
            var success = true;
            TextBoxISXEQ2TLOResult.Text = "TESTING";
            TextBoxISXEQ2TLOResult.Foreground = Brushes.Yellow;
            var item = "[ISXEQ2TLO] ";
            var result = String.Empty;
            Log(item + "Starting test of ISXEQ2 Top Level Object.");
            Log(item + "Testing Version...");
            using (new FrameLock(true))
            {
                var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                result = isxeq2.Version;
                if(result != null)
                    Log(item + result);
                else
                {
                    Log(item + "Version FAILED!");
                    TextBoxISXEQ2TLOResult.Text = "FAILED";
                    TextBoxISXEQ2TLOResult.Foreground = Brushes.Red;
                }
            }
        }

        private void TestTLO(string TLO)
        {
            var success = true;
            var item = "[" + TLO + "]";
            bool dummybool;
            var result = String.Empty;
            TextBoxToggle(TLO, Testing, Brushes.Yellow);
            Log(item + "Starting test of " + TLO +" Top Level Object.");
            switch (TLO)
            {
                case "ISXEQ2":
                    Log(item + "Testing Version...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.Version;
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "Version FAILED!");                            
                            success = false;
                        }
                    }
                    result = String.Empty;
                    Log(item + "Testing IsReady...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.IsReady.ToString();
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "IsReady FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing AddLoc...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.AddLoc("Test");
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "AddLoc FAILED!");
                            success = false;
                        }
                    }
                    result = String.Empty;
                    Log(item + "Testing EQ2LocsCount...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.EQ2LocsCount.ToString();
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "EQ2LocsCount FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing AddLoc with Notes");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.AddLoc("Test0", "Test");
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "AddLoc with Notes FAILED!");
                            success = false;
                        }
                    }
                    result = String.Empty;
                    Log(item + "Testing EQ2LocsCountAllZones...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.EQ2LocsCountAllZones.ToString();
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "EQ2LocsCountAllZones FAILED!");
                            success = false;
                        }
                    }
                    result = String.Empty;
                    Log(item + "Testing IsValidEQ2PressKey...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.IsValidEQ2PressKey("w").ToString();
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "IsValidEQ2PressKey FAILED!");
                            success = false;
                        }
                    }
                    result = String.Empty;
                    Log(item + "Testing IsValidEQ2PressKey...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.IsValidEQ2PressKey("w").ToString();
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "IsValidEQ2PressKey FAILED!");
                            success = false;
                        }
                    }
                    result = String.Empty;
                    Log(item + "Testing InitializingActorEffects...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.InitializingActorEffects.ToString();
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "InitializingActorEffects FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing EnableAfflictionEvents...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.EnableAfflictionEvents();
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "EnableAfflictionEvents FAILED!");
                            success = false;
                        }
                    }
                    result = String.Empty;
                    Log(item + "Testing AfflictionEventsOn...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.AfflictionEventsOn.ToString();
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "AfflictionEventsOn FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing DisableAfflictionEvents...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.DisableAfflictionEvents();
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "DisableAfflictionEvents FAILED!");
                            success = false;
                        }
                    }
                    result = String.Empty;
                    Log(item + "Testing AfflictionEventsOn...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        result = isxeq2.AfflictionEventsOn.ToString();
                        if (result != String.Empty)
                            Log(item + result);
                        else
                        {
                            Log(item + "AfflictionEventsOn FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing SetAfflictionEventsTimeInterval...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.SetAfflictionEventsTimeInterval(250);
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "SetAfflictionEventsTimeInterval FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing EnableActorEvents...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.EnableActorEvents();
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "EnableActorEvents FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing DisableActorEvents...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.DisableActorEvents();
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "DisableActorEvents FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing SetActorEventsRange...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.SetActorEventsRange(30f);
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "SetActorEventsRange FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing Popup...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.Popup("Test", "Test", "Test");
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "Popup FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing EnduringBreath...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.EnduringBreath(ISXEQ2.BenefitToggle.Enable);
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "EnduringBreath FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing EnduringBreath...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.EnduringBreath(ISXEQ2.BenefitToggle.Disable);
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "EnduringBreath FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing NoFog...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.NoFog(ISXEQ2.BenefitToggle.Enable);
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "NoFog FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing NoFog...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.NoFog(ISXEQ2.BenefitToggle.Disable);
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "NoFog FAILED!");
                            success = false;
                        }
                    }
                    dummybool = false;
                    Log(item + "Testing ResetInternalVendingSystem...");
                    using (new FrameLock(true))
                    {
                        var isxeq2 = new EQ2.ISXEQ2.ISXEQ2();
                        dummybool = isxeq2.ResetInternalVendingSystem();
                        if (dummybool)
                            Log(item + dummybool.ToString());
                        else
                        {
                            Log(item + "ResetInternalVendingSystem FAILED!");
                            success = false;
                        }
                    }
                    break;
                default:
                    break;
            }
            if (success)
            {
                Log(item + " " + Passed);
                TextBoxToggle(TLO, Passed, Brushes.Green);
            }
            else
            {
                Log(item + " " + Failed);
                TextBoxToggle(TLO, Failed, Brushes.Red);
            }
        }

        private void TextBoxToggle(string TLO, string condition, Brush color)
        {
            switch (TLO)
            {
                case "ISXEQ2":
                    TextBoxISXEQ2TLOResult.Text = condition;
                    TextBoxISXEQ2TLOResult.Foreground = color;
                    break;
                default:
                    break;
            }
        }
    }
}
