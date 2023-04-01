using System;
namespace NumberToWorld;
class NumberToWorld1
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter number =");
        number = int.Parse(Console.ReadLine());
        if (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid number.");
            return;
        }
        if (number >= 0 && number <= 10)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;

            }

        }

        else if (number >= 10 && number < 20)
        {
            switch (number)
            {
                case 10:
                    Console.WriteLine("Ten");
                    break;
                case 11:
                    Console.WriteLine("Eleven");
                    break;
                case 12:
                    Console.WriteLine("Twelve");
                    break;
                case 13:
                    Console.WriteLine("Thirteen");
                    break;
                case 14:
                    Console.WriteLine("Fourteen");
                    break;
                case 15:
                    Console.WriteLine("Fifteen");
                    break;
                case 16:
                    Console.WriteLine("Sixteen");
                    break;
                case 17:
                    Console.WriteLine("Seventeen");
                    break;
                case 18:
                    Console.WriteLine("Eighteen");
                    break;
                case 19:
                    Console.WriteLine("Nineteen");
                    break;
            }

        }
        else if (number >= 20 && number < 100)
        {
            int tens = number / 10;
            int ones = number % 10;
            switch (tens)
            {
                case 2:
                    Console.Write("Twenty");
                    break;
                case 3:
                    Console.Write("Thirty");
                    break;
                case 4:
                    Console.Write("Forty");
                    break;
                case 5:
                    Console.Write("Fifty");
                    break;
                case 6:
                    Console.Write("Sixty");
                    break;
                case 7:
                    Console.Write("Seventy");
                    break;
                case 8:
                    Console.Write("Eighty");
                    break;
                case 9:
                    Console.Write("Ninety");
                    break;
            }

            if (ones > 0)
            {
                Console.Write(" ");
                switch (ones)
                {
                    case 1:
                        Console.WriteLine("One");
                        break;
                    case 2:
                        Console.WriteLine("Two");
                        break;
                    case 3:
                        Console.WriteLine("Three");
                        break;
                    case 4:
                        Console.WriteLine("Four");
                        break;
                    case 5:
                        Console.WriteLine("Five");
                        break;
                    case 6:
                        Console.WriteLine("Six");
                        break;
                    case 7:
                        Console.WriteLine("Seven");
                        break;
                    case 8:
                        Console.WriteLine("Eight");
                        break;
                    case 9:
                        Console.WriteLine("Nine");
                        break;
                }
            }
            else
            {
                Console.WriteLine();
            }


        }
        else if (number >= 100 && number < 1000)
        {
            {
                int hundreds = number / 100;
                int remainder = number % 100;

                switch (hundreds)
                {
                    case 1:
                        Console.Write("One Hundred");
                        break;
                    case 2:
                        Console.Write("Two Hundred");
                        break;
                    case 3:
                        Console.Write("Three Hundred");
                        break;
                    case 4:
                        Console.Write("Four Hundred");
                        break;
                    case 5:
                        Console.Write("Five Hundred");
                        break;
                    case 6:
                        Console.Write("Six Hundred");
                        break;
                    case 7:
                        Console.Write("Seven Hundred");
                        break;
                    case 8:
                        Console.Write("Eight Hundred");
                        break;
                    case 9:
                        Console.Write("Nine Hundred");
                        break;
                }

                if (remainder > 0)
                {
                    Console.Write(" and ");
                    if (remainder >= 1 && remainder <= 10)
                    {
                        switch (remainder)
                        {
                            case 1:
                                Console.WriteLine("One");
                                break;
                            case 2:
                                Console.WriteLine("Two");
                                break;
                            case 3:
                                Console.WriteLine("Three");
                                break;
                            case 4:
                                Console.WriteLine("Four");
                                break;
                            case 5:
                                Console.WriteLine("Five");
                                break;
                            case 6:
                                Console.WriteLine("Six");
                                break;
                            case 7:
                                Console.WriteLine("Seven");
                                break;
                            case 8:
                                Console.WriteLine("Eight");
                                break;
                            case 9:
                                Console.WriteLine("Nine");
                                break;
                            case 10:
                                Console.WriteLine("Ten");
                                break;
                        }
                    }
                    else if (remainder > 10 && remainder < 20)
                    {
                        switch (remainder)
                        {
                            case 11:
                                Console.WriteLine("Eleven");
                                break;
                            case 12:
                                Console.WriteLine("Twelve");
                                break;
                            case 13:
                                Console.WriteLine("Thirteen");
                                break;
                            case 14:
                                Console.WriteLine("Fourteen");
                                break;
                            case 15:
                                Console.WriteLine("Fifteen");
                                break;
                            case 16:
                                Console.WriteLine("Sixteen");
                                break;
                            case 17:
                                Console.WriteLine("Seventeen");
                                break;
                            case 18:
                                Console.WriteLine("Eighteen");
                                break;
                            case 19:
                                Console.WriteLine("Nineteen");
                                break;
                        }
                    }
                    else if (remainder >= 20 && remainder < 100)
                    {
                        int tens = remainder / 10;// Phần tròn chục
                        int ones = remainder % 10;// phần lẻ 

                        switch (tens)
                        {
                            case 2:
                                Console.Write("Twenty");
                                break;
                            case 3:
                                Console.Write("Thirty");
                                break;
                            case 4:
                                Console.Write("Forty");
                                break;
                            case 5:
                                Console.Write("Fifty");
                                break;
                            case 6:
                                Console.Write("Sixty");
                                break;
                            case 7:
                                Console.Write("Seventy");
                                break;
                            case 8:
                                Console.Write("Eighty");
                                break;
                            case 9:
                                Console.Write("Ninety");
                                break;
                        }
                        if (ones > 0)
                        {
                            Console.Write(" and ");
                            if (ones >= 1 && ones <= 10)
                            {
                                switch (ones)
                                {
                                    case 1:
                                        Console.WriteLine("One");
                                        break;
                                    case 2:
                                        Console.WriteLine("Two");
                                        break;
                                    case 3:
                                        Console.WriteLine("Three");
                                        break;
                                    case 4:
                                        Console.WriteLine("Four");
                                        break;
                                    case 5:
                                        Console.WriteLine("Five");
                                        break;
                                    case 6:
                                        Console.WriteLine("Six");
                                        break;
                                    case 7:
                                        Console.WriteLine("Seven");
                                        break;
                                    case 8:
                                        Console.WriteLine("Eight");
                                        break;
                                    case 9:
                                        Console.WriteLine("Nine");
                                        break;
                                    case 10:
                                        Console.WriteLine("Ten");
                                        break;
                                }
                            }



                        }
                    }
                }
            }
        }
    }
}
