namespace CreatePhoneNumber
{
    public class Kata
    {
        public static string CreatePhoneNumber(int[] num)
        {
            if (num.Length != 10) return "";
            var firstPart = "(" + string.Join("", num.Take(3)) + ")" + " ";
            var secondPart = string.Join("", num.Skip(3).Take(3));
            var thirdPart = string.Join("", num.Skip(6));
            var lastPart = string.Join("-", secondPart, thirdPart);
            return firstPart + lastPart;
        }
    }
}
