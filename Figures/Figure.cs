using System;


namespace Figures
{
    /// <summary>
    /// Class with functions to calculate area of figure and more.
    /// </summary>
    public static class Figure 
    {
        /// <summary>
        /// Function returns square of circle.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static float CalculateArea(float radius) => 2 * MathF.PI * radius;

        /// <summary>
        /// Function returns square of triangle.
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static float CalculateArea(float a, float b, float c) 
        {
            float p = (a + b + c) / 2;

            return MathF.Sqrt(p *(p - a) * (p - b) * (p -c));
        }
        /// <summary>
        /// Function checks if triangle contains right angle.
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static bool TriangleRightAngle(float a, float b, float c)
        {
            float aPow = MathF.Pow(a, 2); float bPow = MathF.Pow(b, 2); float cPow = MathF.Pow(c, 2);

            float angleA_cos = (aPow + cPow - bPow)/ (2 * a * c);

            float angleB_cos = (aPow + bPow - cPow) / (2 * a * b);

            float angleC_cos = (bPow + cPow - aPow) / (2 * c * b);

            if (angleA_cos == 0 || angleB_cos == 0 || angleC_cos == 0)
                return true;

            return false;

        }
    }
}