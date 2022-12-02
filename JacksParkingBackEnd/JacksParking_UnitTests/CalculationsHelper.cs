﻿namespace JacksParking_UnitTests
{
    public class CalculationsHelper
    {
        public static double[] colorArr = {148, 69, 226, 177, 74, 243, 42, 16, 43, 246, 209, 222, 3, 163, 185, 122,
        237, 249, 207, 35, 8, 99, 101, 51, 238, 17, 25, 73, 242, 49, 34, 130, 212, 133, 19, 68, 73, 230,
        232, 136, 80, 36, 197, 133, 145, 27, 18, 47, 253, 113, 255, 201, 80, 23, 41, 222, 191, 4, 252, 129,
        194, 102, 116, 139, 236, 42, 24, 213, 154, 63, 35, 138, 199, 35, 152, 65, 14, 81, 2, 230, 98, 187,
        14, 33, 24, 160, 244, 97, 188, 99, 155, 100, 236, 143, 6, 22, 228, 231, 205, 52, 248, 70, 12, 92,
        215, 97, 254, 82, 45, 219, 52, 168, 164, 163, 234, 167, 156, 120, 36, 64, 246, 49, 43, 161, 99, 59,
        154, 3, 121, 109, 177, 230, 169, 174, 242, 231, 45, 203, 0, 8, 2, 249, 132, 219, 49, 184, 169, 68,
        220, 80, 238, 118, 122, 224, 219, 89, 134, 211, 15, 251, 58, 213, 143, 128, 2, 11, 108, 27, 242, 167,
        118, 86, 254, 244, 50, 117, 31, 79, 110, 141, 154, 92, 109, 69, 152, 138, 120, 220, 127, 205, 240,
        163, 107, 219, 51, 181, 32, 84, 79, 32};

        public static double colorArrAverage = colorArr.Average(); //126.83
        public static double expectedStandardDeviation = 78.8171371;
        public static double expectedLowerBound = 112.4373761;
        public static double expectedUpperBound = 141.2226239;
    }
}