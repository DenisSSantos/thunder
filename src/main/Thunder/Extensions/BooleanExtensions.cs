namespace Thunder.Extensions
{
    /// <summary>
    /// Boolean extensions
    /// </summary>
    public static class BooleanExtensions
    {
        /// <summary>
        /// Transforme booelan to text plan Sim or N�o 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string Text(this bool source)
        {
            return source ? "Sim" : "N�o";
        }
    }
}