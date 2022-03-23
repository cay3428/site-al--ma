using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace genel_methodlar
{
    class listem<T>
    {
        public listem()
        {
            items = new T[0];

        }


        T[] items;
        public void Ekle(T item)
        {
            T[] Geçici = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < Geçici.Length; i++)
            {
                items[i] = Geçici[i];
            }

            items[items.Length - 1] = item;
        }

        public T[] Items
        {
            get { return items; }
        }


    }
    }

