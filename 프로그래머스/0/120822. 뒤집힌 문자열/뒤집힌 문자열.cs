using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        char[] arr = my_string.ToCharArray();
        Array.Reverse(arr);
        answer = new string(arr);
        
        return answer;
    }
}