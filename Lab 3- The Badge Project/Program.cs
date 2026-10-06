/*
Name: Nicholas Mooney
Course: CSCI 1250, Section 001
Assignment: Lab 0, The Badge Project
Date: October 1, 2026
Description: 
*/



//Part 1

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

System.Console.Write("What is your full name?");

string fullName = Console.ReadLine();
fullName = fullName.Trim() ;

int spacePosition = fullName.IndexOf (" ") ;
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1) ;
 
 Console.WriteLine("Name on badge: " + fullName.ToUpper()) ;
 Console.WriteLine("Username:"  + fullName) ;
Console.WriteLine("Initials:"  + fullName.Substring(0 , 1) + "." + lastName.Substring(0 , 1) + "." );
 Console.WriteLine("Letters in Last Name :" + lastName.Length );



//Part 2
Random rng = new Random() ;

int studentID = rng.Next(100000 , 999999) ;
int lockerNumber = rng.Next(1 , 500); 

Console.WriteLine("Student ID: " + studentID);
Console.WriteLine("Locker Number: " + lockerNumber);


//Part 3

Console.Write("What is your dorms x location?");
double dormX = Convert.ToDouble(Console.ReadLine());

Console.Write("What is your dorms y location?");
double dormY = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the classes x location?");
double classX = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the classes y location?");
double classY = Convert.ToDouble(Console.ReadLine());

Console.Write("What is your walking feet per second?");
double feetPerSecond = Convert.ToDouble(Console.ReadLine());



double distance = Math.Sqrt(Math.Pow(classX - dormX,2) + Math.Pow(classY - dormY, 2));
double walkTime = distance / feetPerSecond ;
int totalSeconds = Convert.ToInt32 (walkTime) ;
int minutes = totalSeconds / 60 ;
int seconds = totalSeconds % 60 ; 


Console.WriteLine("Distance: " + distance.ToString("F1"));
Console.WriteLine("Walking time: " + minutes + " minutes "  + seconds + " seconds " );


