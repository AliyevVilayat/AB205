
#region Notes

//[Access Modifier] [Keyword(static or non-static)] [Return Type] [Method Name] ([Method parameters])

//Method declare edilən zaman qəbul edəcəyi dəyərlər parametr, biz method-u call edəcəyimiz zaman göndərəcəyimiz dəyərlər isə argument adlanır.


//Console.WriteLine("Bu bir text metnidir") = Console.Write("Bu bir text metnidir \n")

#endregion

public class Program
{
    public static void Main(string[] args)
    {
        #region Parse Convert TryParse

        //int.Parse()
        Console.Write("Zehmet olmasa yasinizi daxil edin:");
        string input = Console.ReadLine();
        int age = int.Parse(input);

        //Convert.ToInt32
        Console.Write("Zehmet olmasa nece illik tecrubenizin oldugunu daxil edin:");
        input = Console.ReadLine();
        int experienceYear = Convert.ToInt32(input);

        //Int32.TryParse() => gələcək dərslərdə görəcəyik.

        #endregion

    }

    #region Home Task

    //Şərt: Elə bir method yazın ki bu method göndərilən string text daxilində vermiş olduğumuz string ifadəni axtarıb tapsın və ekrana bu barədə məlumat versin. Məlumat dedikdə isə bu ifadənin burada yer alıb-almaması məlumatı nəzərdə tutulur.


    #endregion

    public static void PrintSum(int num, int num2)
    {
        //Method mənə göndərdiyim dəyərləri toplayıb ekrana çıxarsın.

        int sum = num + num2;
        Console.WriteLine(sum);
    }

    public static int Sum(int num, int num2)
    {
        //Method mənə göndərdiyim dəyərləri toplayıb geri qaytarsın.
        int sum = num + num2;
        return sum;
    }

    public static int SearchNumInArray(int[] arr, int num)
    {
        //Elə bir method yazın ki int tipindən array və int tipindən bir dəyişən qəbul etsin. Method göndərilən dəyəri array daxilində axtarsın əgər rast gələrsə index-i, rast gəlinmədiyi təqdirdə geriyə -1 qaytarsın.

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                return i;
            }
        }

        return -1;
    }

    public static int CustomIndexOf(string text, char symb)
    {
        //Elə bir method yazın ki string tipindən text və char tipindən bir dəyişən qəbul etsin. Method göndərilən dəyəri string daxilində axtarsın əgər rast gələrsə index-i, rast gəlinmədiyi təqdirdə geriyə -1 qaytarsın.

        //CustomCharAt

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == symb)
            {
                return i;
            }
        }
        return -1;
    }


}