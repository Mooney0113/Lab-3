/*
Name: Nicholas Mooney
Course: CSCI 1250, Section 001
Assignment: Lab 0, The Badge Project
Date: October 1, 2026
Description: 
*/



//Part 1

string fullName = Console.ReadLine();
fullName = fullName.Trim() ;

int spacePosition = fullName.IndexOf (" ") ;
string firstName = fullName.Substring(0, spacePosition);
string lastName = fullName.Substring(spacePosition + 1) ;



//Part 2