namespace CreatePhoneNumber
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] num)
        {
            if (num.Length != 10) return "";
            return $"({string.Join("", num.Take(3))}) {string.Join("", num.Skip(3).Take(3))}-{string.Join("", num.Skip(6))}";
        }
    }
}
