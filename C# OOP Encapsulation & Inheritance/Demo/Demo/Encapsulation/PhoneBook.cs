using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Encapsulation
{
    internal struct  PhoneBook
    {
        #region Attributes
        string[] names;
        int[] numbers;
        int size;
        #endregion

        #region Constructors
        public PhoneBook(int s)
        {
            this.size = s;
            this.names = new string[s];
            this.numbers = new int[s];
        }
        #endregion

        #region Properties
        public int Size
        {
            get { return size; }
            // set { Size = value; } // it's array size [fixed] No Need for Change
        }

        //===========================================================Indexer============================================= 
        // PhoneBook["Somaya"] ==> Return Number ==> Indexer
        // indexer ==> Special Property
        // 1. Named with [This] // Caller 
        // 2. can take Parameters
        public int this[string name]
        {
            get
            {
                if(names != null && numbers != null)
                {
                    for(int i = 0; i < names.Length; i++)
                    {
                        if(names[i] == name)
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;
            }

            set
            {
                if (names != null && numbers != null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (names[i] == name)
                        {
                            numbers[i] = value;
                            break;
                        }
                    }
                }
            }

        }

        public string this [ int ind]  //Indexer Overloading
        {
            get
            {
                return $"{ind} : : {names[ind]} : : {numbers[ind]}";
            }
        }
        #endregion

        #region Methods
        // Add new Person into Note
        // Object Member Function ==> Non Static
        public void AddPerson(int Position , string name, int number )
        {
            if(numbers != null && names != null )
            {
                if(Position < size)
                {
                    names[Position] = name;
                    numbers[Position] = number;
                }
            }
        }
        #endregion

        #region Setter & Getter for Array Attribute (Not Recommended)
        // Getter
        public int GetPersonNumber(string name)
        {
            if (names != null && numbers != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        return numbers[i];
                    }
                }
            }
            return -1;
        }

        //Setter
        public void SetPersonNumber(string name, int NewNum)
        {
            if (names != null && numbers != null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                    {
                        numbers[i] = NewNum;
                        break;
                    }
                }
            }
        }
        #endregion


    }
}
