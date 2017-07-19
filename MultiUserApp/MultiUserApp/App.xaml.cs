using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.CognitoIdentity;
using Xamarin.Forms;

using MultiUserApp.Models;
using MultiUserApp.Utils;
using MultiUserApp.ViewModels;


namespace MultiUserApp
{
	public partial class App : Application
	{
        CognitoAWSCredentials credentials = new CognitoAWSCredentials(
            Constants.COGNITO_IDENTITY_POOL_ID, // Identity pool ID
            Constants.COGNITO_REGION // Region
        );
        public static User User { get; set; }
        public static HorseProfileManager HorseManager { get; private set; }

        public App ()
		{
            HorseManager = new HorseProfileManager(new SimpleDBStorage());
            User = new User();

            MainPage = new MultiUserApp.MainPage();
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
