// if (6 > 3)
// {
//     Console.WriteLine("Hello World");

// }
// Console.ReadLine();

// ---------------------------------------------------

// Console.WriteLine("Hej, skriv ditt användranamn:");

// string namn = Console.ReadLine();

// if (namn == "noname")
// {
//     Console.WriteLine("Wellcome!");
// }

// else
// {
//     Console.WriteLine("Det är fel!");
// }
// Console.ReadLine();
// ----------------------------------------------------
// string namn = "noname";
// string lösenord = "nopass";
// Console.WriteLine("Hej, skriv ditt användranamn:");
// string svar1 = Console.ReadLine();
// Console.WriteLine("Trevligt, skriv ditt lösenord:");
// string svar2 = Console.ReadLine();
// if (namn == svar1 && lösenord == svar2)
// {
//     Console.WriteLine("Welcome!");
// }
// else
// {
//     Console.WriteLine("Wrong username or password");
// }

// Console.ReadLine();
// -----------------------------------------------------
// int i = 0;
//         while (i < 32)
//         {
//             Console.WriteLine("Hello, World");
//             i++;
//         }
//         Console.ReadLine();
// -----------------------------------------------------
// string code = "";


// while (code != "nocode")
// {
//   Console.WriteLine("What is the code?");
//   code = Console.ReadLine();
// }
// -----------------------------------------------------

// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine("Skriv en siffra:");
//     string number = Console.ReadLine();
//     int n;
//     bool success = int.TryParse(number, out n);

//     if (n > 5)
//     {
//         Console.WriteLine("högre än 5!");
//     }

// }
// -----------------------------------------------------
// while (true)
// {
//  Console.WriteLine("Skriv en siffra:");
//   string number = Console.ReadLine();
//  int nummer;

// if(int.TryParse(number, out nummer))
// {
// Console.WriteLine("du skrev ett nummer");
// Console.ReadLine();
// break;
// }
// }
// -----------------------------------------------------
// int siffran = 8;
// int gissningen = 0;

// Console.WriteLine("Gissa ett tal mellan o och 12");

//  while (gissningen != siffran)
//         {
//             Console.Write("Din gissning: ");
//             string gissa = Console.ReadLine();
//     if (int.TryParse(gissa, out gissningen))
//     {
//         if (gissningen < siffran)
//         {
//             Console.WriteLine("För låg gissning");
//         }
        
//         else if (gissningen > siffran)
//         {
//             Console.WriteLine("För hör gissning");
//         }

//         else if (gissningen == siffran)
//         {
//             Console.WriteLine("Grattis, svaret är rätt!");
//         }
//     }
//     else 
//     {
//     Console.WriteLine("Du skrev något konstigt, skriv en siffra!");
//     }
// }
// Console.ReadLine();
