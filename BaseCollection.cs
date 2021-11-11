using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BelyaevaTank
{
    public class BaseCollection
    {
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();
        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separator = ':';
        public BaseCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));

        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }
        
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }   
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"BaseCollection", sw);       
                foreach (var level in parkingStages)
                {
                    sw.WriteLine($"Base{separator}{level.Key}", sw);
                    ITransport vehicle = null;
                    for (int i = 0; (vehicle = level.Value.GetNext(i)) != null; i++)
                    {
                        if (vehicle != null)
                        {
                            if (vehicle.GetType().Name == "ArmoredCar")
                            {
                                sw.Write($"ArmoredCar{separator}", sw);                        
                            }

                            if (vehicle.GetType().Name == "Tank")
                            {
                                sw.Write($"Tank{separator}", sw);                             
                            }
                            //Записываемые параметры
                            sw.WriteLine(vehicle + "", sw);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
          
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                if ((line = sr.ReadLine()) != null) 
                {
                    if (line.Contains("BaseCollection"))
                    {
                        parkingStages.Clear();
                    }
                    else 
                    {
                        return false;
                    }

                    Vehicle vehicle = null;
                    string key = string.Empty;

                    while ((line = sr.ReadLine()) != null) 
                    {
                        if (line.Contains("Base")) 
                        {
                            key = line.Split(separator)[1];
                            parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Split(separator)[0] == "ArmoredCar")
                        {
                            vehicle = new ArmoredCar(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Tank")
                        {
                            vehicle = new Tank(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + vehicle;
                        if (result == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
