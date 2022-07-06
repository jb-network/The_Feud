// This is challenge work for the "C# Players Guide"
// Level 33  "The Feud" Challenge
//This is a challenge to resolve duplicate naming conflicts across Namespaces
//Solution used provided both Aliases and FQ Names

using IField;
using McDroid;

//Aliase for IField Pig
using IFieldPig = IField.Pig;
IFieldPig IPig = new IFieldPig();

//Aliase for McDroid Pig
using McDroidPig = McDroid.Pig;
McDroidPig MPig = new McDroidPig();

//Fully Qualified Name
IField.Goat IGoat = new IField.Goat();
McDroid.Goat MGoat = new McDroid.Goat();

//Non Shared Names
Sheep ISheep = new Sheep();
Cow MCow = new Cow();

//Wrap up
Console.WriteLine("All object created with no errors");
Console.WriteLine("Press any key to end the program");
Console.ReadKey();
