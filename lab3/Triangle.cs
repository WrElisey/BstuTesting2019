namespace Lab3
{
    public static class Triangle
    {
        public static bool IsExists(float a, float b, float c)
        {
            return (a + b > c) && (b + c > a) && (a + c > b);
        }
    }
}
