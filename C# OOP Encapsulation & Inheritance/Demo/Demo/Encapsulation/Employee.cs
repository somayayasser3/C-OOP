using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Encapsulation
{
    internal struct Employee
    {
        #region Atrributes
        public int id;
        private string name;
        private decimal salary;
        //private decimal deduction; // Derived Attribute in SQL // Can be calculated in runtime
        //private int age;
        // Encapsulation ==> Separate Data Definition (Attributes) From its Use (get, set , property)

        // 1. Private Attributes
        // 2. [Getter - Setter] Older - Property Newer

        #endregion 

        #region 1. Applying Encapsulation using Getter and Setter Functions
        // Getter
        public string GetName()
        {
            return name;
        }

        // Setter
        public void SetName(string _Name)
        {
            this.name = _Name?.Length > 5 ? _Name.Substring(0, 5) : _Name;
        }
        #endregion

        #region 2. Applying Encapsulation using Property [Recommended]
        // Property [FUll Property - Automatic Property - Indexer]
        // No Parameter
        // Use Getter - Setter 
        // 1. Private Attribute 
        // 2. Property is Always Public
        // 3. Attribute ==> Small , Property ==> Capital
        // 4. return the same type of the Attribute You Use
        // Easy to Use than Getter, Setter like Attribute
        public decimal Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value < 3000 ? 3000 : value; // reserved keyword has the assigned value 
            }
        }

        // Full Property 
        // use when there is validation on Attribute
        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }

        //    set
        //    {
        //        this.age = value;
        //    }
        //}

        // Automatic Property
        // if there is no validation , create property like this 
        // compiler will Generate Hidden Private Attribute [ Backing Field ] at Compilation Time (can't be accessible)
        // we can find [ Backing Field ] at Il 
        public int Age { set; get; }
        
        public decimal Deduction // Read Only
        {
            get
            {
                return salary * 0.2M;
            }
            // without set as it's fixed
        }

        // snap for propfull --> tab --> tab
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


        // snap for Automatic Property --> prop --> tab --> tab
        //public int MyProperty { get; set; }

        #endregion

        #region Constructors
        public Employee(int id, string name, decimal salary, int age)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            Age = age; // in case of Automatic Property,  when i want to deal with attribute , use Automaic Property
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Id = {id} \nName = {name} \nSalary = {salary:c} \nAge = {Age}"; // c for currency
        }
        #endregion
    }
}
