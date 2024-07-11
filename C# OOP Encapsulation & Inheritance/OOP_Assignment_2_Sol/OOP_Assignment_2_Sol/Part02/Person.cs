using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Assignment_2_Sol.Part02
{
    internal struct Person
    {
        #region Solution without Indexer
        //#region Properties [Automatic Property]
        //public string Name { get; set; }
        //public int Age { get; set; }
        //#endregion


        //#region Method
        //public override string ToString()
        //{
        //    return $"{Name} : {Age}";
        //}
        //#endregion
        #endregion

        #region Solution with Indexer

        #region Attributes
        string [] Names;
        int[] Ages;
        int Size;
        #endregion

        #region Constructor
        public Person(int Sizee)
        {
            this.Size = Sizee;
            this.Names = new string[Sizee];
            this.Ages = new int[Sizee];
        }
        #endregion

        #region Properties [Indexer]

        public int SSize
        {
            get
            {
                return Size;
            }
        }
        public string this[int Pos]
        {
            set
            {
                if (Names != null && Ages != null)
                {
                    Names[Pos] = value;
                }
            }

            get
            {
                return Names[Pos];
            }
        }

        public int this[int Pos, string Name]
        {
            set
            {
                if (Names != null && Ages != null)
                {
                    for (int i = 0; i < Ages.Length; i++)
                    {
                        if (Names[i] == Name)
                        {
                            Ages[i] = value;
                            break;
                        }

                    }
                }
            }

            get
            {
                return Ages[Pos];
            }
        }
            #endregion
            #endregion
        }
}
