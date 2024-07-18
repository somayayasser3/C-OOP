using OOPAssign4Sol.Part02___Q02;
using OOPAssign4Sol.Part02___Q03;
using System;
namespace OOPAssign4Sol
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part01
            #region Q01
            //What is the primary purpose of an interface in C#?
            //a) To provide a way to implement multiple inheritance

            #endregion

            #region Q02
            //Which of the following is NOT a valid access modifier for interface members in C#?
            //a) private

            #endregion

            #region Q03
            //Can an interface contain fields in C#?
            //b) No

            #endregion

            #region Q04
            // In C#, can an interface inherit from another interface?
            //b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Q05
            //Which keyword is used to implement an interface in a class in C#?
            //d) implements

            #endregion

            #region Q06
            //Can an interface contain static methods in C#?
            //a) Yes

            #endregion

            #region Q07
            //In C#, can an interface have explicit access modifiers for its members?
            //b) No, all members are implicitly public

            #endregion

            #region Q08
            //What is the purpose of an explicit interface implementation in C#?
            //b) To provide a clear separation between interface and class members

            #endregion

            #region Q09
            //In C#, can an interface have a constructor?
            //b) No, interfaces cannot have constructors

            #endregion

            #region Q10
            //How can a C# class implement multiple interfaces?
            //c) By separating interface names with commas

            #endregion
            #endregion

            #region Part02 

            #region Q01
            //IShape circle = new Circle();
            //circle.Area = 75.6M;
            //circle.DiplayShapeInfo();

            //IShape rect = new Rectangle();
            //rect.Area = 24M;
            //rect.DiplayShapeInfo();

            // OR
            //ICircle circle = new Circle();
            //circle.Area = 75.6M;
            //circle.DiplayShapeInfo();

            //IRectangle rect = new Rectangle();
            //rect.Area = 24M;
            //rect.DiplayShapeInfo();

            // OR
            //Circle circle = new Circle();
            //circle.Area = 75.6M;
            //circle.DiplayShapeInfo();

            //Rectangle rect = new Rectangle();
            //rect.Area = 24M;
            //rect.DiplayShapeInfo();

            #endregion

            #region Q02
            //User user = new User();
            //Console.WriteLine("Please Enter Your UserName: ");
            //user.Name = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Password: ");
            //user.Password = Console.ReadLine();
            //BasicAuthenticationService basicAuthenticationService = new BasicAuthenticationService();
            //bool Flag = basicAuthenticationService.AuthenticateUser(user.Name, user.Password);
            //if (Flag)
            //{
            //    Console.WriteLine("The user is authenticated");
            //}
            //else Console.WriteLine("The user is not authenticated ");

            //Flag = basicAuthenticationService.AuthorizeUser(user.Name);
            //if (Flag)
            //{
            //    Console.WriteLine("The user is Authorized");
            //}
            //else Console.WriteLine("The user is not Authorized");
            #endregion

            #region Q03
            //EmailNotificationService emailNotification = new EmailNotificationService();
            //emailNotification.SendNotification("Omar", "Your are Accepted");
            //Console.WriteLine("===================================================\n");
            //SMSNotificationService smsNotification = new SMSNotificationService();
            //smsNotification.SendNotification("Somaya", "this is your OTP Number: 123");
            //Console.WriteLine("===================================================\n");
            //PushNotificationService PushNotification = new PushNotificationService();
            //PushNotification.SendNotification("Yousef", "Check Your Privacy");
            #endregion


            #endregion

            Console.ReadKey();
        }
    }
}
