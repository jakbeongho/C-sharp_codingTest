using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        Array.Sort(array);
        
        int center = array.Length/2;
        
        answer = array[center];
        
        return answer;
    }
}