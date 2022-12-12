// See https://aka.ms/new-console-template for more information

StreamReader file = File.OpenText("C:\\Users\\generation\\Desktop\\Esercizi GIT\\C#_DotNET\\ListaIndirizzi\\ListaIndirizzi\\File\\addresses.csv");

while (!file.EndOfStream)
{
    string line = file.ReadLine();
    Console.WriteLine(line);

}
file.Close();
