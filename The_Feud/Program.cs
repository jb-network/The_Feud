// This is challenge work for the "C# Players Guide"
// Level 33  "The Feud" Challenge
//This is a challenge to resolve duplicate naming conflicts across Namespaces
//Solution used provided both Aliases and FQ Names

using IField;
using McDroid;

//Making Aliase for each Pig
using IFieldPig = IField.Pig;
using McDroidPig = McDroid.Pig;

// Using Aliase to make each Pig
IFieldPig IPig = new IFieldPig();
McDroidPig MPig = new McDroidPig();

//Fully Qualified Name for Goats
IField.Goat IGoat = new IField.Goat();
McDroid.Goat MGoat = new McDroid.Goat();

//Non Shared Names for Sheep and Cow
Sheep ISheep = new Sheep();
Cow MCow = new Cow();

//Wrap up
Console.WriteLine("All object created with no errors");
Console.WriteLine("Press any key to end the program");
Console.ReadKey();
