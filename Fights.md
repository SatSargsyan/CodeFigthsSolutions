### A ticket number is usually represented by the even number of digits (leading zeros are allowed). It is considered to be lucky if the sum of the first half of the digits is equal to the sum of the second half.

Given an integer n, find the number of lucky tickets with n-digit number.

Example

For n = 2, the output should be
countLuckyNumbers(n) = 10.
They are: "00", "11", "22", "33", "44", "55", "66", "77", "88", "99".

```C#
int countLuckyNumbers(int n) {

  /*
   * vector<vector<int>> dp (short for dynamic programming)
   * is used for storing the interim values.
   */
  std::vector<std::vector<int>> dp;
  int result = 0;

  for (int i = 0; i <= n / 2; i++) {
    dp.push_back(std::vector<int>(i * 9 + 1, 0));
  }
  dp[0][0] = 1;

  for (int i = 0; i < n / 2; i++) {
    for (int sum = 0; sum <= i * 9; sum++) {
      for (int nextDigit = 0; nextDigit < 10; nextDigit++) {
        dp[i + 1][sum + nextDigit] += dp[i][sum];
      }
    }
  }

  for (int sum = 0; sum <= (n / 2) * 9; sum++) {
    result +=dp[sum][sum];
  }
  return result;
}
```
