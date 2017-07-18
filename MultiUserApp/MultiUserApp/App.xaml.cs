using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Amazon;
using Amazon.CognitoIdentity;
using Xamarin.Forms;

namespace MultiUserApp
{
	public partial class App : Application
	{
        CognitoAWSCredentials credentials = new CognitoAWSCredentials(
            Constants.CognitoIdentityPoolId, // Identity pool ID
            RegionEndpoint.USWest2 // Region
        );

        public App ()
		{
			InitializeComponent();
            // Initialize the Cognito Sync client
            //CognitoSyncManager syncManager = new CognitoSyncManager(credentials,
            //    new AmazonCognitoSyncConfig{
            //        RegionEndpoint = RegionEndpoint.USWest2 // Region
            //    }
            //);
            //// Create a record in a dataset and synchronize with the server
            //Dataset dataset = syncManager.OpenOrCreateDataset("myDataset");
            //dataset.OnSyncSuccess += SyncSuccessCallback;
            //dataset.Put("myKey", "myValue");
            //dataset.SynchronizeAsync();

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
