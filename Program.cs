using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Assignment2_DIS_Spring2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] ar1 = { 2, 5, 1, 3, 4, 7 };
            int n1 = 3;
            ShuffleArray(ar1, n1);
            Console.WriteLine("");
            //Question 2 
            Console.WriteLine("Question 2");
            int[] ar2 = { 0, 1, 0, 3, 12 };
            MoveZeroes(ar2);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
            int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            CoolPairs(ar3);
            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            int[] ar4 = { 3, 3 };
            int target = 6;
            TwoSum(ar4, target);
            Console.WriteLine();

            //Question 5
            Console.WriteLine("Question 5");
            string s5 = "korfsucy";
            int[] indices = { 6, 4, 3, 2, 1, 0, 5, 7 };
            RestoreString(s5, indices);
            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            string s61 = "bulls";
            string s62 = "sunny";
            if (Isomorphic(s61, s62))
            {
               Console.WriteLine("Yes the two strings are Isomorphic");
            }
            else
            {
                Console.WriteLine("No, the given strings are not Isomorphic");
            }
                Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int n8 = 19;
            if (HappyNumber(n8))
              {
                  Console.WriteLine("{0} is a happy number", n8);
              }
             else
              {
                   Console.WriteLine("{0} is not a happy number", n8);
              }

              Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] ar9 = { 7, 1, 5, 3, 6, 4 };
            int profit = Stocks(ar9);
            if (profit == 0)
            {
                Console.WriteLine("No Profit is possible");
            }
            else
              {
                 Console.WriteLine("Profit is {0}", profit);
              }
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int n10 = 3;
            Stairs(n10);
            Console.WriteLine();
        }

       //function to shuffle the elements in the array

        private static void ShuffleArray(int[] nums, int n)
        {
            try
            {
                //filters the negative values of the given input and even length of the array.
                if (nums.Length % 2 == 0 && n > 0 && nums.Length / 2 == n)
                {

                    List<int> parts = new List<int>();
                    if (nums.Length == 2 * n)
                    {
                        //checks if the input array length is two times the target 
                        for (int i = 0; i <= 2 * n - 1; i++)
                        {//iterates over the array for 2 of n times
                            if (i < n)
                            {
                                //Adds elements to the new list parts
                                parts.Add(nums[i]);
                                parts.Add(nums[i + n]);
                                
                            }

                        }
                    }
                    //iterates over the list to return each element in the list
                    foreach (object each in parts)
                    {
                        //returns each element in the list 
                        Console.Write(each);


                    }

                }
                else
                {
                    //throws expection when it doesnt satisfy the condition.
                    throw new Exception();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //function to move zeros to the end in an array 
        private static void MoveZeroes(int[] ar2)
        {
            try
            {
                int count = 0;

                //iterates over the array for each elements in it
                for (int i = 0; i <= ar2.Length - 1; i++)
                  {
                    //condition to check if element is not equal to zero
                    if(ar2[i]!=0)
                       {
                        //reassigning the values to the array if the element is not zero
                         ar2[count] = ar2[i];
                             count++;

                       }

                     }
                    for (int j=ar2.Length-1;j>=count;j--)//iterates of the array in decremental order
                    {
                       ar2[j] = 0;
                    }

                     foreach (object each in ar2)
                     {
                    //iterates over the array to return each elements 
                       Console.Write(each);
                     }
                
            }
            catch (Exception)
            {

                throw;
            }
        }


        //function to return indices of the similar elements

        private static void CoolPairs(int[] nums)
        {
            try
            {
                //creates a dictonary
                Dictionary<int, int> dictonary = new Dictionary <int, int>();
                int count = 0; 
                for (int i =0; i< nums.Length;i++)
                {
                    //checks if the element is in dictonary
                    if(dictonary.ContainsKey(nums[i]))
                    {
                        count += dictonary[nums[i]];
                        dictonary[nums[i]]++;
                    }
                    else
                    {
                        //Adds elements to the dictonary
                        dictonary.Add(nums[i], 1);
                    }
                }
                //returns the final count of the cool pairs.
                Console.WriteLine(count);
            }
            catch (Exception)
            {

                throw;
            }
        }

        //function to return the elements index for the target element in the given input 
        private static void TwoSum(int[] nums, int target)
        {
            try
            {

                int check = 0;
                Dictionary<int, int> dictionary = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    //checks if the input indices sum is equal to the target
                    check = target - nums[i];
                    if (!dictionary.ContainsKey(check))
                    {
                        //Adds elements to the dictionary 
                        dictionary.Add(nums[i], i);
                    }
                    else
                    {
                        Console.WriteLine((dictionary[check], i));
                    }


                }
            }
            catch (Exception)
            {

                throw;
            }

        }


        //Function to return the string based on the indices positions 
        private static void RestoreString(string s, int[] indices)
        {
            try
            {
                //checks if the string length is equal to the indices length
                if (s.Length == indices.Length)
                {
                    int i = 0;

                    if (i <= indices.Length - 1)
                    {
                        

                        Dictionary<int, char> mydictionary = new Dictionary<int, char>();

                        foreach (char item in s)
                        {

                            //creates a dictionary with the indices as key and each letter as value 
                            mydictionary.Add(indices[i], item);
                            i++;
                        }

                        foreach (KeyValuePair<int, char> letter in mydictionary.OrderBy(k => k.Key))
                        {
                            //sorts the dictonary and returns the sorted string
                            Console.Write(letter.Value);


                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }


        //function to return if the input strings are isomorphic
        private static bool Isomorphic(string s1, string s2)
        {
            try
            {
                //filters if the both inputs are of same size
               if(s1.Length != s2.Length)
                {
                    return false;
                }
                Dictionary<char, char> mydictionary = new Dictionary<char, char>();

                for (int i = 0; i < s1.Length; i++)
                    {

                    //checks if the dictionary does not contain the element
                        if (!mydictionary.ContainsKey(s1[i]))
                        {

                            if(mydictionary.ContainsValue(s2[i]))
                            {
                                 return false;
                             }
                            else
                            {
                            //Adds elements to the dictionary
                                 mydictionary.Add(s1[i], s2[i]);
                            }
                
                            
                        }
                        else
                        {
                        //checks if the same key has same value if repeated twice
                            if(mydictionary[s1[i]] != s2[i])
                            {
                                return false;
                            }

                        }
                    



                    }
                    return true;
                    
               

            }
            catch (Exception)
            {

                throw;
            }
        }


        //Function to return the items values 
        private static void HighFive(int[,] items)
        {
            try
            {
                if (items.GetLength(0) > 100)
                {
                    throw new Exception();
                }
                Dictionary<int, List<int>> some = new Dictionary<int, List<int>>();

                if (items.Length <= 1000 && items.Length >= 1)
                {
                    for (int i = 0; i < items.GetLength(0); i++)
                    {
                        if (some.ContainsKey(items[i, 0]))
                        {
                            //Checking if the dict has any score of a particular student.
                            List<int> lListNew = some[items[i, 0]];
                            if (items[i, 1] > 100 || items[i, 1] < 0)
                            {
                                throw new Exception();
                            }
                            else
                            {
                                lListNew.Add(items[i, 1]);         //Adding the new  scores to the same list
                                some[items[i, 0]] = lListNew;
                            }
                        }
                        else
                        {
                            List<int> val = new List<int>();
                            if (items[i, 1] > 100 || items[i, 1] < 0)
                            {
                                throw new Exception();
                            }
                            else
                            {
                                val.Add(items[i, 1]);              //Adding the new scores to the new list
                                some.Add(items[i, 0], val);
                            }
                        }

                    }
                    if (some.Count > 1000 || some.Count == 1)
                    {
                        throw new Exception();
                    }
                    foreach (KeyValuePair<int, List<int>> entry in some)
                    {
                        if (entry.Value.Count < 5)
                        {
                            throw new Exception();
                        }
                        else
                        {
                            var a = entry.Value;            //saving the value to a variable
                            a.Sort();
                            a.Reverse();                //sorting the list and arranging in descending order and picking top 5 scores
                            var b = a.GetRange(0, 5);
                            Console.WriteLine((entry.Key, b.Sum() / 5));        //printing the average of 5 scores
                        }

                    }
                }
                else
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("1 <= items.length <= 1000" + "/n" + "items[i].length == 2" + "/n" + "1 <= IDi <= 1000" + "/n" + "0 <= scorei <= 100" + "/n" + " For each IDi, there will be at least five scores.")
                     ;

            }
        }





        //function to return if the given number is a happy number or not.

        private static bool HappyNumber(int n)
        {
            try
            {
                //checks if the n is greater than 0
                if (n > 0)
                {
                    //creates the hashset
                    HashSet<int> input = new HashSet<int>() { n };
                    while (n != 1)
                    {
                        int sum = 0;
                        while (n > 0)
                        {
                            //logic to add the squares of the number to the sum
                            int d = n % 10;
                            sum += d * d;
                            n = n / 10;
                        }
                        if (!input.Add(sum))
                            return false;
                        n = sum;
                    }
                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }



        //function for the invesments in the stocks
        private static int Stocks(int[] prices)
        {
            try
            {
                //checks if the price is null or 0
                if (prices == null || prices.Length == 0)
                {
                    return 0;
                }

                int profit = 0;
                int b = Array.IndexOf(prices, prices.Min());
                
                for (int i = b; i < prices.Length; i++)
                {
                    //checks if prices difference is greater than profit 
                    if (prices[i] - prices[b] > profit)
                    {
                        profit = prices[i] - prices[b];
                    }
                }
                return profit;//returns profit
                
            }
            catch (Exception)
            {

                throw;
            }
        }

//function to return number of steps we can take
        private static void Stairs(int steps)
        {
            try
            {
                int[] sum = new int[steps + 2];
                sum[0] = 0;
                sum[1] = 1;
                for (int i = 2; i <= steps + 1; i++)
                {
                    //sum of the steps by iterating in all possible ways
                    sum[i] = sum[i - 1] + sum[i - 2];
        
                }

                Console.WriteLine("Sum = " + sum[steps + 1]);


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
