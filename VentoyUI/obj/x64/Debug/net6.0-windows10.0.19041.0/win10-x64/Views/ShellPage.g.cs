﻿#pragma checksum "E:\Users\Shomn\Downloads\Ventoy(1)\Ventoy(1)\VentoyUI\Views\ShellPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D46078CACDFACB5E1F4A41DA136150BB6ACDD619AD4B205966B98F842EE4BA5"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentoyUI.Views
{
    partial class MainPage : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Views\ShellPage.xaml line 12
                {
                    this.ContentArea = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // Views\ShellPage.xaml line 17
                {
                    this.Pages = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 4: // Views\ShellPage.xaml line 42
                {
                    this.Commands3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBar>(target);
                }
                break;
            case 5: // Views\ShellPage.xaml line 44
                {
                    this.Setting3 = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.Setting3).Click += this.Setting_Click;
                }
                break;
            case 6: // Views\ShellPage.xaml line 28
                {
                    this.Commands = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.CommandBar>(target);
                }
                break;
            case 7: // Views\ShellPage.xaml line 29
                {
                    this.StartInstall = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.StartInstall).Click += this.StartInstall_Click;
                }
                break;
            case 8: // Views\ShellPage.xaml line 30
                {
                    this.Update = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.AppBarButton>(target);
                    ((global::Microsoft.UI.Xaml.Controls.AppBarButton)this.Update).Click += this.Update_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

