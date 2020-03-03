using System;

public class Class1 {
    public Class1() {
        static int countingValleys(int n, string s) {
            int numOfValleis = 0, level = 0, numOfHills = 0;

            for (int i = 0; i < n; i++) {
                if (s[i] == 'D') {
                    level -= 1;
                    if (level == -1) {
                        numOfValleis += 1;
                    }
                }
                else {
                    level += 1;
                    if (level == 1) {
                        numOfHills += 1;
                    }
                }
            }
            return numOfValleis;
        }
    }
}
