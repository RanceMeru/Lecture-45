class Program
{
    static void Main(string[] args)
    {
        int[] MyArray ={1,2,3,4,5,6,7,8};
        ParamsArray(MyArray);
        ParamsArray(5,6,7,8,9);
    }


    static void ParamsArray(params int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {

            Console.WriteLine(Array[i]);

        }

    }

}