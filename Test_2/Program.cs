void WriteTwo()
{
    Console.WriteLine(2);
}
void WriteHello(string name)
{
    Console.WriteLine("Hello, " + name);
}
string HelloTwoWord(string name)
{
    return "Hello, " + name;
}
WriteTwo();
string word = HelloTwoWord("Sergey ");
Console.WriteLine(word + "Как дела?");
