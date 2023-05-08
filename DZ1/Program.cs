namespace DZ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chislo = 0;

            while (true) // ввод числа
           {
                Console.WriteLine("Введите число от 1 до 6");
                string text = Console.ReadLine();
                if (int.TryParse(text, out chislo)) 
                {
                    chislo = int.Parse(text);
                    if ((chislo > 0) & (chislo<7)) break;
                }
           }

            string stroka;
            int longString =0;

            while (true) // ввод строки
            {
                Console.WriteLine("Введите строку до 44 символов");
                stroka = Console.ReadLine();
                if (stroka != null) longString = stroka.Length;

                if ((longString > 0) & (longString < 45)) break;
            }

            int allLongString = chislo * 2 - 2 + longString;

            string borderPlus = ""; // создание строки из +
            for (int i = 0; i < allLongString + 2; i++)
            {
                borderPlus = borderPlus + "+";
            }

            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 1:
                        cell1(stroka, allLongString, chislo);
                        break;
                    case 3:
                        cell2(allLongString, chislo);
                        break;
                    case 5:
                        cell3(allLongString, chislo);
                        break;
                    default:
                        Console.WriteLine(borderPlus);
                        break;

                }

            }

        }

        private static void cell1 (string stroka, int allLongString, int chislo)
        {
            string borderNull = ""; // создание пустой строки
            for (int i = 0; i < allLongString; i++)
            {
                borderNull = borderNull + " ";
            }
            borderNull = "+" + borderNull + "+";

            string borderText = stroka; // создание строки с текстом
            for (int i = 0; i < chislo - 1; i++)
            {
                borderText = " " + borderText + " ";
            }
            borderText = "+" + borderText + "+";

            string[] cell1 = new string[chislo * 2 - 1]; // создание всей "ячейки" через массив
            for (int i = 0; i < chislo * 2 - 1; i++)
            {
                if (i == chislo - 1) cell1[i] = borderText;
                else cell1[i] = borderNull;
                Console.WriteLine(cell1[i]);
            }
        }

        private static void cell2 (int allLongString, int chislo)
        {
            string stroka1 = "", stroka2 = "";
            int marker = 0;

            for (int i = 0; i<allLongString; i++) // создание строк второй ячейки
            {
                if (marker == 0)
                {
                    stroka1 = stroka1 + "+";
                    stroka2 = stroka2 + " ";
                    marker = 1;
                }
                else
                {
                    stroka1 = stroka1 + " ";
                    stroka2 = stroka2 + "+";
                    marker = 0;
                }
            }   
            stroka1 = "+" + stroka1 + "+";
            stroka2 = "+" + stroka2 + "+";

            string[] cell2 = new string[chislo * 2 - 1];
            for (int i = 0; i < chislo * 2 - 1; i++) // вывод строк во второй ячейке
            {
                 if (i % 2 == 0) cell2[i] = stroka1;
                 else cell2[i] = stroka2;
                 Console.WriteLine(cell2[i]);
            }
        }

        private static void cell3(int allLongString, int chislo)
        {
            string[] cell3 = new string[allLongString];

            for (int i = 0; i < allLongString / 2; i++) // создание строки с двумя +
            {
                string stringForFill = "";

                for (int j = 0; j < allLongString - 2; j++) // создание пустой строки меньше на 2 символа
                {
                    stringForFill += " ";
                }
                stringForFill = "+" + stringForFill + "+";

                if (allLongString % 2 != 0) cell3[allLongString / 2] = stringForFill.Insert(allLongString / 2, " +");

                stringForFill = stringForFill.Insert(1 + i, "+");
                stringForFill = stringForFill.Insert(allLongString - i, "+");

                cell3[i] = stringForFill;
                cell3[allLongString - i - 1] = stringForFill;
            }

            for (int i = 0; i < allLongString; i++)
            {
                Console.WriteLine(cell3[i]);
            }
        }


    }
}