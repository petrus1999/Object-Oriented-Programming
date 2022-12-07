using Object oriented programming;
using System.ComponentModel.DataAnnotations;

class program
{
    PersonalDetails person1 = new PersonalDetails("PETRUS", "SHAI", "SEPTEMBER", 13, 1999);
    PersonalDetails person2 = new PersonalDetails("MACHABA", "SHAI", "JANUARY", 10, 1994);
    PersonalDetails person3 = new PersonalDetails("DINEO", "SHAI", "AUGUST", 16, 2006);



    static void Main(string[] args)
    {

        Console.WriteLine(person1.Name + " " + person1.Surname +person1.Dayofbirth + " " + person1.Monthofbirth + person1.yearofbirth);
        Console.WriteLine(person2.Name + " " + person2.Surname + person2.Dayofbirth + " " + person2.Monthofbirth + person2.yearofbirth);
        Console.WriteLine(person3.Name + " " + .person3.Surname + person3.Dayofbirth + " " + person3.Monthofbirth + person3.yearofbirth);
    }


