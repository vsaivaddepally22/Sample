using New;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using static AllPrograms.AllPrograms;

delegate void Del(int n);
namespace AllPrograms
{
    //program class contains all the code
    public class Program
    {


        static void Main(string[] args)
        {
            ClsMath i = new ClsMath();
            //int op = 8;
//venkat
            //float b = op;

            //float kp = 8;
            //int hk =(int) kp;



            VereLevel refh = new VereLevel();
            refh.M1();

             Lazy<List<int>>  olo  = new Lazy<List<int>>();

            int[] arru = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var it = arru.FirstOrDefault();
            //var it1 = arru.SingleOrDefault();

            int[] arrui = new int[] { };
            var iy = arrui.FirstOrDefault();
            int[] arruih = new int[] { };
            var ghu = arruih.SingleOrDefault();

            var intnumbers = arru.Skip(11).SkipLast(4);

            foreach(var item in intnumbers)
            {
                Console.WriteLine(item);
            }


            var y = 1 > 2 ? null : "ek";


            Interf1 in1 = new MainClas();
            in1.name();
            MainClas vlo = new MainClas();
            vlo.name();
            STatclass olp = new STatclass();
            olp.add();
             int h = olp.k;
            DerivedC did = new DerivedC();
            did.Invoke();
            ReverseArray revs = new ReverseArray();
            revs.reverseArray();
            AllPrograms allPrograms1 = new AllPrograms();
            allPrograms1.CountCharacterCountInString();
            MethodOverrideDerived meth = new MethodOverrideDerived();
            meth.MethodOverBase();
            MethodOverride methd = new MethodOverrideDerived();

            methd.MethodOverBase();

            //MethodOverrideDerived gfsdh = new MethodOverride(); error cannot implicity convert parent class to child class

            PointerClass klo = new PointerClass();
            NewDerivedG oi = new NewDerivedG();
            oi.Addf(new NewDerivedClass());
            //oi.stop(new DerivedClaaa());
                

            DerivedClaaa dca = new DerivedClaaa();
            dca.add();
            
            

            sealedSecondClass secondf = new sealedSecondClass();
            List<string> lst = new List<string>();
            lst.Add("Ind");
            var  comm =  Tuple.Create(1, "Venkat", "Sai",lst);
            Console.WriteLine(comm.Item1);
            Console.WriteLine(comm.Item2);
            Console.WriteLine(comm.Item3);
            ICarSupplier icar= GetInstance.GetInstanceMethod(1);
            icar.carModel();
            Console.WriteLine(icar.color);
            FinalMethodInjector ol = new FinalMethodInjector();
            ol.finalMeth();

            FinalCLassMethodInjector o = new FinalCLassMethodInjector();
            o.Caaling();


            Client1 oj = new Client1(new FirstCLass());
            oj.Serve();


            Client1 ojd = new Client1(new SecondClass());
            ojd.Serve();

            SecondExtension sc = new SecondExtension();
            sc.M1();
            sc.M2();
            sc.M3();

            BubbleSort bb = new BubbleSort();
            bb.Bubblesort();
            SelectionSort s = new SelectionSort();
            s.selectionsort();

            IVehicle vi =  VehicleFactory.Build(1);

            InhertitanceChild ih = new InhertitanceChild();
            ih.InheritanceBaseMethod();
            A a = new Test();
            a.Hello();
            B b = new Test();
            b.Hello();
            Sorting sr = new Sorting();
            sr.sortElement1s();
            Pattern pt = new Pattern();
            Console.WriteLine("enter pattern number");
            int ptint = Int32.Parse(Console.ReadLine().ToString());
            pt.PrintPattern(ptint);
            SingleTon sig = SingleTon.GetInstance;

            sig.PrintDetails("venk");


            AllPrograms allPrograms = new AllPrograms();
            //Name.item();
            GeekExtensionMethodExp m1 = new GeekExtensionMethodExp();
            m1.M1();
            m1.M2();
            m1.M3();

            Del dt = DeletgateExp.Add;
            dt(10);

            DerivedC dc = new  DerivedC();
            dc.Invoke()
;
            InheritVirtual inheritVirtual = new InheritVirtual();
            inheritVirtual.VirtualMethod();

            Service1 s1 = new Service1();
            //passing dependency
            Client c1 = new Client(s1);
            c1.ServeMethod();
            //TO DO:

            Service2 s2 = new Service2();
            //passing dependency
            c1 = new Client(s2);
            allPrograms.LargestNumberFromArray();
            allPrograms.PrintTriange();
            allPrograms.Fibonacci();
            allPrograms.Factorial();
            allPrograms.checkPrimeNumber();
            allPrograms.SwapTwoNumbersWithoutThirdVariable();
            allPrograms.checkNumberPalindrome();
            allPrograms.checkStringAplindrome();
            allPrograms.SumofNumber();
           
            //creating object
            
            //TO DO:
            Console.ReadKey();



        }
    }
    
     public static class finfg
    {

    }

    public static class Ji 
    {

    }
    public partial class StatMeth
    {


        public static void M1()
        {
            Console.WriteLine("M1");
        }



        public static void Modul1()
        {

        }
    }



    class ClsMath
    {

    }

    public static partial class StatMeth
    {

    }



    public class AllPrograms
    {
        /// <summary>
        /// checkNumberPalindrome
        /// </summary>
        public void checkNumberPalindrome()
        {
            Console.WriteLine("enter number to check palidrome");
            int number = Convert.ToInt32(Console.ReadLine());
            int rev = 0, remainder = 0;
            int originalNumber = number;
            while (number != 0)
            {
                remainder = number % 10;
                rev = rev * 10 + remainder;
                number = number / 10;
            }

            if (rev == originalNumber)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");

        }

        /// <summary>
        ///checkStringAplindrome
        /// </summary>
        public void checkStringAplindrome()
        {
            Console.WriteLine("Enter string to check for palindrome");
            string str = Console.ReadLine();
            char[] arrayString = str.ToCharArray();
            string newString = string.Empty;

            for (int i = arrayString.Length-1; i >= 0; i--)
            {
                newString = newString + arrayString[i];
            }
            newString = newString.Trim();
            if (str == newString)
            {
                Console.WriteLine("String is palidrome");

            }
            else
                Console.WriteLine("String is not palidrome");

            int flag = 0;
            for (int i = 0; i < arrayString.Length; i++)
            {
                if (arrayString[i] != arrayString[arrayString.Length - i - 1])
                {
                    flag = 1;
                    break;
                }
            }

            if (flag != 1)
            {
                Console.WriteLine("string is palindrome");
            }
            else
                Console.WriteLine("string is not palindrome");

        }

        /// <summary>
        /// SumofNumber
        /// </summary>
        public void SumofNumber()
        {
            Console.WriteLine("Enter the number to find the sum");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int rem = 0;
            while (number != 0)
            {
                rem = number % 10;
                sum = sum + rem;
                number /= 10;

            }

            Console.WriteLine("sum of number {0}", sum);

        }
        /// <summary>
        /// CountCharacterCountInString
        /// </summary>
        public void CountCharacterCountInString()
        {

            Console.WriteLine("enter the string CountCharacterCountInString");
            string str = Console.ReadLine();
            Console.WriteLine("enter the character to count in string");
            char ch = Convert.ToChar(Console.ReadLine());

            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach(char c in str)
            {
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c]++;
                }
            }

            int k = dic.GetValueOrDefault(ch);

            foreach(var key in dic.Keys)
            {
                Console.WriteLine(string.Format("{0} occured {1} times",key,dic[key] ));
            }
            

            Console.WriteLine(k);

        }

        public void SwapTwoNumbersWithoutThirdVariable()
        {
            Console.WriteLine("enter 1st number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
            Console.WriteLine("swapping of two numbers {0},{1}", firstNumber, secondNumber);
        }

        /// <summary>
        /// checkPrimeNumber
        /// </summary>
        public void checkPrimeNumber()
        {
            Console.WriteLine("Enter the number to check prime");
            int isPrime = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            for(int i = 1;i<=isPrime; i++)
            {
                if(isPrime % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine("The given number{0} is prime number", isPrime);
            }
            else
            {
                Console.WriteLine("The given number{0} is not prime number", isPrime);

            }



        }
        /// <summary>
        /// Factorial
        /// </summary>
        public void Factorial()
        {
            Console.WriteLine("enter number to find the factorial");
            int num = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }

            Console.WriteLine("factorial of given number {0} is {1}", num, fact);
        }

        public void Fibonacci()
        {
            Console.WriteLine("enter the fibonacci series number");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n3;

            Console.WriteLine("{0} {1}", n1, n2);

            for(int i = 2; i <= num; i++)
            {
                n3 = n1 + n2;
                n1 = n2;
                n2 = n3;

                Console.WriteLine(n3);

            }


        }

        public void PrintTriange()
        {
            int i, j, k, l, n;
            Console.Write("Enter the Range=");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
            }
        }
        /// <summary>
        /// LargestNumberFromArray
        /// </summary>
        public void LargestNumberFromArray()
        {
            int n, i, j = 0, largest, secondLargest;
            int[] arr1 = new int[5]{ 1,104,78,4,5} ;


            Console.Write("\n\nFind the second largest element in an array :\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = arr1.Length;//Convert.ToInt32(Console.ReadLine());
            ///* Stored values into the array*/
            //Console.Write("Input {0} elements in the array :\n", n);
            //for (i = 0; i < n; i++)
            //{
            //    Console.Write("element - {0} : ", i);
            //    arr1[i] = Convert.ToInt32(Console.ReadLine());
            //}
            /* find location of the largest element in the array */
            largest = 0;

            for (i = 0; i < n; i++)
            {
                if (largest < arr1[i])
                {
                    largest = arr1[i];
                    j = i;
                }
            }

            Console.WriteLine("Largest Number is {0}",arr1[j]);

            Array.Sort(arr1);

            Console.WriteLine("Largest Number sort is {0}", arr1[arr1.Length-2]);


        }
        public interface IService
        {
            void Serve();
        }
        public class Service1 : IService
        {
            public void Serve() { Console.WriteLine("Service1 Called"); }
        }
        public class Service2 : IService
        {
            public void Serve() { Console.WriteLine("Service2 Called"); }
        }
        public class Client
        {
            private IService _service;
            public Client(IService service)
            {
                this._service = service;
            }
            public void ServeMethod() { this._service.Serve(); }
        }


        public  class VirtualExp
        {

            public virtual void VirtualMethod()
            {
                Console.WriteLine("VirtualExp VirtualMethod");
            }
        }

        public class InheritVirtual : VirtualExp
        {
            public override void VirtualMethod()
            {
                Console.WriteLine("InheritVirtual VirtualMethod");
                base.VirtualMethod();
            }

        }
        public class BaseC
        {
            public int x=10;
            public void Invoke() { }
        }
        public class DerivedC : BaseC
        {
            //new 
                public int x = 300;
            new public void Invoke() {

                Console.WriteLine("BaseC Invoke {0}",x);
            }
        }


        public  class DeletgateExp
        {

      


            public static void Add(int n)
            {
                int sum = 0;
                sum = sum + n;

                Console.WriteLine(sum);
            }

            public static void mul(int n)
            {
                int sum = 1;
                sum = sum * n;

                Console.WriteLine(sum);
            }



        }

        /// <summary>
        /// extension method
        /// </summary>

        public class GeekExtensionMethodExp
        {

            public void M1()
            {
                Console.WriteLine("M1");
            }
            
            public void M2()
            {
                Console.WriteLine("M2");
            }


        }

        public static class Name
        {
            static int k = 0;

            static void item()
            {

            }
        }
        class Singleton
        {
            public static readonly Singleton _obj = new Singleton();

            public void Display()
            {
                Console.WriteLine(true);
            }
            Singleton() { }
        }


        public class OverRide1
        {
            public virtual void M1()
            {
                Console.WriteLine("OverRide1 {0}", "M1");
            }
        }

        public class OverRide2 : OverRide1
        {
            public override void M1()
            {

            }
        }

    }

    /// <summary>
    /// single ton exp
    /// </summary>
    public  class SingleTon
    {
        private static SingleTon instance = null;
        private SingleTon()
        {

        }

        public void PrintDetails(string str)
        {
            Console.WriteLine(str);
        }
        public static SingleTon GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingleTon();
                }
                return instance;
            }
            
        }

    }
    

}

public static class ExtendedClass
{

    public static void M3(this GeekExtensionMethodExp g)
    {
        try
        {
            Console.WriteLine("M3");
            string connectionstrr = "Datasource = 1234,user name =venkat,password=1234 ";
            SqlConnection con = new SqlConnection(connectionstrr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from student", con);

            cmd.CommandType = System.Data.CommandType.Text;

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int k = (int)dr["sai"];
            }
        }
        catch (Exception ex)
        {

        }

    }

}


public class Pattern
{


    public void PrintPattern(int n)
    {
        //int n = 3;
        for (int i = 1; i <=n; i++)
        {

            for(int j = 1;j<=i; j++)
            {
               // Console.Write(" ");
                Console.Write(j);
            }
            Console.WriteLine("\n");


        }

}
        }

///// <summary>
///// Sorting class 
///// </summary>
public class Sorting
{
    public void sortElement1s()
    {
        int[] arr = new int[] { 1, 5, 7, 2, 19, 5, 3 };
        int temp = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i + 1; j < arr.Length; j++)
            {
                if(arr[i] > arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                }


            }
        }

        foreach(var ele in arr)
        {
            Console.WriteLine(ele);
        }



    }
}

interface A
{
    void Hello();
}
interface B
{
    void Hello();
}
class Test : A, B
{
    void B.Hello()
    {
        Console.WriteLine("Hello to all-B");
    }

    void A.Hello()
    {
        Console.WriteLine("Hello to all-A");
    }
}

public class InheritancceBase
{
    public void InheritanceBaseMethod()
    {
        Console.WriteLine("InheritanceBaseMethod");
    }
}

public class InhertitanceChild : InheritancceBase
{
    public void InheritanceBaseMethod()
    {
        Console.WriteLine("InhertitanceChild");
        base.InheritanceBaseMethod();
    }
}

public interface IVehicle
{

}

public class Car : IVehicle
{

    public Car()
    {
        Console.WriteLine("Car");
    }
}

public class Bicycle : IVehicle
{
    public Bicycle()
    {
        Console.WriteLine("Bicycle");

    }
}

public static class VehicleFactory
{
    public static IVehicle Build(int numberOfWheels)
    {
        switch (numberOfWheels)
        {
            case 1:
                return new Car();
            case 2:
            case 3:
                return new Bicycle();
            case 4:
                return new Car();
            default:
                return new Car();


        }
    }
}
//factory pattern--done
//seelction sort --done
//bubble sort --done
//dependency injection --done
//extension method --done
//webAPI
//solid principles
//deligates

/// <summary>
/// SelectionSort
/// </summary>
public class SelectionSort
{
    int[] unsortedarray = new int[] { 34, 78, 45, 87, 12, 45, 6, 7, 6, 45, 80, 1000 };

   public void selectionsort()
    {
        int ssmallindex;
        int temp = 0;
        for(int i = 0; i< unsortedarray.Length -1; i++)
        {
            ssmallindex = i;
            for (int j =i+1; j < unsortedarray.Length; j++)
            {

                if(unsortedarray[j] <  unsortedarray[ssmallindex]) // small to big for big to small use >
                {
                    ssmallindex = j;
                }

            }

            temp = unsortedarray[ssmallindex];
            unsortedarray[ssmallindex] = unsortedarray[i];
            unsortedarray[i] = temp;


        }

        for(int i =0; i<unsortedarray.Length; i++)
        {
            Console.WriteLine(unsortedarray[i]);
        }


    }

}



public class BubbleSort
{
    int[] unsortedarray = new int[] { 34, 78, 45, 87, 12, 45, 6, 7, 6, 45, 80, 1000 };


    public void Bubblesort()
    {
        int temp = 0;
        for(int i = 0; i < unsortedarray.Length; i++)
        {

            for (int j = i + 1; j < unsortedarray.Length; j++)
            {

                if (unsortedarray[i] > unsortedarray[j])
                {

                    temp = unsortedarray[i];
                    unsortedarray[i] = unsortedarray[j];
                    unsortedarray[j] = temp;

                }

            }




        }

        for (int i = 0; i < unsortedarray.Length; i++)
        {
            Console.WriteLine(unsortedarray[i]);
        }
    }
}
/// <summary>
/// Extenstion methods
/// </summary>
public  class SecondExtension
{
    public void M1()
    {
        Console.WriteLine("M1");
    }
    public void M2()
    {
        Console.WriteLine("M2");
    }
}

public static class ExtendClass
{
    public static void M3(this SecondExtension g)
    {
        Console.WriteLine("M3");
    }


}


/// <summary>
/// constructor injection
/// </summary>
public interface IDependent
{

    void DepImple();


}


public class FirstCLass : IDependent
{
    public void DepImple()
    {
        Console.WriteLine("DepImple : FirstCLass");
    }
}

public class SecondClass : IDependent
{
    public void DepImple()
    {
        Console.WriteLine("DepImple : SecondClass");
    }
}

public class Client1
{

    public readonly IDependent _dep;
    public Client1(IDependent dep)
    {
        _dep = dep;
    }

    public void Serve()
    {
        _dep.DepImple();
    }


}

/// <summary>
/// property injection
/// </summary>
public interface IPropertyInjection
{
    void CallMethod();
}

public interface IDependecyInterface
{
    void setDependency(IPropertyInjection prop);
}

public class CustomerPropertyClassInjector : IPropertyInjection
{
    public void CallMethod()
    {
        Console.WriteLine("CallMethiod");
    }
} 

public class Injector
{
    public IPropertyInjection inject { get; set; }
    public void CallMethod()
    {
        inject.CallMethod();
    }
}

public class FinalCLassMethodInjector
{
    Injector cust;


    public FinalCLassMethodInjector()
    {
        cust = new Injector();
        cust.inject = new CustomerPropertyClassInjector();

    }


    public void Caaling()
    {
        cust.CallMethod();
    }
}

public class MethodDependecy : IDependecyInterface
{
    IPropertyInjection inter;
    public void setDependency(IPropertyInjection prop)
    {
        inter = prop; 
    }

    public void j()
    {
        inter.CallMethod();
    }
 
}


public class FinalMethodInjector
{
    MethodDependecy di;
    public FinalMethodInjector()
    {
        di = new MethodDependecy();
        di.setDependency(new CustomerPropertyClassInjector());
    }

    public void finalMeth()
    {
        di.j();
    }
}

public interface ICarSupplier
{
    string color { get; }
    void carModel();
}

public class Honda : ICarSupplier
{
    public string color 
    { 
        get
        {
            return "red";
        }
       
    }

    public void carModel()
    {
        Console.WriteLine("Honda");
    }
}

public class Hero : ICarSupplier
{
    public string color {
        get
        {
            return "Hero";
        }

    }

    public void carModel()
    {
        Console.WriteLine("Hero");
    }
}


public static class GetInstance
{
    public static ICarSupplier GetInstanceMethod(int i)
    {

        switch (i)
        {
            case 1:
                return new Honda();
            case 2:
                return new Hero();

            default:
                return new Honda();
        }

    }
}

public  class  MyClass
{
    public static int id { get; set; }
     static MyClass()
    {

    }

    //public MyClass()
    //{

    //}

    //int i = 0;
}

public class sealedSecondClass : MyClass
{

    //MyClass obj = new MyClass();
    public void get()
    {
        //obj.id = 3;
        //MyClass obj1 = new MyClass();
        //obj1 = obj;

    }




}
public abstract class AbstractClass
{
    int h = 9;
    public abstract void add();
    public  void sub()
    {
        int h = 0;
    }
}

public interface interFaced
{
    //int h = 9;
    //public int num { get; set; }
    void hat();
}

public class DerivedClaaa : AbstractClass
{
    public override void add()
    {
        //throw new NotImplementedException();
    }


    //public override void add()
    //{
    //    throw new NotImplementedException();
    //}

    //public override void sub()
    //{
    //    throw new NotImplementedException();
    //}
    //public void hat()
    //{
    //    throw new NotImplementedException();
    //}
}

namespace New
{

    public class DerivedClaaa
    {

        
    }

    public class NewDerivedClass : DerivedClaaa
    {

        
    }

    public class NewDerivedG : NewDerivedClass
    {
        public void Addf(DerivedClaaa a)
        {

        }

        public void stop(NewDerivedClass a)
        {

        }
    }

    public class PointerClass
    {
        public int i = 0;
        public  PointerClass Next;

    }

    public static class staticclsc
    {

    }

    public static class MyCLSASS // : staticclsc
    {

    }
}

public class MethodOverride
{
    public  void MethodOverBase()
    {
        Console.WriteLine("MethodOverride MethodOverBase");
    }
}

public class MethodOverrideDerived : MethodOverride
{
    public  void MethodOverBase()
    {
        Console.WriteLine("MethodOverrideDerived MethodOverBase");
    }
}

public class ReverseArray
{

    public void reverseArray()
    {
        int[] arr = new int[] {2,5,1,7,3,9,8 }; // 8,9,3,7,1,5,2
        int temp = 0;

        for(int i =0; i < arr.Length / 2; i++)
        {
            temp = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i-1] = temp;
            
            
        }
        for(int j = 0; j < arr.Length; j++)
        {
            Console.WriteLine(arr[j]);
        }

    }
}


public partial class STatclass
{
   public int k = 10;
    public void add()
    {

    }
}

public partial class STatclass
{
    public void mul()
    {

    }
}

public abstract class abtract1
{
    public abstract void name();
}

public interface Interf1
{
    void name();
}



public class MainClas : abtract1, Interf1
{
    public override void name()
    {

        Console.WriteLine("MainClas abstract name");
        //
        //throw new NotImplementedException();
    }

     void Interf1.name()
    {
        Console.WriteLine("MainClas Interf1 name");
    }
}

public class ClassStat
{
    public void M1()
    {
        Console.WriteLine("Class Stat M1");
    }
}

public  class VereLevel : ClassStat
{
    public void M1()
    {
        Console.WriteLine("Class Stat M2");
    }
}














