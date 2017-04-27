using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormStore.Droid;
using XamarinFormStore.Assets.Data;

[assembly: Dependency(typeof(FileHelper))]
namespace XamarinFormStore.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}