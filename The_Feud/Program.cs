// This is challenge work for the "C# Players Guide"
// Level 33  "The Feud" Challenge
// This is a challenge to resolve conflicts in Naming Spaces
// Used both Aliases and FQ Names

using IField;
using McDroid;

//Aliases
using IFieldPig = IField.Pig;
using McDroidPig = McDroid.Pig;

IFieldPig IPig = new IFieldPig();
McDroidPig MPig = new McDroidPig();

//Fully Qualified Name
IField.Goat IGoat = new IField.Goat();
McDroid.Goat MGoat = new McDroid.Goat();

//Non Shared Names
Sheep ISheep = new Sheep();
Cow MCow = new Cow();

Console.WriteLine("All object created with no errors");
Console.WriteLine("Press any key to end the program");
Console.ReadKey();