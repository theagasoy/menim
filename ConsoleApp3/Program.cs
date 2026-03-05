// See https://aka.ms/new-console-template for more information
//int num1 = 3;
//int num2 = 4;
//if (num1 > num2) 
//{
//    Console.WriteLine("num1");
//} 
//else 
//{
//    Console.WriteLine("num2");
//}


//int num1 = 123;
//if (num1 % 2 == 0)
//{
//    Console.WriteLine("bolunur");
//}
//else
//{
//    Console.WriteLine("bolunmur");
//}



//Console.WriteLine("eded:");
//int eded = int.Parse(Console.ReadLine());
//if (eded >= 100)
//{
//    Console.WriteLine("boyuk");
//}
//else
//{ Console.WriteLine( "kicik"); }



//Console.WriteLine("yas:");
//int yas = int.Parse(Console.ReadLine());
//if (yas >= 18)
//{
//    Console.WriteLine("adult");
//}
//else
//{ Console.WriteLine("child"); }



//Console.WriteLine("eded:");
//int eded = int.Parse(Console.ReadLine());
//if (eded > 0)
//{
//    Console.WriteLine("musbet");
//}
//else
//{ Console.WriteLine("menfi"); }



//Console.WriteLine("eded:");
//int gun = int.Parse(Console.ReadLine());
//switch (gun)
//{
//    case 1:
//        Console.WriteLine("bazar e");
//        break;
//    case 2:
//        Console.WriteLine(" cersenbe ax");
//        break;
//    case 3:
//        Console.WriteLine("cersenbe");
//        break;
//    case 4:
//        Console.WriteLine("cume");
//        break;
//    case 5:
//        Console.WriteLine("cume ax");
//        break;
//    case 6:
//        Console.WriteLine("senbe");
//        break;
//    case 7:
//        Console.WriteLine("bazar");
//        break;
//    default:
//        Console.WriteLine("yoxdur");
//        break;
//}



//Console.WriteLine("eded daxil ed:");
//double eded = double.Parse(Console.ReadLine());
//double kub = Math.Pow(eded, 3);
//Console.WriteLine(kub);

//Console.WriteLine("eded:");
//int gun = int.Parse(Console.ReadLine());
//switch (gun)
//{
//    case 1:
//        Console.WriteLine(" 31");
//        break;
//    case 2:
//        Console.WriteLine(" 28");
//        break;
//    case 3:
//        Console.WriteLine("31");
//        break;
//    case 4:
//        Console.WriteLine("30");
//        break;
//    case 5:
//        Console.WriteLine("31");
//        break;
//    case 6:
//        Console.WriteLine("30");
//        break;
//    case 7:
//        Console.WriteLine("31");
//        break;
//    case 8:
//        Console.WriteLine("31");
//        break;
//    case 9:
//        Console.WriteLine(" 30");
//        break;
//    case 10:
//        Console.WriteLine("31");
//        break;
//    case 11:
//        Console.WriteLine("30");
//        break;
//    case 12:
//        Console.WriteLine("30");
//        break;
//}


//string[] fruits = { "alma", "armud", "nar", "heyva", "gilas", "alca", "banan" };
//Console.WriteLine(fruits);


//string[] students = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10" };
//Console.WriteLine(fruits);

//string[] students = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10" };
//for (int i = 0; i < students.Length; i++) 
//{
//    Console.WriteLine(students[i]);
//}

//string[] students = { "s1", "s2", "s3", "s4", "s5", "s6", "s7", "s8", "s9", "s10" };
//Console.WriteLine(students[4]);





//int[] num = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
//Console.WriteLine("3-ə bolunen ededler:");

//for (int i = 0; i < num.Length; i++)
//{
//    if (num[i] % 3 == 0)
//    {
//        Console.WriteLine(num[i]);
//    }
//}


//string[] travels = { "baki", "gence", "seki", "susa" };
//Console.WriteLine(travels);




//int[] num = { 20, 34, 21, 98, 45, 12, 34, 65, 11, 34, 54, 30 };
//int sum = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    sum += num[i];
//}
//double ort = (double)sum / num.Length;
//Console.WriteLine("ededi orta: " + ort);

//Array.Sort(num);
//int min = num[0];
//int max = num[num.Length - 1];
//Console.WriteLine("Minimal eded: " + min);
//Console.WriteLine("Maksimal eded: " + max);



//Console.Write("eded daxil ed  ");
//int num = Convert.ToInt32(Console.ReadLine());
//int a = num / 100;
//int b = (num / 10) % 10;
//int c = num % 10;
//int sum = a * a * a + b * b * b + c * c * c;
//if (sum==num)
//    Console.WriteLine("duzdur");
//else
//    Console.WriteLine("sehvdir");

//1den 500e geder ededler arasinda tek cut ededleri tap sonrla tek ededlerin cemi ile cut ededlerin cemin cixib alinan ededin musbet yada menfi oldugun tap

//int tek = 0;
//int cut = 0;
//for (int i = 1; i <= 500; i++)
//{
//    if (i % 2 == 0)
//    { cut += i; }
//    else
//    { tek += i; }
//}
//int frq = tek - cut;
//if (frq > 0)
//{ Console.WriteLine("musbetdir"); }
//else if (frq < 0)
//{ Console.WriteLine("menfidir"); }
//else { Console.WriteLine("sifir"); }


//ilk 10 fibanocci ededin yazan kod
//int n = 10;
//int[] fibArr = new int[n];

//fibArr[0] = 0;
//fibArr[1] = 1;

//for (int i = 2; i < n; i++)
//{
//    fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
//}
//// Massivin elementlərini ekrana çap etmək üçün dövr
//for (int i = 0; i < fibArr.Length; i++)
//{
//    Console.WriteLine(fibArr[i]);
//}


//faktoriali tap
//Console.Write("ededi yaz ");
//int n = int.ToInt32(Console.ReadLine());

//long fak = 1; 
//for (int i = 1; i <= n; i++)
//{
//    fak = fak * i; 
//}
//Console.WriteLine($"{n}! = {fak}");

//yazilan sozu tersine cevirme
//Console.Write("soz: ");
//string soz = Console.ReadLine();
//string zos = "";
//for (int i = soz.Length - 1; i >= 0; i--)
//{
//    zos += soz[i]; 
//}
//Console.WriteLine(zos);

//bir eded daxil edin onun prime olub olmadigini yoxlayin
//Console.Write("Ededi daxil edin: ");
//double n = int.Parse(Console.ReadLine());
//double say = 0;
//for (int i = 1; i <= n; i++)
//{
//    if (n % i == 0)
//    {
//        say++;
//    }
//}
//if (say == 2)
//{ Console.WriteLine("prime "); break; }
//else
//{ Console.WriteLine("prime deyil"); }

//int[] num = { 23, 60, 12, 43, 56, 100, 23, 43, 21, 36, 72 };
//Console.Write("6-ya bölünən ededler:");
//for (int i = 0; i < num.Length; i++) 
//{
//    if ( num[i] % 6 == 0)
//    {
//        Console.WriteLine(num[i]);
//    }
//}





//Console.Write("Birinci eded: ");
//double eded1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("sec (+, -, *, /, %, ^): ");
//string emeliyyat = Console.ReadLine();
//double netice = 0;

//if (emeliyyat != "^")
//{Console.Write("Ikinci eded: ");
//    double eded2 = Convert.ToDouble(Console.ReadLine());
//    switch (emeliyyat)
//        {case "+":
//            netice = eded1 + eded2;
//            break;
//        case "-":
//            netice = eded1 - eded2;
//            break;
//        case "*":
//            netice = eded1 * eded2;
//            break;
//        case "/":
//            netice = eded2 != 0 ? eded1 / eded2 : 0;
//            if (eded2 == 0) Console.WriteLine("Sifira bolmek olmaz");
//            break;
//        case "%":
//            netice = eded1 % eded2;
//            break;
//        default:
//            Console.WriteLine("Yanlisdir");
//            return;}
//}
//else
//{netice = eded1 * eded1;}
//Console.WriteLine($"Netice: {netice}")


//double[] prices = { 100.0, 1300.50, 259.99, 430.30, 160.99, 320.0 };
//Console.Write("qiymet: ");
//for (int i = 0; i < prices.Length; i++) 
//{
//    double prc = prices[i] * 0.8;
//    Console.WriteLine($"{prices[i]}");
//}


//iscilerin yasi olan bir array verilib yasi 65e beraber ve boyuk olanlari teqaude ayrilmali oldugunu bildiren mesaj gelsin
int[] age = { 23, 34, 19, 65, 40, 66, 29, 35, 67, 64, 60, 32, 57 };
for (int i = 0; i < age.Length; i++)
{
    if (age[i] >= 65)
    {
        Console.WriteLine($"{age[i]} yaşlı işçi: Təqaüdə ayrılmalıdır.");
    }
}