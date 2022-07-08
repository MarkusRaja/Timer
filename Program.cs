using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Time_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Function of bool and do is the user can go back again to first menu but if the timer still running this bool have a bug. The bug is user should be wait a few hours/minutes/seconds. This code has fuction for typing error.
            bool mainmenu = true;
            do
            {
            //This lable to go back to first menu without bug.
            firstmenu:
                //Function Console Clear is the program clearing the console.
                Console.Clear();
                Console.WriteLine("Welcome to the timer and the stopwatch program");
                Console.Write("Type timer if you want the timer or type stopwatch if you want the stopwatch: ");
                //This is The user input to choose the program.
                var choice = Console.ReadLine();
                //This is conditional of timer program
                if ((choice == "timer") || (choice == "Timer"))
                {
                //This lable is the point reusing the timer program.
                timerback:
                    //Function Console Clear is the program clearing the console.
                    Console.Clear();
                    Console.WriteLine("Do you want to see elapsed time or not?");
                    Console.Write("Type 'yes' if you want the timer show the elapsed time or type 'no' if you want the timer doesn't: ");
                    //This is The user input options want to show the elapsed time or hide it.
                    var answerelp = Console.ReadLine();
                    //This is the conditional of "yes" words.
                    if ((answerelp == "yes") || (answerelp == "Yes"))
                    {
                        Console.Clear();
                        Console.Write("How long time do you want type in hh:mm:ss format: ");
                        //This is the user input of the how long time.
                        string timervalue = Console.ReadLine();

                        //This code to recognize the int value of string value
                        string[] clockstart = timervalue.Split(':');
                        int hour = Convert.ToInt32(clockstart[0]);
                        int minute = Convert.ToInt32(clockstart[1]);
                        int second = Convert.ToInt32(clockstart[2]);
                    //This lable to continue the timer progress.
                    timercontinue:
                        //The do while code to solve the bug if user press enter, even though has a little bug. It is when you press enter you should type more than 2 characters, if not you go back to first menu.
                        do
                        {
                            //This is the loop code of the timer program with the enter hotkey.
                            while (!Console.KeyAvailable && second >= 0 && minute >= 0 && hour >= 0)
                            {
                                //This code will be decresed the seconds value.
                                second--;
                                //This is the interval of timer.
                                Thread.Sleep(1000);
                                //This is the conditional and the mathematic code to support the hh:mm:ss format.
                                if (second == -1) { second = 59; minute = minute - 1; }
                                if (minute == -1) { minute = 59; hour = hour - 1; }
                                Console.Clear();
                                //This code to display the timer progress.
                                Console.WriteLine(hour + " : " + minute + " : " + second);
                                Console.Write("Press Enter to Pause It");
                                //Function of this Conditional Code is when All of the value timer is 0 the program will be give the options.
                                if (hour == 0 && minute == 0 && second == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Time up!!! do you want to reuse the timer, or go back to first menu?");
                                    Console.Write("Type 'tp' to reuse the timer program, or 'fm' to go back first menu: ");
                                    var answerdonetimer = Console.ReadLine();
                                    //Function of this code is going to the timerback lable.
                                    if (answerdonetimer == "tp")
                                    {
                                        goto timerback;
                                    }
                                    //Function of this code is going to the firstmenu lable.
                                    else if (answerdonetimer == "fm")
                                    {
                                        goto firstmenu;
                                    }
                                }
                                //Function of this code is to pause the timer progress.
                                else if (Console.KeyAvailable)
                                {
                                    Console.Clear();
                                    Thread.Sleep(1);
                                    //Function of this code is to display the timer progress when it paused.
                                    Console.WriteLine(hour + " : " + minute + " : " + second);

                                    Console.WriteLine("Paused");
                                    Console.WriteLine("You still have the time!!!! Do you want to continue or not / reuse the timer program / go to back main menu?");
                                    Console.Write("Type 'tp' to reuse the timer program, or 'fm' to back first menu / type 'c' to continue the progress / type fm to go back to first menu: ");
                                    var answercontinue = Console.ReadLine();
                                    //Function of this code is to give options when the timer paused.
                                    if (answercontinue == "c")
                                    {
                                        goto timercontinue;
                                    }
                                    else if (answercontinue == "tp")
                                    {
                                        goto timerback;
                                    }
                                    else if (answercontinue == "fm")
                                    {
                                        goto firstmenu;
                                    }
                                    //Function of this code is to paused the timer progress.
                                    break;
                                }

                            }
                        }
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    }
                    //This is the conditional of "no" words if the user do not show the timer progress.
                    if ((answerelp == "no") || (answerelp == "No"))
                    {
                        //All of this code still same with previously.
                        Console.Clear();
                        Console.Write("How long time do you want type in hh:mm:ss format: ");
                        string timervalue = Console.ReadLine();

                        string[] clockstart = timervalue.Split(':');
                        int hour = Convert.ToInt32(clockstart[0]);
                        int minute = Convert.ToInt32(clockstart[1]);
                        int second = Convert.ToInt32(clockstart[2]);
                    timercontinue:
                        do
                        {
                            while (!Console.KeyAvailable && second >= 0 && minute >= 0 && hour >= 0)
                            {
                                second--;
                                Thread.Sleep(1000);
                                if (second == -1) { second = 59; minute = minute - 1; }
                                if (minute == -1) { minute = 59; hour = hour - 1; }
                                Console.Clear();
                                Console.WriteLine("The Program Counting the Time");
                                Console.Write("Press Enter to Pause It");
                                if (hour == 0 && minute == 0 && second == 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Time up!!! do you want to reuse the timer, or go back to first menu?");
                                    Console.Write("Type 'tp' to reuse the timer program, or 'fm' to go back first menu: ");
                                    var answerdonetimer = Console.ReadLine();
                                    if (answerdonetimer == "tp")
                                    {
                                        goto timerback;
                                    }
                                    else if (answerdonetimer == "fm")
                                    {
                                        goto firstmenu;
                                    }
                                }
                                else if (Console.KeyAvailable)
                                {
                                    Console.Clear();
                                    Thread.Sleep(1);

                                    Console.WriteLine("Paused");
                                    Console.WriteLine("You still have the time!!!! Do you want to continue or not / reuse the timer program / go to back main menu?");
                                    Console.Write("Type 'tp' to reuse the timer program, or 'fm' to back first menu / type 'c' to continue the progress / type fm to go back to first menu: ");
                                    var answercontinue = Console.ReadLine();

                                    if (answercontinue == "c")
                                    {
                                        goto timercontinue;
                                    }
                                    else if (answercontinue == "tp")
                                    {
                                        goto timerback;
                                    }
                                    else if (answercontinue == "fm")
                                    {
                                        goto firstmenu;
                                    }
                                    break;
                                }

                            }
                        }
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    }

                }
                //Function of this code is conditional of stopwatch.
                else if ((choice == "stopwatch") || (choice == "Stopwatch"))
                {
                //This lable is the point reusing the stopwatch program
                stopwatchback:
                    //Function Console Clear is the program clearing the console.
                    Console.Clear();
                    Console.Write("Type 'start' if you want to start: ");
                    //The user input variable of start.
                    var start = Console.ReadLine();
                    //This is all of start time integers.
                    int second = 0;
                    int minute = 0;
                    int hour = 0;
                //This lable is continue the stopwatch progress.
                stopwatchcontinue:
                    //Function of this code is conditional of start.
                    if ((start == "start") || (start == "Start"))
                    {
                        do
                        {
                            //Function of this code is looping the time of stopwatch.
                            while (!Console.KeyAvailable && second >= 0 && minute >= 0 && hour >= 0)
                            {
                                //Function of this code is to increase the second value.
                                second++;
                                Thread.Sleep(1000);
                                //Function of this code is the conditional and mathematic to support hh:mm:ss format.
                                if (second == 59) { second = 0; minute = minute + 1; }
                                if (minute == 59) { minute = 0; hour = hour + 1; }
                                Console.Clear();
                                Console.WriteLine(hour + " : " + minute + " : " + second);
                                Console.Write("Press Enter to Pause It");
                                if (Console.KeyAvailable)
                                {
                                    Console.Clear();
                                    Thread.Sleep(1);
                                    Console.WriteLine(hour + " : " + minute + " : " + second);

                                    Console.WriteLine("Paused");
                                    Console.Write("Type 'tp' to reuse the stopwatch program, or 'fm' to back first menu / type 'c' to continue the progress / type fm to go back to first menu: ");
                                    var answercontinue = Console.ReadLine();
                                    //Function of this code is the options when stopwatch paused.
                                    if (answercontinue == "c")
                                    {
                                        goto stopwatchcontinue;
                                    }
                                    else if (answercontinue == "tp")
                                    {
                                        //Function of this code is going to the stopwatchback lable.
                                        goto stopwatchback;
                                    }
                                    else if (answercontinue == "fm")
                                    {
                                        //Function of this code is going to the firstmenu lable.
                                        goto firstmenu;
                                    }
                                    break;
                                }

                            }
                        }
                        while (Console.ReadKey(true).Key != ConsoleKey.Enter);
                    }
                    
                }


            }
            while (mainmenu);
        }
    }
}
