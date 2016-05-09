using EmployeeMobileApp.AppCode;
using EmployeeMobileApp.Layout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EmployeeMobileApp
{
	public class App : Application
	{
        static DataAccess dbUtils;
        public App ()
		{
            // The root page of your application
            //MainPage = new ContentPage {
            //	Content = new StackLayout {
            //		VerticalOptions = LayoutOptions.Center,
            //		Children = {
            //			new Label {
            //				HorizontalOptions = LayoutOptions.Center,
            //				Text = "Welcome to Xamarin Forms!"
            //			}
            //		}
            //	}
            //};
            MainPage = new NavigationPage(new ManageEmployee());
        }
        public static DataAccess DAUtil
        {
            get
            {
                if (dbUtils == null)
                {
                    dbUtils = new DataAccess();
                }
                return dbUtils;
            }
        }
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
