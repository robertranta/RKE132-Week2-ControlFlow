// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//rakendus küsib kasutajal sisestada tema vanuse
//kui kastsuaja vanus on väiksem kui 13, siis konsoolis kuvatakse:
//"You are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to instagram!"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap,  13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to instagram!");
} 
else
{
    Console.WriteLine("You are too young to use instagram.");
}