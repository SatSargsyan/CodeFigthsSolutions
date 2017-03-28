###
```C#
int correctEmails(std::string pattern) {
  struct Helper {

    bool isSymbol(char c) {
      return 'a' <= c && c <= 'e';      
    }

    bool isCorrectEmail(std::string email) {
      return std::count(email.begin(), email.end(), '@') == 1 &&
        std::count(email.begin(), email.end(), '.') >= 1 &&
        email.rfind('.') > email.rfind('@') && 
        email.find("..") == std::string::npos && 
        email.find(".@") == std::string::npos &&
        email.find("@.") == std::string::npos &&
        isSymbol(email[0]) && 
        isSymbol(email[email.size() - 1]);
    }

    int countCorrectEmails(std::string pattern, int position) {
      if (position == pattern.size()) {
        return isCorrectEmail(pattern);
      }
      if (pattern[position] != '?') {
        return countCorrectEmails(pattern, position + 1);
      }
      int answer = 0;
      pattern[position] = '@';
      answer += countCorrectEmails(pattern, position + 1);
      pattern[position] = '.';
      answer += countCorrectEmails(pattern, position + 1);
      pattern[position] = 'a';
      answer += countCorrectEmails(pattern, position + 1) * 5;
      pattern[position] = '?';
      return answer;
    }
  };

  Helper h;
  return h.countCorrectEmails(pattern, 0);
}
```



### A ticket number is usually represented by the even number of digits (leading zeros are allowed). It is considered to be lucky if the sum of the first half of the digits is equal to the sum of the second half.  

Given an integer n, find the number of lucky tickets with n-digit number.

Example-Don't true

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
### Sort an array of integers.

Example -Don't true

For sequence = [3, 6, 1, 5, 3, 6], the output should be
mergeSort(sequence) = [1, 3, 3, 5, 6, 6].

```C#
std::vector<int> mergeSort(std::vector<int> sequence) {

  struct Helper {

    std::vector<int> sequence;

    void mergeArrays(int left, int middle, int right) {

      std::vector<int> result;
      int i, j;

      for (i = left, j = middle; i < middle && j < right; ) {
        if (sequence[i] < sequence[j]) {
          result.push_back(sequence[i]);
          i++;
        }
        else {
          result.push_back(sequence[j]);
          j++;
        }
      }

      while (i < middle) {
        result.push_back(sequence[i]);
        i++;
      }

      while (j < right) {
        result.push_back(sequence[j]);
        j++;
      }

      for (i = left; i < right; i++) {
        sequence[i] = result[i - left];
      }
    }

    void split(int left, int right) {

      int middle = (left + right) / 2;

      if (left + 1 == right) {
        return;
      }
      split(left, middle);
      split(middle + 1, right);
      mergeArrays(left, middle, right);
    }
  };

  Helper h;
  h.sequence = sequence;
  h.split(0, sequence.size());

  return h.sequence;
}
```
