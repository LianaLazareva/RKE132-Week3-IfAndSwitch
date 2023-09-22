

Console.WriteLine("Enter a number:");
int UserNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int result = UserNum % 2;

if(result != 0)  //!= - ei ole võrdne
{
    Console.WriteLine("User number is odd.");
}else
{
    Console.WriteLine("User number is even");
}
