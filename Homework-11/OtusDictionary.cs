using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_11
{
    internal class OtusDictionary
    {
        public int Key { get; set; }
        public string Value { get; set; }

        //Счётчик
        static int countDictionari = 0;
        //Размер масива
        public static int size = 32;
        //Масив для хранения
        public OtusDictionary[] dictionaries = new OtusDictionary[size];

        //Индексатор экземпляров класса
        //public OtusDictionary this [int i] 
        //{
        //    get { return dictionaries[i]; }
        //    set { dictionaries[i] = value; }
        //}

        //Добавление 
        public void Add(int key, string value)
        {
            for (int i = 0; i < countDictionari; i++)
            {
                try
                {
                    if (dictionaries[i].Key == key) throw new DuplicateKeyException($"Дубль ключа! Key - {key}\n");
                }
                catch (DuplicateKeyException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                
            }

            if (value != null)
            {
                //Новый экземпляр класса
                OtusDictionary otusDictionary = new OtusDictionary();

                //При полном заполнении масива, увеличиваем. 
                if (countDictionari == size)
                {
                    size *= 2;
                    Array.Resize(ref dictionaries, size);
                }

                otusDictionary.Key= key;
                otusDictionary.Value = value;
                dictionaries[countDictionari] = otusDictionary;
                countDictionari++;
            }
        }

        //Получение
        public string Get(int key)
        {
            for (int i = 0; i < countDictionari; i++)
            {
                try
                {
                    if (dictionaries[i].Key == key)
                    {
                        return dictionaries[i].Value;
                    }
                }
                catch (Exception)
                {
                }
                
            }

            return "Kлюч не найден";
        }
    }
}
