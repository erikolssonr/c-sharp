/*
C# Standard datatyper som används
---------------------------------
string   till för text               string name = "Erik";
int      till för heltal             int age = 25;
long     till för heltal             long age = 25;
decimal  till för decimaltal         decimal length = 164.5m;
double   till för decimaltal         double length = 164.5;
float    till för decimaltal         float length = 164.6f;
bool     till för sant/falskt        bool isHuaman = true;
char     till för enskilt tecken     char gender = 'M';
dynamic  kan innehåll vad som        dynamic lastName = "Olsson";

Guid     globalt unikt id            Guid id = Guid.NewGuid();

byte                                 
null
object


*/

/* 
 Deklarera variabler i C#
 ------------------------
 Hur skriver vi variabel namn:

 camelCase
 Pascal
 kebab-case
 snake_case

korrekt sätt att deklarera:            string firstName = "Erik";
latmanssättet att deklarera:           var firstName = "Erik";

var firstname = "erik";
var lastname = "olsson";

string url = @"c:\user\folder";
// @ bortser \ som en escape, mestadels i adresser. //

string placeholder_1 = "hej jag heter " + firstname + " " + lastname + ".";
string placeholder_2 = $"hej jag heter {firstname} {lastname}.";
string placeholder_3 = string.format("hej jag heter {0} {1}.", firstname, lastname);

*/


Console.WriteLine("Skriv ditt förnamn: ");
string firstName = Console.ReadLine() ?? "";

Console.WriteLine("Skriv ditt efternamn: ");
string lastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Hej {firstName} {lastName}.");

Console.ReadKey();



