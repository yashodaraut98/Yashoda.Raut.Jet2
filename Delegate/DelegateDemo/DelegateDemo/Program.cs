using System;

delegate void myDelegate();  //mydelegate is delegate type.which can only call only those function which returns as a "void"

//........multicast,singleCast
namespace DelegateDemo
{

    public class personalDetails
    {
        public String Qualification()
        {
            Console.WriteLine("BE Computer Eng");
            return "BE Computer Eng";
        }
        public void Job()
        {
            Console.WriteLine("I am working in jet2 as Jr software developer");

        }
        public void PersonalExpenses()
        {
            Console.WriteLine("I dont want to allow to access anyone this func");
        }
    }
    class User
    {
        public static void Main()
        {
           
            personalDetails pd = new personalDetails();
            myDelegate mydelegate = new myDelegate(pd.Qualification);//shows error return type must be same
            mydelegate += pd.Job;// ex of multicast delegate (+=)
            mydelegate();


            //  mydelegate.Invoke();//  mydelegate() 
            //  mydelegate.Invoke();



        }
    }
}
