﻿#pragma checksum "C:\Users\Admin\source\repos\Musique\Musique\View\CreateSong.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "99A9F927EC8FCC3BCF981D46CFD84214"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Musique.View
{
    partial class CreateSong : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\CreateSong.xaml line 60
                {
                    this.SongName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3: // View\CreateSong.xaml line 62
                {
                    this.Description = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4: // View\CreateSong.xaml line 64
                {
                    this.Singer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 5: // View\CreateSong.xaml line 66
                {
                    this.Author = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 6: // View\CreateSong.xaml line 68
                {
                    this.ThumbnailUrl = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7: // View\CreateSong.xaml line 70
                {
                    this.Link = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8: // View\CreateSong.xaml line 72
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.CreateMySong;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

