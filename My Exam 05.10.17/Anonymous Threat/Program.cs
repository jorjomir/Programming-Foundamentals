using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(' ').ToList();
            StringBuilder s = new StringBuilder();
            while (true)
            {
                string[] cmd = Console.ReadLine().Split(' ').ToArray();
                if (cmd[0]=="3:1")
                {
                    break;
                }
                if (cmd[0]=="merge")
                {
                    int startindex = int.Parse(cmd[1]);
                    int endindex = int.Parse(cmd[2]);
                    if (endindex>list.Count)
                    {
                        endindex = list.Count - 1;
                    }
                    if (startindex<0)
                    {
                        startindex = 0;
                    }
                    List<string> nums = new List<string>();
                    //s = list[startindex];
                    for (int i = startindex+1; i <= endindex; i++)
                    {
                        list[startindex] = $"{list[startindex]}" + $"{list[i]}";
                        nums.Add(list[i]);
                    }
                    foreach (var item in nums)
                    {
                        list.Remove(item);
                    }
                }
                if (cmd[0]=="divide")
                {
                    int index = int.Parse(cmd[1]);
                    int partitions = int.Parse(cmd[2]);
                    string word = list[index];
                    int wordLength = word.Length;
                    list.Remove(word);
                    if (wordLength%partitions==0)
                    {
                        string splittedword = word;
                        int dividelength = wordLength / partitions;
                        int pos = 0;
                        for (int i = 0; i < partitions; i++)
                        {
                            list.Insert(index, word.Substring(pos, dividelength));
                            pos += dividelength;
                            index++;
                        }           
                    }
                    else
                    {
                        int pos = 0;
                        int dividelength = wordLength / partitions;
                        int leftpart = wordLength % partitions;
                        for (int i = 0; i < partitions; i++)
                        {
                            if (i==partitions-1)
                            {
                                list.Insert(index, word.Substring(pos, dividelength+leftpart));
                            }
                            else
                            {
                                list.Insert(index, word.Substring(pos, dividelength));
                                pos += dividelength;
                                index++;
                            }

                        }
                    }

                }
            }
            foreach (var item in list)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
