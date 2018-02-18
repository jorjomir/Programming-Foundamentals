using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache = new Dictionary<string, Dictionary<string, int>>();
            var data = new Dictionary<string, Dictionary<string,int>>();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(new char[] { '-', '>', '|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (cmd[0]== "thetinggoesskrra")
                {
                    break;
                }
                //DataKey-DataSize-DataSet
                if (cmd.Length>1)
                {
                    string dataKey = cmd[0];
                    int dataSize = int.Parse(cmd[1]);
                    string dataSet = cmd[2];
                    //If there's existing DataSet
                    if (data.ContainsKey(dataSet))
                    {
                        data[dataSet].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (cache.ContainsKey(dataSet))
                        {
                            cache[dataSet].Add(dataKey, dataSize);
                        }
                        else
                        {
                            cache.Add(dataSet, new Dictionary<string, int>());
                        }

                        
                    }
                }
                else if(cmd[0]!= "thetinggoesskrra" && cmd.Length==1)
                {
                    //If there's not cache for this dataset
                    if (!data.ContainsKey(cmd[0]))
                    {
                        data.Add(cmd[0], new Dictionary<string, int>());
                    }
                    //If there is CACHE
                    else if (cache.ContainsKey(cmd[0]))
                    {
                        data.Add(cmd[0], new Dictionary<string, int>());
                        //data[cmd[0]].Add(cac)
                        foreach (var item in cache[cmd[0]])
                        {
                            data[cmd[0]].Add(item.Key, item.Value);
                        }
                    }

                }
            }
            List<int> sums = new List<int>();
            foreach (var item in data)
            {
                //var total = data[item.Key].Values.Sum(d => d.Sum());
                var totalsize = data[item.Key].Values.Sum();
                sums.Add(totalsize);
            }
            int position;
            for (int i = 1; i < sums.Count; i++)
            {
                if (sums[i]>sums[i-1])
                {
                    position = i;
                }
            }
            for (int i = po; i < length; i++)
            {

            }
            foreach (var item in data)
            {
                foreach (var el in data[item.Key])
                {
                    Console.WriteLine($"{item.Key} - {el.Key} - {el.Value}");
                }
            }
        }
    }
}
