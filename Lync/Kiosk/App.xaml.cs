﻿/* Copyright (C) 2012 Modality Systems - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the Microsoft Public License, a copy of which 
 * can be seen at: http://www.microsoft.com/en-us/openness/licenses.aspx
 * 
 * http://www.LyncAutoAnswer.com
*/

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Diagnostics;
using GalaSoft.MvvmLight.Threading;

namespace SuperSimpleLyncKiosk
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Get Reference to the current Process
            Process me = Process.GetCurrentProcess();
			var processCount = Process.GetProcessesByName(me.ProcessName).Length;
			// Check how many total processes have the same name as the current one
			if (processCount > 2)
            {
                Application.Current.Shutdown();
                return;
            }

			DispatcherHelper.Initialize();

			base.OnStartup(e);
        }

    }
}
