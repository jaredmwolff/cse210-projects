using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference r1 = new Reference("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        Reference r2 = new Reference("2 Nephi 31:3", "For my soul delighteth in plainness; for after this manner doth the Lord God work among the children of men. For the Lord God giveth light unto the understanding; for he speaketh unto men according to their language, unto their understanding.");
        Reference r3 = new Reference("Ether 12:4", "Wherefore, whoso believeth in God might with surety hope for a better world, yea, even a place at the right hand of God, which hope cometh of faith, maketh an anchor to the souls of men, which would make them sure and steadfast, always abounding in good works, being led to glorify God.");
        Reference r4 = new Reference("2 Nephi 32:3", "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.");       


        List<Reference> verses = new List<Reference> { r1, r2, r3, r4 };
        Scripture scripture = new Scripture(verses);


        Word word = new Word(scripture);
        word.Play();
    }
}