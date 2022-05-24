using System;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace Exercicies
{
    class Program
    {
        public static int[] ArrayInverse(int[] numbers)
        {
            int[] resultado = new int[numbers.Length];

            for (int i = numbers.Length; i > 0; i--)
                resultado[numbers.Length - i] = numbers[i - 1];

            return resultado;
        }
        public static void CountFiveToHundred()
        {
            for (int i = 5; i < 100; i += 5)
            {
                Console.WriteLine(i);
            }
        }
        public static void CountEvenBetweenInterval(int A, int B)
        {
            for (int i = A; i < B; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i);
            }
        }
        public static void CountUntillComplete30(int Age)
        {
            if (Age > 18)
            {
                Console.WriteLine("Maior de idade");
                for (int i = Age; i < 30; i++)
                {
                    Console.WriteLine($"Ainda faltam {30 - i} anos para você completar 30 anos.");
                }
                Console.WriteLine("Voce completou 30 anos");
            }
            else
                Console.WriteLine("Menor de idade");
        }
        public static int FactorialNumber(int number)
        {
            int resultado = number;
            for (int i = 1; i < number; i++)
            {
                resultado *= (number - i);
            }
            return resultado;
        }
        public static void FibonacciSequence()
        {
            int x = 0;
            int y = 1;
            int z;
            for (int i = 0; i < 20; i++)
            {
                z = y + x;
                Console.Write(z);
                x = y;
                y = z;
            }
        }
        public static int MultiplicationWithoutSignal(int numberA, int numberB)
        {
            int result = numberA;
            for (int i = 1; i < numberB; i++)
            {
                result += numberA;
            }
            return result;
        }
        public static int DivisorsOfNumber(int numberA)
        {
            int divisor = 10;
            int divisors = 1;
            for (int i = 1; i < divisor; i++)
            {
                if (divisor % i == 0)
                {
                    divisors++;
                }
            }
            return divisors;
        }
        public static string NameShuffle(string name) => name.Split(" ").Aggregate((antecessor, sucessor) => sucessor += " " + antecessor);
        public static int[] SortNumbs(int[] array)
        {

            Array.Sort(array);
            return array;
        }
        public static int[] ArrayOfMultiples(int num, int length) => Enumerable.Range(1, length).Select(x => x * num).ToArray();
        public static int[] MultiplyByLength(int[] arr) => arr.Select(x => x * arr.Length).ToArray();
        public static int CountDs(string word) => word.ToLower().Count(x => x == 'd');
        public static string[] ParseArray(object[] array) => array.Select(x => Convert.ToString(x)).ToArray();
        public static int CounterPartCharCode(char symbol) => char.IsLower(symbol) ? char.ConvertToUtf32(symbol.ToString().ToUpper(), 0) : char.ConvertToUtf32(symbol.ToString().ToLower(), 0);
        public static int collatz(int num)
        {
            int count = 0;
            while (num != 1)
            {
                if (num % 2 == 0)
                {
                    num /= 2;
                    count++;
                }
                else
                {
                    num = num * 3 + 1;
                    count++;
                }
            }
            return count;
        }
        public static string ReverseAndNot(int i) => string.Concat(i.ToString().Reverse()) + i.ToString();
        public static bool ValidatePin(string pin)
        {
            if (pin.Length == 6 || pin.Length == 4)
            {
                if (pin.Any(x => !char.IsNumber(x)))
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
        public static string Bomb(string txt) => txt.ToLower().Contains("bomb") ? "Duck!!!" : "There; is no bomb, relax.";
        public static double[] FindTheLargestNumbersArrays(double[][] values) => values.Select(x => x.Max()).ToArray();
        public static bool EqualityCheck(object a, object b) => a.Equals(b);
        public static string ReverseTheCase(string str) => string.Concat(str.Select(x =>
           {
               if (char.IsUpper(x))
                   return char.ToLower(x);
               else
                   return char.ToUpper(x);
           }));

        //Hard
        public static string ImaginaryCodingInterview(int[] array, int total)
        {
            var count = 10;
            bool result = true;
            for (int i = 0; i <= array.Length - 1; i += 2)
            {
                if (array.Count() < 8)
                    return "disqualified";
                result = array[i] <= count / 2 && array[i + 1] <= count / 2;
                count += 10;
                if (!result)
                    break;
            }
            if (array.Count() == 8 && result && total <= 120)
                return "qualified";
            else
                return "disqualified";

            //var timeLimits = new int[] { 5, 5, 10, 10, 15, 15, 20, 20 };
            //return arr.Zip(timeLimits, (a, b) => a <= b).Count(s => s) == 8 && tot <= 120
            //    ? "qualified"
            //    : "disqualified";

        }
        public static bool ConsecutiveNumbers(int[] array)
        {
            var teste = array.OrderBy(x => x).ToArray();
            bool result = true;
            for (int i = 0; i < teste.Length - 1; i++)
            {
                if (teste[i + 1] == teste[i] + 1)
                    result = true;
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public static int[] PositiveCountAndNegativeSum(double[] arr)
        {
            int[] resultado = new int[2];
            resultado[0] = arr.Where(x => x > 0).Count();
            resultado[1] = (int)arr.Where(x => x < 0).Sum();

            return resultado;
        }
        public static bool IsIsogram(string str)
        {

            return str.ToLower().Distinct().Count() == str.Length;

        }
        public static int CountOnes(int i)
        {
            string binary = Convert.ToString(i, 2);
            return binary.Where(x => x == '1').Count();
        }
        public static int SumOfTheTwoSmallestNumbers(int[] array) => array.OrderBy(x => x).Where(x => x > 0).Take(2).Sum();
        public static int[] FilterOutStringFromArray(object[] array) => Enumerable.OfType<int>(array.ToList()).ToArray();
        public static string MaskifyTheString(string str)
        {
            if (str.Length < 5 || string.IsNullOrEmpty(str))
                return str;

            var result = str.Substring(0, str.Length - 4).Select(x => x = '#');
            var resultado = " ";
            foreach (var item in result)
            {
                resultado += item;
            }
            return resultado += str.Substring(str.Length - 4);
        }
        public static bool IsTheNumberSymmetrical(int num)
        {
            if (num.ToString() == string.Join("", num.ToString().ToCharArray().Reverse()))
                return true;

            return false;
        }
        public static bool FractionGreaterThanOne(string str)
        {
            var result = str.Split('/');
            return double.Parse(result[0]) / double.Parse(result[1]) > 1;
        }
        public static string ScottishScreaming(string str) => string.Concat(str.Select(x => "aeiou".Contains(char.ToLower(x)) ? x = 'e' : x).ToArray()).ToUpper();
        public static int gcd(int n1, int n2)
        {
            bool maior = n1 > n2;
            int divisor = 0;
            if (maior)
            {
                for (int i = 1; i <= n2; i++)
                {
                    if (n1 % i == 0 && n2 % i == 0)
                    {
                        divisor = i;
                    }
                }
            }
            else
            {
                for (int i = 1; i <= n1; i++)
                {
                    if (n1 % i == 0 && n2 % i == 0)
                    {
                        divisor = i;
                    }
                }
            }
            return divisor;
        }
        public static bool KTok(string n, int k)
        {
            if (Math.Pow(k, k) == Convert.ToInt64(n))
                return true;
            else
                return false;
        }
        public static bool CheckPerfect(int num) => Enumerable.Range(1, num - 1).Where(x => num % x == 0).Aggregate((antecessor, sucessor) => antecessor += sucessor).Equals(num);
        public static double Mypi(int n) => Math.Round(Math.PI, n);
        public static string MysteryFunc(string str)
        {
            var letters = str.Where(x => char.IsLetter(x)).ToArray();
            var numbers = str.Where(x => char.IsNumber(x)).Select(x => int.Parse(x.ToString())).ToArray();
            var resultado = "";
            for (int i = 0; i < letters.Length; i++)
                resultado += new string(letters[i], numbers[i]);

            return resultado;
        }
        public static int SockPair(string socks)
        {
            return string.IsNullOrEmpty(socks) ? 0 : socks.OrderBy(x => x).GroupBy(x => x).ToList().Select(x =>
           {
               if (x.Count() > 0 && x.Count() % 2 != 0)
                   return (x.Count() - 1) / 2;
               else if (x.Count() > 0)
                   return x.Count() / 2;
               else
                   return 0;
           }).Aggregate((antecessor, sucessor) => sucessor += antecessor);
        }
        public static int SortDesceding(int num)
        {
            return Convert.ToInt32(new string(num.ToString().ToArray().OrderByDescending(x => x).ToArray()));
        }
        public static string HighLow(string str)

        {
            var teste = str.Split(' ').ToArray().Min(x => int.Parse(x));
            var result = str.Split(' ').Select(int.Parse);
            return string.Join(' ', str.Split(' ').ToArray().Max(x => int.Parse(x)), str.Split(' ').ToArray().Min(x => int.Parse(x)));
        }
        public static string GetMiddle(string str)
        {
            string resultado = "";
            if (str.Length == 1)
            {
                return str;
            }
            if (str.Length % 2 == 0)
            {
                resultado = str.Substring(str.Length / 2 - 1, 2);
            }
            else
            {
                resultado = str.Substring((str.Length - 1) / 2, 1);
            }
            return resultado;
        }
        public static string Uncessor(string txt, string vowels)
        {
            int count = 0;
            return string.Concat(txt.Select(x =>
             {
                 if (x == '*')
                 {
                     x = vowels[count];
                     count++;
                 }
                 return x;
             }));
        }
        public static string CupSwapping(string[] swaps)
        {
            string count = "B";
            return swaps.Any() ? swaps.Select(x =>
            {
                if (x.Contains(count))
                    count = new string(x.Where(x => x != count[0]).ToArray());

                return count;
            }).ToList().LastOrDefault() : count;
        }
        public static bool IsSmooth(string sentence)
        {
            bool count = false;
            var teste = sentence.Split(' ');
            for (int i = 0; i <= teste.Length - 1; i++)
            {
                if (teste[i].Last().ToString().ToLower() == teste[i + 1].First().ToString().ToLower())
                {
                    count = true;
                }
                else
                {
                    count = false;
                    break;
                }
            }
            return count;
        }
        public static int NextPrime(int num)
        {
            bool teste = false;
            int count = 0;
            while (teste == false)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count += i;
                    }
                }
                if (count - 1 == num)
                {
                    break;
                }
                num++;
                count = 0;
            }
            return num;
        }
        public static string ReverseOdd(string str)
        {
            return string.Join(" ", str.Split(" ").Select(x =>
              {
                  if (x.Count() % 2 == 0)
                      return x;
                  return new string(x.Reverse().ToArray());
              }).ToArray());
        }
        public static int DuplicateCount(string str)
        {
            return str.GroupBy(x => x).Count(x => x.Count() > 1);
        }
        public static bool IsStrangePair(string str1, string str2)
        {
            return str1.EndsWith(str2[0]) && str2.EndsWith(str1[0]);
        }
        public static string LongestCommonEnding(string str, string str2)
        {
            string result = "";
            if (str.Length > str2.Length)
            {
                var equal = str.Substring(str.Length - str2.Length);
                for (int i = 0; i < equal.Length; i++)
                {
                    if (equal.Substring(i) == str2.Substring(i))
                    {
                        result = equal.Substring(i);
                        break;
                    }
                }
            }
            else
            {
                var equal = str2.Substring(str2.Length - str.Length);
                for (int i = 0; i < equal.Length; i++)
                {
                    if (equal.Substring(i) == str.Substring(i))
                    {
                        result = equal.Substring(i);
                        break;
                    }
                }

            }

            return result;
        }
        public static string Fibonacci(int n)
        {
            BigInteger X = 0;
            BigInteger Y = 1;
            BigInteger result = 0;
            for (int i = 1; i < n; i++)
            {
                result = Y + X;
                X = Y;
                Y = result;
                Console.WriteLine(result);
            }

            return result.ToString();
        }
        public static int License(string me, int agents, string others)
        {
            var result = 20;
            var teste = others.Split(' ').ToList();
            var teste2 = teste.OrderBy(x => x).ToArray();
            var teste3 = Array.IndexOf(teste2, me) + 1;
            result += (teste3 - agents) * 20;
            return result;
        }
        public static int Potatoes(string potato)
        {
            return Regex.Matches(potato, "potato").Count;
        }
        public static bool isPalindrome(string str)
        {
            var teste = new string(str.ToLower().ToCharArray().Reverse().ToArray());

            return new string(str.ToLower().ToCharArray().Reverse().ToArray()) == str.ToLower();
        }
        public static string Century(int year)
        {
            var result = year.ToString();
            string retorno = "";
            var century = int.Parse($"{result[0]}{result[1]}");
            if (year >= int.Parse($"{century}01") && year <= int.Parse($"{century + 1}00"))
            {
                retorno = century + 1 == 21 ? "st" : "th";
                return $"{century + 1}" + retorno + " " +  "century";
            }

            retorno = century == 21 ? "st" : "th";
            return $"{century}{retorno} century";
        }
        public static string Encrypt(string word)
        {
            
            var StringArray = word.ToCharArray();
            
            Array.Reverse(StringArray);
           
            var result = StringArray.Select(x =>
            {
                switch (x)
                {
                    case 'a':
                        return '0';
                    case 'e':
                        return '1';
                    case 'i':
                        return '2';
                    case 'o':
                        return '2';
                    case 'u':
                        return '3';

                    default:
                        return x;
                }
            }).ToArray();

            return new string(result) + "aca";
        }
        public static string NoYelling(string phrase) => string.Join(' ', string.Join(' ', phrase.Split(" ").SkipLast(1)), new string(phrase.Split(" ").Last().ToCharArray().Distinct().ToArray())); 
        public static int LargestGap(int[] arr)
        {
            var result = 0;
            var teste = arr.OrderBy(x => x).ToArray();
            for (int i = 0; i < teste.Length - 1; i++)
            {
                if(teste[i + 1] - teste[i] > result)
                result = teste[i + 1] - teste[i];
            }
            return result;
        }
        public static int LargestGap2(int[] arr)
        {
            Array.Sort(arr);

            var test =  arr.Skip(1).Select((s, sa) => s - arr[sa]).ToArray();
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(LargestGap2(new int[] { 8, 11, 24, 2, 7, 4, 4, 25, 24, 14, 8, 0, 7 }));
        }
    }
}