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
            #region Part 02 — Practical
            DeliveryAddress address = new DeliveryAddress("Cairo", "Egypt", 2);
            //a)Create one StandardShipment
            StandardShipment standard = new StandardShipment("SH001", "Laptop", 10m, 45m, address);
            //b)Create one ExpressShipment
            ExpressShipment express = new ExpressShipment("SH002", "Documents", 4m, 50m, address, 30m);
            //c)Create one InternationalShipment
            InternationalShipment international = new InternationalShipment("SH003", "Medical Equipment", 10m, 160m, address, "Germany", 50m);
            //d)add all shipments to the Delivery Center
            DeliveryCenter center = new DeliveryCenter("Main Delivery Center");
            center.AddShipment(standard);
            center.AddShipment(express);
            center.AddShipment(international);
            //e)Print all shipment details
            Console.WriteLine("==========================================");
            Console.WriteLine("Delivery Center");
            Console.WriteLine("==========================================");
            //Standard
            Console.WriteLine("\nStandard Shipment\n");
            standard.PrintShipment();
            Console.WriteLine("\n------------------------------------------");
            //Express
            Console.WriteLine("\nExpress Shipment\n");
            express.PrintShipment();
            Console.WriteLine("\n------------------------------------------");
            //International
            Console.WriteLine("\nInternational Shipment\n");
            international.PrintShipment();
            //f & h ITrackable[] array
            Console.WriteLine("\n==========================================");
            Console.WriteLine("Tracking Status\n");
            ITrackable[] trackables = new ITrackable[] { standard, express, international };
            foreach (ITrackable t in trackables)
            {
                Console.WriteLine(t.GetTrackingStatus());
                Console.WriteLine();
            }
            //g & i IInsurable[] array
            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance\n");
            IInsurable[] insurables = new IInsurable[] { standard, express, international };
            Console.WriteLine($"Standard Shipment Insurance : {insurables[0].CalculateInsurance():0.00} EGP\n");
            Console.WriteLine($"Express Shipment Insurance : {insurables[1].CalculateInsurance():0.00} EGP\n");
            Console.WriteLine($"International Shipment Insurance : {insurables[2].CalculateInsurance():0.00} EGP\n");
            Console.WriteLine("==========================================");
            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");
            #endregion
        }
    }
}
