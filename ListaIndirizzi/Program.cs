// See https://aka.ms/new-console-template for more information

using ListaIndirizzi;

StreamReader file = File.OpenText("C:\\Users\\generation\\Desktop\\Esercizi GIT\\C#_DotNET\\ListaIndirizzi\\ListaIndirizzi\\File\\addresses.csv");
List<Indirizzo> Indirizzi= new List<Indirizzo>();

int rigaLetta = 0;
while (!file.EndOfStream)
{
    rigaLetta++;
    string line = file.ReadLine();

    if (rigaLetta == 1)
    {
        continue;
    }
    
    string[]dati = line.Split(',');
    for(int i=0; i < dati.Length; i++)
    {
        if (dati[i] == "" || dati[i] == null)
        {
            dati[i] = "Undefined";
        }
    }

    if(dati.Length == 6)
    {
        Indirizzo indirizzo = new Indirizzo(dati[0], dati[1], dati[2], dati[3], dati[4], dati[5]);
        
        Indirizzi.Add(indirizzo);
    }
    else if(dati.Length == 7)
    {
        Indirizzo indirizzo = new Indirizzo(dati[0] + " " + dati[1], dati[2], dati[3], dati[4], dati[5], dati[6]);
        
        Indirizzi.Add(indirizzo);
    }

    
    
    //Console.WriteLine(line);

}
file.Close();

foreach(Indirizzo indirizzo in Indirizzi)
{
    Console.WriteLine(indirizzo);
}