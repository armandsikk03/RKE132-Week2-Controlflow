// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Armand!");

//rakendus küsib kasutajalt tema sugu
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust rakendus tervitab kasutajat järgmiselt:
//"welcome, mr. [kasutaja perekonnanimi] / "Welcome ms. [Kasutaja perekonnanimi]

Console.WriteLine(  "Please select your gender (m/f)");
char usergender = Char.Parse(Console.ReadLine());//loeb konsoolist andmeid string (sõne) formaadis

Console.WriteLine("Please, enter your last name: ");
string userLastName = Console.ReadLine();

if (usergender == 'm')
{
    Console.WriteLine($"Welcome, Mr.{userLastName}!");
}
else if (usergender == 'f')
{
    Console.WriteLine($"Welcome Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName} !");
}

