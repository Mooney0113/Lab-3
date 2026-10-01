/*
Name: Nicholas Mooney
Course: CSCI 1250, Section 001
Assignment: Lab 0, The Badge Project
Date: October 1, 2026
Description: 
*/



//Part 1

using System.Runtime.CompilerServices;

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


