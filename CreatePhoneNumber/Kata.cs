namespace CreatePhoneNumber
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] num)
        {
            return num.Length != 10 ? String.Empty:
            $"({string.Join("", num.Take(3))}) {string.Join("", num.Skip(3).Take(3))}-{string.Join("", num.TakeLast(4))}";
        }
    }
}
