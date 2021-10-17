using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
namespace Buoi6_Bai4
{
    public class FileSerializable
    {
        public static bool SaveFile(List<SinhVien> dssv, string path){
            try{
                FileStream fs = new FileStream(path, FileMode.CreateNew);
                BinaryFormatter btf = new BinaryFormatter();
                btf.Serialize(fs, dssv);
                fs.Close();
                return true;
            }
            catch(Exception){
                throw;
            }
        }
        public static List<SinhVien> DocFile(string path)
        {
            try
            {
                List<SinhVien> dssv = new List<SinhVien>();
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter btf = new BinaryFormatter();
                object data = btf.Deserialize(fs);
                dssv = data as List<SinhVien>;
                return dssv;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
