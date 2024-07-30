namespace TDDProjectMvc.SumData
{
    public class Sum
    {
        public int Exute(string numbers)
        {
            if(numbers == "")
            {
                return 0;
            }
            if(numbers == "0")
            {
                return 0;
            }
            if(numbers.EndsWith(","))
            {
                numbers = numbers.Substring(0, numbers.Length - 1);
            }
            {

            }
            string[] numberArray = numbers.Split(',');
            int[] numberInt = Array.ConvertAll(numberArray, c=> int.Parse(c));

            var result = numberInt.Sum();
            return result;
        }
    }
}
