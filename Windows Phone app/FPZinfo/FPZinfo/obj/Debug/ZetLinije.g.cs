﻿#pragma checksum "c:\users\eugen\Desktop\C# projects\FPZinfo\FPZinfo\ZetLinije.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A0D7F997DE2AC3B586A7CBB84BC8213"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FPZinfo {
    
    
    public partial class ZetLinije : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.TextBlock bus2;
        
        internal System.Windows.Controls.TextBlock bus1;
        
        internal System.Windows.Controls.Button potvrda;
        
        internal System.Windows.Controls.TextBlock linija;
        
        internal System.Windows.Controls.ProgressBar progress1;
        
        internal System.Windows.Controls.ProgressBar progress2;
        
        internal System.Windows.Controls.Button zaustavi;
        
        internal System.Windows.Controls.CheckBox Check1;
        
        internal System.Windows.Controls.CheckBox Check2;
        
        internal System.Windows.Controls.CheckBox Check3;
        
        internal System.Windows.Controls.CheckBox Check4;
        
        internal System.Windows.Controls.TextBlock datum1;
        
        internal System.Windows.Controls.TextBlock dan1;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FPZinfo;component/ZetLinije.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.bus2 = ((System.Windows.Controls.TextBlock)(this.FindName("bus2")));
            this.bus1 = ((System.Windows.Controls.TextBlock)(this.FindName("bus1")));
            this.potvrda = ((System.Windows.Controls.Button)(this.FindName("potvrda")));
            this.linija = ((System.Windows.Controls.TextBlock)(this.FindName("linija")));
            this.progress1 = ((System.Windows.Controls.ProgressBar)(this.FindName("progress1")));
            this.progress2 = ((System.Windows.Controls.ProgressBar)(this.FindName("progress2")));
            this.zaustavi = ((System.Windows.Controls.Button)(this.FindName("zaustavi")));
            this.Check1 = ((System.Windows.Controls.CheckBox)(this.FindName("Check1")));
            this.Check2 = ((System.Windows.Controls.CheckBox)(this.FindName("Check2")));
            this.Check3 = ((System.Windows.Controls.CheckBox)(this.FindName("Check3")));
            this.Check4 = ((System.Windows.Controls.CheckBox)(this.FindName("Check4")));
            this.datum1 = ((System.Windows.Controls.TextBlock)(this.FindName("datum1")));
            this.dan1 = ((System.Windows.Controls.TextBlock)(this.FindName("dan1")));
        }
    }
}
