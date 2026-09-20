namespace G_ASP_NET_99_OOP_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            #region Question1
            //a)Abstraction hides complex implementation details and exposes only the essential features of an object.It focuses on what an object does rather than how it works.
            //b)1-Reduces Complexity: Keeps code simple by hiding unnecessary internal logic.
            //2-Improves Maintainability: Allows underlying code changes without breaking external interfaces.
            //3-Enhances Security: Restricts direct access to sensitive internal mechanisms.
            #endregion
            #region Question2
            /*a)An abstract class can contain both abstract methods and full method implementations, along with fields and state. An interface defines a strict contract, containing only method declarations (or default implementations) without storing state.*/
            /*b)Choose an interface when you need to define a common behavior for unrelated classes across different class hierarchies, or when a class needs to support multiple behaviors through multiple inheritance.*/
            /*c)Abstract Classes: No, a class can only inherit from a single abstract class (single inheritance).
                Interfaces: Yes, a class can implement multiple interfaces simultaneously.*/
            #endregion
            #endregion
        }
    }
}
