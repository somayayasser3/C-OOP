using System;
using OOP_Assignment_2_Sol.Part02;
using System.Linq;
namespace OOP_Assignment_2_Sol
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part02
            #region Q1.
            //Person[] PerArra = new Person[3];
            //PerArra[0].Name = "Somaya";
            //PerArra[0].Age = 25;
            //PerArra[1].Name = "Sara";
            //PerArra[1].Age = 23;
            //PerArra[2].Name = "Ahmed";
            //PerArra[2].Age = 19;
            //if (PerArra !=  null)
            //{
            //    for (int i = 0; i < PerArra.Length; i++)
            //    {
            //        Console.WriteLine(PerArra[i].ToString());
            //    }
            //}
            #endregion

            #region Q2.
            //Person[] PerArra = new Person[3];
            //string Name;
            //int Age;
            //bool Flag;
            //for (int i = 0; i < 3; i++)
            //{
            //    if (PerArra != null)
            //    {
            //        do
            //        {
            //            Console.Write("Please Enter A name: ");
            //            Name = Console.ReadLine();
            //        } while (Name == null || Name == "");
            //        PerArra[i].Name = Name;
            //        do
            //        {
            //            Console.Write("Please Enter An Age: ");
            //            Flag = int.TryParse(Console.ReadLine(), out Age);
            //        } while (Age == 0 || !Flag || Age < 0);
            //        PerArra[i].Age = Age;
            //    }
            //}
            //int OldId = 0;
            //if (PerArra != null)
            //{
            //    for (int i = 1; i < PerArra.Length; i++)
            //    {
            //        if (PerArra[i].Age >= PerArra[OldId].Age)
            //            OldId = i;
            //    }
            //    Console.WriteLine($"The Older One: {PerArra[OldId].ToString()}");
            //}
            #endregion

            #region Another Solution - Use Indexer
            //Person P1 = new Person(3);
            //P1[0] = "Somaya";
            //P1[1] = "Sara";
            //P1[2] = "Ahmed";

            //P1[0,"Somaya"] = 25;
            //P1[1, "Sara"] = 23;
            //P1[2, "Ahmed"] = 19;

            //for (int i = 0; i < P1.SSize; i++)
            //{
            //    Console.WriteLine(P1[i] +" , " + P1[i,P1[i]]);
            //}

            //Person P1 = new Person(3);
            //string Name;
            //int Age;
            //bool Flag;
            //for (int i = 0; i < 3; i++)
            //{
            //    if (P1.SSize != 0)
            //    {
            //        do
            //        {
            //            Console.Write("Please Enter A name: ");
            //            Name = Console.ReadLine();
            //        } while (Name == null || Name == "");
            //        P1[i] = Name;
            //        do
            //        {
            //            Console.Write("Please Enter An Age: ");
            //            Flag = int.TryParse(Console.ReadLine(), out Age);
            //        } while (Age == 0 || !Flag || Age < 0);
            //        P1[i, Name] = Age;
            //    }
            //}
            //int OldId = 0;
            //string NName;
            //string OldName = P1[OldId];
            //if (P1.SSize != 0)
            //{
            //    Console.WriteLine(P1.SSize);
            //    for (int i = 1; i < P1.SSize; i++)
            //    {
            //        NName = P1[i];
            //        if (P1[i, NName] >= P1[OldId, OldName])
            //        {
            //            OldId = i;
            //            OldName = P1[OldId];
            //        }
            //    }
            //    Console.WriteLine($"The Older One: {P1[OldId]} , {P1[OldId, OldName]}");
            //}
            #endregion
            #endregion

            #region Part03
            #region Implement and print
            Employee[] EmpArr = new Employee[3];
            int id;
            string name;
            bool Flag;
            double salary;
            int day;
            int month;
            int year;
            string g;
            for (int i = 0; i < 3; i++)
            {
                if (EmpArr.Length != 0)
                {
                    /////////////////////////////////////////////////
                    do
                    {
                        Console.Write("Please Enter an Id: ");
                        Flag = int.TryParse(Console.ReadLine(), out id);

                    } while (!Flag || id < 0);

                    //////////////////////////////////////////////
                    do
                    {
                        Console.Write("Please Enter A Name: ");
                        name = Console.ReadLine();
                    } while (name == null || name == "");
                    // EmpArr[i].Name = name;
                    ///////////////////////////////////////////////
                    // EmpArr[i].P_securityLevel = (SecurityLevel)8;
                    // EmpArr[i].P_securityLevel = (SecurityLevel)1;
                    // EmpArr[i].P_securityLevel = (SecurityLevel)15;
                    ///////////////////////////////////////////////
                    do
                    {
                        Console.Write("Please Enter the salary: ");
                        Flag = double.TryParse(Console.ReadLine(), out salary);
                    } while (!Flag || salary <= 0);
                    //EmpArr[i].Salary = salary;

                    ////////////////////////////////////////////////
                    do
                    {
                        Console.Write("Please Enter A day number: ");
                        Flag = int.TryParse(Console.ReadLine(), out day);
                    } while (!Flag || day > 31 || day < 0);

                    do
                    {
                        Console.Write("Please Enter A month number: ");
                        Flag = int.TryParse(Console.ReadLine(), out month);
                    } while (!Flag || month > 12 || month < 0);

                    do
                    {
                        Console.Write("Please Enter A year number: ");
                        Flag = int.TryParse(Console.ReadLine(), out year);
                    } while (!Flag || year < 0);

                    ///////////////////////////////////////////////////////////////
                    //EmpArr[i].P_hiringDate = new HiringDate(day, month, year);

                    Console.Write("Please Enter A Gender: ");
                    g = Console.ReadLine();
                    Enum.TryParse<Gender>(g, true, out Gender res);
                    //EmpArr[i].P_gender = res;

                    if (i == 0)
                    {
                        EmpArr[i] = new Employee(id, name, (SecurityLevel)8, salary, new HiringDate(day, month, year), res);
                    }
                    else if (i == 1)
                    {
                        EmpArr[i] = new Employee(id, name, (SecurityLevel)1, salary, new HiringDate(day, month, year), res);
                    }

                    else if (i == 2)
                    { 
                        EmpArr[i] = new Employee(id, name, (SecurityLevel)15, salary, new HiringDate(day, month, year), res);
                    }

                }
            }

            if (EmpArr.Length != 0)
            {
                for (int i = 0; i < EmpArr.Length; i++)
                {
                    Console.WriteLine(EmpArr[i].ToString() + "\n\n");
                }
            }
            #endregion

            #region Sort
            Employee temp;
            for (int i = 0; i < EmpArr.Length -1 ; i++)
            {
                for (int j = i + 1 ; j < EmpArr.Length; j++)
                {
                    if (EmpArr[j].P_hiringDate.Year < EmpArr[i].P_hiringDate.Year)
                    {
                        temp = EmpArr[i];
                        EmpArr[i] = EmpArr[j];
                        EmpArr[j] = temp;
                    }

                    else if(EmpArr[j].P_hiringDate.Year < EmpArr[i].P_hiringDate.Year)
                    {
                        if(EmpArr[j].P_hiringDate.Month < EmpArr[i].P_hiringDate.Month)
                        {
                            temp = EmpArr[i];
                            EmpArr[i] = EmpArr[j];
                            EmpArr[j] = temp;
                        }
                        else
                        {
                            if (EmpArr[j].P_hiringDate.Day < EmpArr[i].P_hiringDate.Day)
                            {
                                temp = EmpArr[i];
                                EmpArr[i] = EmpArr[j];
                                EmpArr[j] = temp;
                            }
                        }
                    }
                }
            }

            Console.WriteLine("After Sorting: ");
            if (EmpArr.Length != 0)
            {
                for (int i = 0; i < EmpArr.Length; i++)
                {
                    Console.WriteLine(EmpArr[i].ToString() + "\n\n");
                }
            }
            //Employee sortedEmpArr = EmpArr.OrderBy(EmpArr => EmpArr.P_hiringDate);
            //Boxing and unboxing Occurred Zero Times, I don't have use from a Reference Type to Value Type or from Value Type to Reference Type During Sorting
            #endregion
            #endregion
            Console.ReadKey();
        }
    }
}
