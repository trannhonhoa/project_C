﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
namespace DocGhiFileSerialize
{
    public class FileFactory
    {
        public static bool LuuFile(List<SinhVien> dssv, string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, dssv);
                fs.Close();
                return true;
            }

            catch (Exception)
            {

                throw;
            }
        }
        public static List<SinhVien> DocFile(string path)
        {
            List<SinhVien> dssv = new List<SinhVien>();
            try 
	        {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                object data = bf.Deserialize(fs);
                dssv = data as List<SinhVien>;
                fs.Close();
                return dssv;
	        }
	        catch (Exception)
	        {
		
		        throw;
	        }
        }
    }
}
