using System;

public class Class1 {
    public Class1() {
        static int pairCount(int n, int[] ar) {
            int pairs = 0;

            for (int i = 0; i < n; i++) {
                if (ar[i] != 0) {
                    for (int j = i + 1; j < n; j++) {
                        if (ar[j] == ar[i]) {
                            pairs++;
                            ar[j] = 0;
                            break;
                        }
                    }
                }
            }

            return pairs;
        }
    }
}
