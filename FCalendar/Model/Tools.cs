using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Windows.Security.Cryptography.Core;
using Windows.Security.Cryptography;
using Windows.Storage.Streams;
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
        public async void AddLog (string log)
        {
            logfile = await folder.CreateFileAsync("Logfile.text",   CreationCollisionOption.OpenIfExists);
            await FileIO.WriteTextAsync(logfile, log);
        }
        async void SaveHostsToFile (ObservableCollection<Host> events)
        {   

        }
    }
}
