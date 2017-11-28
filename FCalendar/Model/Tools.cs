using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Security.Cryptography;
using Windows.Storage.Streams;
using Newtonsoft.Json;
using Windows.Storage;
using System.Collections.ObjectModel;

namespace FCalendar.Model
{
    public abstract class Tools
    {
        public static StorageFolder folder = ApplicationData.Current.LocalFolder;
        public static StorageFile logfile;
        public static StorageFile EventList;
        public static StorageFile HostList;
        public static StorageFile AdminList;
        public static string TempStringHost;
        public static string TempStringEvent;
        public static string TempStringAdmin;
        public static string HashPassword(string toBeHashed)
        {
            {
                var alg = HashAlgorithmProvider.OpenAlgorithm(HashAlgorithmNames.Md5);
                IBuffer buff = Windows.Security.Cryptography.CryptographicBuffer.ConvertStringToBinary(toBeHashed, BinaryStringEncoding.Utf8);
                var hashed = alg.HashData(buff);
                var res = CryptographicBuffer.EncodeToHexString(hashed);
                return res;
            }
        }
        public static bool ComparePassword(string pass, string hash)
        {
            if (HashPassword(pass) == hash)
            {
                return true;
            }
            else return false;
        }
        public static async void AddLog(string log)
        {
            logfile = await folder.CreateFileAsync("Logfile.text", CreationCollisionOption.OpenIfExists);
            await FileIO.WriteTextAsync(logfile, log);
        }
        static async void SaveHostsToFile(ObservableCollection<Host> hostslist)
        {
            string json = JsonConvert.SerializeObject(hostslist, Formatting.Indented);
            HostList = await folder.CreateFileAsync("HostsList.json", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(HostList, json);
        }
        private static async void GetHostsStringFromJson ()
        {
            //HostList = await folder.CreateFileAsync("HostsList.json", CreationCollisionOption.OpenIfExists);
            string json = await FileIO.ReadTextAsync(HostList);
            TempStringHost = json;
        }
        public static ObservableCollection<Host> GetHostListFromFile()
        {
            GetHostsStringFromJson();
            ObservableCollection<Host> returnedlist;
            returnedlist = JsonConvert.DeserializeObject<ObservableCollection<Host>>(TempStringHost);
            return returnedlist;
        }

        static async void SaveAdminToFile(ObservableCollection<Admin> adminlist)
        {
            string json = JsonConvert.SerializeObject(adminlist, Formatting.Indented);
            AdminList = await folder.CreateFileAsync("AdminList.json", CreationCollisionOption.ReplaceExisting);
            await FileIO.WriteTextAsync(AdminList, json);
        }
        private static async void GetAdminsStringFromJson()
        {
            //HostList = await folder.CreateFileAsync("HostsList.json", CreationCollisionOption.OpenIfExists);
            string json = await FileIO.ReadTextAsync(AdminList);
            TempStringAdmin = json;
        }
        public static ObservableCollection<Admin> GetAdminListFromFile()
        {
            GetAdminsStringFromJson();
            ObservableCollection<Admin> returnedlist;
            returnedlist = JsonConvert.DeserializeObject<ObservableCollection<Admin>>(TempStringAdmin);
            return returnedlist;
        }

    }
}
