using System.Data;
using System.Net;
using Assignment.Question1;
using Assignment.Question2;
using Assignment.Question3;

namespace Assignment
{
    internal class Program
    {
        static void Main()
        {
            #region Part 01

            #region Question 01
            // 1. What is the primary purpose of an interface in C#?

            // c) To declare abstract methods and properties

            #endregion

            #region Question 02

            // 2. Which of the following is NOT a valid access modifier for interface members in C#?

            // a) private

            #endregion

            #region Question 03

            // 3. Can an interface contain fields in C#?

            // b) No

            #endregion

            #region Question 04

            // 4. In C#, can an interface inherit from another interface?

            // b) Yes, interfaces can inherit from multiple interfaces

            #endregion

            #region Question 05

            // 5. Which keyword is used to implement an interface in a class in C#?

            // d) implements

            #endregion

            #region Question 06

            // 6. Can an interface contain static methods in C#?

            // a) Yes

            #endregion

            #region Question 07

            // 7. In C#, can an interface have explicit access modifiers for its members?

            // a) Yes, for all members

            #endregion

            #region Question 08

            // What is the purpose of an explicit interface implementation in C#?

            // b) To provide a clear separation between interface and class members

            #endregion

            #region Question 09

            // 9. In C#, can an interface have a constructor?

            // b) No, interfaces cannot have constructors

            #endregion

            #region Question 10

            // 10. How can a C# class implement multiple interfaces?

            // c) By separating interface names with commas

            #endregion

            #endregion

            #region Part 02

            #region Question 1

            // Define an interface named IShape with a property Area and a method DisplayShapeInfo. 
            // Create two interfaces, ICircle and IRectangle, that inherit from IShape. 
            // Implement these interfaces in classes Circle and Rectangle. 
            // Test your implementation by creating instances of both classes and displaying their shape information.

            IShape circle = new Circle(5.0);
            circle.DisplayShapeInfo();

            IShape rectangle = new Rectangle(4.0, 6.0);
            rectangle.DisplayShapeInfo();

            #endregion

            #region Question 2

            // In this example, we start by defining the IAuthenticationService interface with two methods: 
            // AuthenticateUser and AuthorizeUser.
            // The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.
            // In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.
            // It returns true if the user is authenticated and false otherwise.
            // The AuthorizeUser method checks if the user with the given username has the specified role.
            // It returns true if the user is authorized and false otherwise.
            // In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.
            // We then call the AuthenticateUser and AuthorizeUser methods using this interface reference.
            // This implementation allows you to switch the authentication service implementation easily by creating a new class
            // that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization.

            IAuthenticationService authService = new BasicAuthenticationService();

            bool isAuthenticated = authService.AuthenticateUser("admin", "password");
            Console.WriteLine($"User is authenticated: {isAuthenticated}"); 

            bool isAuthorized = authService.AuthorizeUser("admin", "admin");
            Console.WriteLine($"User is authorized: {isAuthorized}");

            #endregion

            #region Question 3

            // we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.We then create three classes:
            // EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.In each implementation,
            // we provide the logic to send notifications through the respective communication channel:
            // The EmailNotificationService class simulates sending an email by outputting a message to the console.
            // The SmsNotificationService class simulates sending an SMS by outputting a message to the console.
            // The PushNotificationService class simulates sending a push notification by outputting a message to the console.
            // In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.
            // This implementation allows you to easily switch between different notification channels by creating new classes
            // that implement the INotificationService interface and provide the specific logic for each channel.

            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();
             
            emailService.SendNotification("john@example.com", "Hello from Email!");
            smsService.SendNotification("555-1234", "Hello from SMS!");
            pushService.SendNotification("mobile-device-123", "Hello from Push Notification!");

            #endregion

            #endregion



























        }
    }
}
