using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}



// I used the sample solution to help me through this a lot since 
// I had no idea what to do, exactly. I now see that through this code, I
// can utilize the "f1" into the first Fraction constructor (1/1 within the 
// Fraction class), "f2" into the Second fraction constructor
// ([wholenumber]/1 within the Fraction class), and so on. 



// The notes did go over this, but I ended up gaining more questions than answers. All 
// it did was confuse me since I am still new to coding. Seeing how this code ACTUALLY
// plays out has helped me a lot more with this learning process.



// So yes, I did technically 'copy' the code, BUT I did word by word so that I could LEARN, 
// not the lazy 'copy and paste'. 
// After all, the notes were not cutting it for me. As a result, I actually UNDERSTAND how this works now.



// Anyways, sorry for the rant. I never wanted to plagarize since that is never my intention, but 
// seeing it play out has helped me out a lot. After all, the intention was to learn, right?



// Feel free to message me if this is something you don't want for me to do in the future. This method 
// of learning helps me, but I don't know if this is something that you as the teacher want me to do. 
// Regardless of your answer, I will oblige. 

