﻿

#pragma checksum "C:\Users\aldanvy\Documents\Git\ARDroneSDK\ARDrone2.Sample.W8\FlyPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C8DD54C4E1B7983CA258AB2356E333FA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARDrone2.Sample
{
    partial class FlyPage : global::ARDrone2.Sample.Common.LayoutAwarePage, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 16 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.FrameworkElement)(target)).Loaded += this.Page_OnLoaded;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 115 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.TakeOffLandButton_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 52 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PlayAnimationButton_Click;
                 #line default
                 #line hidden
                break;
            case 4:
                #line 53 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.PlayLedAnimationButton_Click;
                 #line default
                 #line hidden
                break;
            case 5:
                #line 54 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.StartVideoRecordingButton_Click;
                 #line default
                 #line hidden
                break;
            case 6:
                #line 55 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.StopVideoRecordingButton_Click;
                 #line default
                 #line hidden
                break;
            case 7:
                #line 45 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.TakePicture_Click;
                 #line default
                 #line hidden
                break;
            case 8:
                #line 46 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ResetEmergency_Click;
                 #line default
                 #line hidden
                break;
            case 9:
                #line 47 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.Configuration_Click;
                 #line default
                 #line hidden
                break;
            case 10:
                #line 48 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SwitchIndoorOutdoor_Click;
                 #line default
                 #line hidden
                break;
            case 11:
                #line 49 "..\..\..\FlyPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.SwitchVideoChannel_Click;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


