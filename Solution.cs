public class Solution {
    public int MyAtoi(string s) {
        s = s.Trim();
        if (string.IsNullOrEmpty(s)) return 0;

        int sign = s[0] == '-' ? -1 : 1;
        int start = s[0] == '-' || s[0] == '+' ? 1 : 0;
        long num = 0;

        for (int i = start; i < s.Length; i++) {
            if (!char.IsDigit(s[i])) break;
            num = num * 10 + (s[i] - '0');
            if (num > int.MaxValue) return sign == 1 ? int.MaxValue : int.MinValue;
        }

        return (int)num * sign;
    }
}