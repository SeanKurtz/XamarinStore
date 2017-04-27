using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XamarinFormStore.Assets.Forms;

namespace XamarinFormStore
{
    public partial class App : Application
    {
        static MasterDetailPage MasterPage;
        static NavigationPage NavPage;
        public App()
        {
            NavPage = new NavigationPage(new XamarinFormStore.Assets.Forms.MainPage());

            MasterPage.Detail = NavPage;
            MasterPage.Master = new XamarinFormStore.Assets.Forms.MainPage();

            this.MainPage = MasterPage;
            
        }
        /*public static ItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("ToDo.db3"));
                }
                return database;
            }
        }
        */

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

    }
}
