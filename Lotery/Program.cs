using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lotery
{
    class Program
    {
        static void Main(string[] args)
        {
            bool work = true;

            while (work) {

                Console.WriteLine("Запишите информацию в файл");
                Console.WriteLine("Введите кол-во билетов");
                int ticets;
                while ((!int.TryParse(Console.ReadLine(), out ticets) || ticets < 0))
                {
                    Console.WriteLine("Ошибка ввода! Введите число");
                }

                List<List<Person>> spisokpobeitelei = new List<List<Person>>();
                List<Person> winners = new List<Person>();


                int count = 0;

                using (StreamReader reader = new StreamReader(@"Students.txt"))
                {

                    while (reader.ReadLine() != null)
                    {
                        count++;


                    }
                    reader.Close();

                }

                List<Person> people = new List<Person>();

                using (StreamReader reader = new StreamReader(@"Students.txt"))
                {
                    int temp = 0;
                    while (temp < count)
                    {

                        if (temp == 0)
                        {
                            string bilet = reader.ReadLine();

                        }
                        else
                        {
                            string[] stroki = reader.ReadLine().ToLower().Split(' ').ToArray();

                            for (int i = 0; i < stroki.Length; i++)
                            {
                                people.Add(new Person(stroki[i], stroki[i++], 10));
                                i++;
                            }
                        }
                        temp++;
                    }

                }

                for (int i =0; i < spisokpobeitelei.Count;i++)
                {
                    for (int r = 0; r < spisokpobeitelei[i].Count; r++)
                    {
                        for (int t= 0; t < winners.Count; t++)
                        {
                            for (int p = 0; p < people.Count; p++)
                            {

                                if (people[p].Name.Equals(winners[t].Name))
                                {
                                    if (i > 1)
                                    {
                                        people[p].Points -= 3;
                                    }

                                    else if (i > 2)
                                    {
                                        people[p].Points -= 2;
                                    }

                                    else if (i > 3)
                                    {
                                        people[p].Points -= 1;
                                    }
                                }
                            }
                        }
                    }
                }




                double schet = 0;
                for (int i = 0; i < people.Count; i++)
                {
                    schet += people[i].Points;
                }

                double ver = 100 / schet;

                double[] mas = new double[people.Count];

                for (int i = 0; i < people.Count; i++)
                {
                  mas[i] =  people[i].Points * ver;
                }

                Random random = new Random();

                int value = random.Next(0, 100);
               

                int flag = 0;
                while (flag < ticets) {

                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (value >= mas[i])
                        {
                            winners.Add(people[i - 1]);
                            break;
                        }
                    }

                }

                spisokpobeitelei.Add(winners);

             
















            }
        }
    }
}
