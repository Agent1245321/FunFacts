// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Text;

string cssSheet = "C:\\Users\\JacobPrice\\Documents\\FunFacts\\styles.css";

Console.WriteLine("This is a compiler for the funfacts page");
Console.WriteLine("Modes:" + "\n1: Theme Painter" + "\n2: Master Revamp");

int mode = Convert.ToInt32(Console.ReadLine());

if (mode == 1)
{
    Console.WriteLine("Theme Paineter Starting...");
    UpdateThemes();
}
else if (mode == 2)
{
    Console.WriteLine("Not Available Yet");
}




void UpdateThemes()
{
    Console.WriteLine("Please fill out the following five dialogs with the 6 digit hexcodes of your pallete");

    string hex1 = Console.ReadLine();
    string hex2 = Console.ReadLine();
    string hex3 = Console.ReadLine();
    string hex4 = Console.ReadLine();
    string hex5 = Console.ReadLine();

    IEnumerable<string> cssstrings = new List<string>() { "body{",
$"background-color: #{hex1}; /* 1 */ ",
$"border-color: #{hex4}; /* 4 */ ",
"margin: 21, 21, auto, auto;",
"border-style: solid; ",
"border-width: 4px; }",
".headings{ ",
$"color: #{hex3}; /* 3 */ ",
$"background-color: #{hex2};	/* 2 */ ",
$"border-color: #{hex4}; /* 4 */ ",
"font-family: sans-serif;",
"margin: 10px, 10px, 10px, 10px;",
"font-size: 80px;",
"text-align: center;",
"border-style: solid;",
"border-width: 4px;",
"padding: 10, 10, 10, 10; }",
"p{",
$"color: #{hex5};     /* 5 */",
"margin-top: 4px;",
"margin: auto 20px;",
"font-family: sans-serif;",
"font-size: 40px;}",
"#p1{",
$"color: #{hex1}; /* 1 */",
"font-family: Arial, Helvetica, sans-serif;}",
"#atr{",
"margin-top: 0;}",
"img {",
"display: block;",
"margin: 30px auto;",
"text-align: center;",
"height: 600px;",
"width: auto;} };"
};


    if (File.Exists("C:\\Users\\JacobPrice\\Documents\\FunFacts\\Replacement.txt"))
    {
        Console.WriteLine("Replacing File Exists... Deleting File");
        File.Delete("C:\\Users\\JacobPrice\\Documents\\FunFacts\\Replacement.txt");
       
    }

    if (File.Exists("C:\\Users\\JacobPrice\\Documents\\FunFacts\\ReplacementBCKUP.txt")){
        File.Delete("C:\\Users\\JacobPrice\\Documents\\FunFacts\\ReplacementBCKUP.txt");
    }

    Console.WriteLine("Generating New Replacement File...");
    File.AppendAllLines("C:\\Users\\JacobPrice\\Documents\\FunFacts\\Replacement.txt", cssstrings);

    File.Replace("C:\\Users\\JacobPrice\\Documents\\FunFacts\\Replacement.txt", cssSheet, "C:\\Users\\JacobPrice\\Documents\\FunFacts\\ReplacementBCKUP.txt");

   
    Console.WriteLine("The css page has been succesfully updated, you may now close this program.");
}




