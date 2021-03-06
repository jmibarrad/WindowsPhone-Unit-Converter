﻿using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace UnitConverter
{

    public static class MyGlobals
    {
        public static int Total = 3;
    }
    public partial class App : Application
    {
       
        public PhoneApplicationFrame RootFrame { get; private set; }

      
        public App()
        {
            UnhandledException += Application_UnhandledException;
            InitializeComponent();

            InitializePhoneApplication();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Application.Current.Host.Settings.EnableFrameRateCounter = false;

                //Application.Current.Host.Settings.EnableCacheVisualization = true；

                PhoneApplicationService.Current.UserIdleDetectionMode = IdleDetectionMode.Disabled;
            }

        }


        private void Application_Launching(object sender, LaunchingEventArgs e)
        {
        }

 
        private void Application_Activated(object sender, ActivatedEventArgs e)
        {
        }

      
        private void Application_Deactivated(object sender, DeactivatedEventArgs e)
        {
        }

        
        private void Application_Closing(object sender, ClosingEventArgs e)
        {
        }

        private void RootFrame_NavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Break();
            }
        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Break();
            }
        }


        private bool phoneApplicationInitialized = false;

        private void InitializePhoneApplication()
        {
            if (phoneApplicationInitialized)
                return;

 
            RootFrame = new TransitionFrame();
            RootFrame.Navigated += CompleteInitializePhoneApplication;

            RootFrame.NavigationFailed += RootFrame_NavigationFailed;

            phoneApplicationInitialized = true;
        }

        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            if (RootVisual != RootFrame)
                RootVisual = RootFrame;

            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }

    }
}