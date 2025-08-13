namespace ADV03
{
    internal class Program
    {
        
        public delegate int StringFuncDelegate(string s);
        // Reference (Pointer) Can Refer to function
        //public delegate bool IsDivisible(int n);
        public delegate bool IsDivisible<T>(T n);
        public static void PrintArr<T>(T[] arr)
        {
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} --> ");
            }
            Console.WriteLine();
        }

        #region Using Delegate
        //public static List<int> FindNumber(List<int> n, IsDivisible Reference)
        //{
        //    List<int> Result = new List<int>();
        //    if (n == null) { return Result; }

        //    for (int i = 0; i < n.Count; i++)
        //    {
        //        if (Reference.Invoke(n[i]))
        //        {
        //            Result.Add(n[i]);
        //        }
        //    }
        //    return Result;
        //} 
        #endregion

        #region Before Delegate
        //public static List<int> FindOddNumber(List<int> n)
        //{
        //    List<int> Result = new List<int>();
        //    if (n == null) { return Result; }

        //    for (int i = 0; i < n.Count; i++)
        //    {
        //        if (n[i] % 2 != 0)
        //        {
        //            Result.Add(n[i]);
        //        }
        //    }
        //    return Result;
        //}
        //public static List<int> FineEvenNumber(List<int> n)
        //{
        //    List<int> Result = new List<int>();
        //    if (n == null) { return Result; }

        //    for (int i = 0; i < n.Count; i++)
        //    {
        //        if (n[i] % 2 == 0)
        //        {
        //            Result.Add(n[i]);
        //        }
        //    }
        //    return Result;
        //} 
        #endregion

        #region Generic with delegate
        public static List<T> FindNumber<T>(List<T> n, Func<T, bool> Reference)
        {
            List<T> Result = new List<T>();
            if (n == null) { return Result; }

            for (int i = 0; i < n.Count; i++)
            {
                if (Reference(n[i]))
                {
                    Result.Add(n[i]);
                }
            }
            return Result;
        }

        public static void PrintList<T>(List<T> n)
        {
            if (n == null) { return; }
            Console.WriteLine();
            for (int i = 0; i < n.Count; i++)
            {
                Console.Write(n[i] + " ");
            }
            Console.WriteLine();
        }
        #endregion
        static void Main(string[] args)
        {
            #region Overview

            // Delegate : C#

            // Pure oop

            // Functional programming --> coz of delegate 
            // Event-Driven 

            // Java : Pure oop
            // DP   : Starategy design pattern
            #endregion

            #region Delegate Ex01
            ////StringFuncDelegate X = new StringFuncDelegate(StringFunctions.UpperCaseCount);
            //StringFuncDelegate Var = StringFunctions.UpperCaseCount;

            ////int count = Var.Invoke("Word");
            ////int count = Var("Word");
            ////Console.WriteLine(count);

            //Var += StringFunctions.LowerCaseCount;
            //int count =  Var("Word");
            //Console.WriteLine(count); 
            #endregion

            #region Delegate Ex02

            //////int[] ints = { 81, 9, 7, 3, 1, 2 };
            //////PrintArr(ints);

            //////SortingAlgo.BubbleSortAsc(ints);
            //////PrintArr(ints);

            //////SortingAlgo.BubbleSortDec(ints);
            //////PrintArr(ints);

            ////SortingDelegate sortingDelegate = StringConditions.CompareGtr;
            //////sortingDelegate += StringConditions.CompareSmaller;


            ////int[] ints = { 81, 9, 7, 3, 1, 2 };
            //////SortingAlgo.BubbleSort(ints, StringConditions.CompareGtr);
            ////SortingAlgo.BubbleSort(ints , sortingDelegate);
            ////PrintArr(ints); 


            //string[] Names = { "Ahmed", "Youssef" , "Mina" , "Kiro" , "Amr" };

            ////SortingDelegate X = StringConditions.CompareStringGtr;
            ////X += StringConditions.CompareStringSmall;


            //SortingAlgo.BubbleSort(Names , StringConditions.CompareStringGtr);
            //PrintArr(Names);
            #endregion

            #region Delegate Ex03

            //List<int> ints = Enumerable.Range(1, 100).ToList();
            //////List<int> Odd = FindOddNumber(ints);
            //////List<int> Even = FineEvenNumber(ints);

            //////PrintList(Odd);
            //////PrintList(Even);
            ////List<int> ans = FindNumber(ints, ConditionFunc.IsOdd);
            //List<int> ans = FindNumber(ints, ConditionFunc.IsEven);
            //PrintList(ans);

            //List<string> Names = new List<string> { "Ahmed", "Youssef", "Mina", "Kiro", "Amr" };
            //List<string> answer = FindNumber(Names, ConditionFunc.NamesLenEqual3);
            //PrintList(answer);
            #endregion

            #region Build in Delegate

            //////// Predicate , func , Action

            //////// Predicate 
            //////Predicate<int> predicate = ConditionFunc.IsEven;
            //////Predicate<string> predicatee = ConditionFunc.NamesLen;

            ////Func<int> func1 = func01;
            ////Func<int, string> func2 = fun02;


            //Action<string> action = s => { Console.WriteLine(s); }; 
            #endregion

            #region Anonymous Method

            //////Func<int, bool> func = ConditionFunc.IsEven;
            //////func(1);
            ////Func<int, bool> func = (int x) => { return x % 2 == 0; };
            ////List<int> ints = Enumerable.Range(1, 10).ToList();
            ////FindNumber(ints, func);

            ////Func<int, bool> func = x => x % 2 == 0; 
            //List<int> ints = Enumerable.Range(1, 10).ToList();
            //List<int> ans = FindNumber(ints, x => x % 2 == 0);
            //PrintList(ans);

            //ans = Enumerable.Where(ints, x => x % 2 == 0).ToList();
            //PrintList(ans); 
            #endregion

            #region var Keyword

            //// C# Keyword 
            //// determine the datatype alone

            //var x = ConditionFunc.IsEven; 
            #endregion

            #region Function returns Function

            //Func01()(); 
            #endregion
        }
        #region Build in Delegate Functions to test
        //public static string fun02(int n)
        //{
        //    return " ";
        //}
        //public static int func01()
        //{
        //    return 1;
        //} 
        #endregion

        #region Example of function returns function
        //public static Action Func01()
        //{
        //    Action action = () => Console.WriteLine("Hello World!");
        //    return action;
        //} 
        #endregion
    }

}
    

