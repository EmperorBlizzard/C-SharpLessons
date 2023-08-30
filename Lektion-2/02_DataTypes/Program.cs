/*
    C# standard datatyper som används
    -------------------------------------------------------------------------------------------------
    
  * string          till för text               string name = "Emil";
    
  * int             till för heltal             int age = 22;
    long            till för heltal             long age = 22;

  * decimal         till för decimaltal         decimal lengh = 164.5m;
    double          till för decimaltal         double lengh = 164.5;
    float           till för decimaltal         float lengh = 164.5f;
    
  * bool            till för sant/falskt        bool isHuman = true;

    char            till för enskilt tecken     char gender = 'M';              ALT+39 för ' 

    dynamic         kan innehålla vad som       dynamic lastName = "Olsson";
                                                dynamic weight = 72;

  * Guid            globalt unic id             Guid id = Guid.newGuid();
    
    byte                                        
  * null            är ingenting alls
    object
*/

/*
    Deklarea variabler i C#
    ------------------------------------------------------------------------------------------------
    Hur skriver vi variabel namn:

    camelCade               firstName               string firstName = "Emil";
    Pascal                  FirstName               string FirstName = "Emil";
    kebab-case              first-name              string first-name = "Emil";
    snake_case              first_name              string first_name = "Emil";


    C# använder sig primärt av Pascal men även camelCase

    korrekt sätt att deklarera:                     string firstName = "Emil";
    latmanssättet att deklarera:                    var firstName   = "Emil";





*/


/*
    STRING - Textbaserade värden
    ----------------------------------------------------------------------------------------------------------------------------------------------------------------
    
    string firstName = "Emil";
    var lastName = "Olsson";

    
    string sentence_1 = "jag heter Emil och jag är bäst";
    string sentence_2 = "jag heter Emil och jag är \"bäst\"";
    string sentence_3 = "jag heter Emil och jag är 'bäst'";

    string url_1 = "C:\\Skola\\C-Sharp\\Lessons";
    string url_2 = @"C:\Skola\C-Sharp\Lessons";

    string placeholder_1 = "Hej jag heter " + firstName + " " + lastName;
    string placeholder_2 = $"Hej jag heter {firstName} {lastName}";
    string placeholder_3 = string.Format("Hej jag heter {0} {2}", placeholder_1, placeholder_2);


*/




Console.Write("Skriv ditt förnamn: ");

string firstName = Console.ReadLine() ?? "";


Console.Write("Skriv ditt efternamn: ");

string lastName = Console.ReadLine() ?? string.Empty;

Console.WriteLine($"Hej {firstName} {lastName}");
Console.ReadKey();

