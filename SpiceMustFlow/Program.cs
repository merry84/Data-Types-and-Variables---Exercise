﻿

//Създайте програма, която изчислява общото количество подправка, което може да бъде извлечено от източник.
//Източникът има начален добив, който показва колко подправки могат да бъдат добити през първия ден.
//След като е бил добит за един ден, добивът пада с 10,
//което означава, че на втория ден ще произведе 10 по-малко подправки, отколкото през първия,
//на третия ден 10 по-малко, отколкото през втория и т.н. (вижте примерите) .
//.Един източник се счита за печеливш само ако добивът му е най-малко 100 –
//когато се очакват по-малко от 100 подправки на ден, изоставете източника.
//Миньорският екип консумира 26 подправки всеки ден в края на смяната си и още 26,
//след като мината е изчерпана. Имайте предвид, че работниците не могат да консумират повече подправки,
//отколкото има в склада.
//Когато операцията приключи, отпечатайте на конзолата на два отделни реда колко дни е работила мината
//и общото количество извлечена подправка.
//Вход
//Ще получите число, представляващо началния добив на източника.
//Изход
//Отпечатайте на конзолата, на два отделни реда, колко дни е работила мината и общото количество извлечена подправка.
//  Ограничения
//• Началната доходност ще бъде положително цяло число в диапазона [0…2147483647].

int yieldStart = int.Parse(Console.ReadLine());
int spice = 0;
int dayWork = 0;
if (yieldStart < 100 && dayWork == 0)
{
    Console.WriteLine($"{dayWork}");
    Console.WriteLine($"{spice}");
}
else 
{
    while (yieldStart >= 100)
    {

        dayWork++;
        spice += yieldStart - 26;//26 подправки всеки ден за работниците
        yieldStart -= 10;// добивът пада с 10
    }
    spice -= 26; 
    Console.WriteLine($"{dayWork}");
    Console.WriteLine($"{spice}");
}
