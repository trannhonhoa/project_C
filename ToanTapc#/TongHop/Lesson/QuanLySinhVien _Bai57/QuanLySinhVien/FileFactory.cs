using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using QuanLySinhVien.modal;
namespace QuanLySinhVien
{
    public class FileFactory
    {
        public static bool SaveFile(Dictionary<string, Khoa> csdl, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bft = new BinaryFormatter();
                bft.Serialize(fs, csdl);
                fs.Close();
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        public static Dictionary<string, Khoa> DocFile(string path)
        {
            Dictionary<string, Khoa> csdl = new Dictionary<string, Khoa>();
            try 
	        {	        
		        FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter btf = new BinaryFormatter();
                object data = btf.Deserialize(fs);
                csdl = data as Dictionary<string, Khoa>;
                fs.Close();
                return csdl;

	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
        }
    }
}
