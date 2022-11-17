bool loopClose = false;
DataModel model = new();
ValgEnum valgEnum = new();
do
{
    Console.Clear();
    Console.WriteLine("Vælg lærer, elev eller fag");
    Console.WriteLine("\ta) Lærer");
    Console.WriteLine("\tb) Elev");
    Console.WriteLine("\tc) Fag");
    string? valg = Console.ReadLine().ToLower();
    string? søgeValg;
    if (valg == "a")
    {
        //Søg på lærer
        Console.WriteLine("Indtast lærerens fulde navn");
        søgeValg = Console.ReadLine();

        if (søgeValg == "Niels Olesen")
        {
            Console.WriteLine(model.FagList[1]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.StudieTeknikElevList));

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(model.FagList[2]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.ElevList));

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(model.FagList[3]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.ElevList));

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine(model.FagList[4]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.ElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "Peter Suni Lindenskov")
        {
            Console.WriteLine(model.FagList[0]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.ElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "Henrik Vincents Poulsen")
        {
            Console.WriteLine(model.FagList[6]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.ElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "Jan Stern Johansen")
        {
            Console.WriteLine(model.FagList[5]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.ElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Dit søgeord findes ikke");
        }
    }
    else if (valg == "b")
    {
        //Søg på elev
        Console.WriteLine("Indtast elevens fulde navn");
        søgeValg = Console.ReadLine();

        if (søgeValg == model.ElevList[0])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[1])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[2])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(model.FagList[0]);
            Console.WriteLine(model.FagList[2]);
            Console.WriteLine(model.FagList[3]);
            Console.WriteLine(model.FagList[4]);
            Console.WriteLine(model.FagList[5]);
            Console.WriteLine(model.FagList[6]);

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[3])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[4])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[5])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[6])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[7])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[8])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[9])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[10])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[11])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[12])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[13])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[14])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == model.ElevList[15])
        {
            Console.WriteLine(String.Join(", ", model.LærerList));
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.FagList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Dit søgeord findes ikke");
        }
    }
    else if (valg == "c")
    {
        //Søg på fag
        Console.WriteLine("Indtast fagets navn");
        søgeValg = Console.ReadLine();
        if (søgeValg == "Clientside Programmering")
        {
            Console.WriteLine(model.LærerList[3]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.ElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "Studieteknik")
        {
            Console.WriteLine(model.LærerList[2]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.StudieTeknikElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "Grundlæggende Programmering")
        {
            Console.WriteLine(model.LærerList[2]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.StudieTeknikElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "OOP")
        {
            Console.WriteLine(model.LærerList[2]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.StudieTeknikElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "Databaseprogrammering")
        {
            Console.WriteLine(model.LærerList[2]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.StudieTeknikElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "Computerteknologi")
        {
            Console.WriteLine(model.LærerList[0]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.StudieTeknikElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else if (søgeValg == "Netværk")
        {
            Console.WriteLine(model.LærerList[1]);
            Console.WriteLine("Elever for dette fag:");
            Console.WriteLine("");
            Console.WriteLine(String.Join(", ", model.StudieTeknikElevList));

            Console.WriteLine("");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Dit søgeord findes ikke");
        }
    }
    else
    {
        Console.WriteLine("Det du har indtastet er ikke gyldigt");
        Thread.Sleep(4000);
    }
    Thread.Sleep(4000);
    } while (!loopClose);