using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_99_OOP_04
{
    internal class DeliveryReport
    {
        public static void PrintShipment(ITrackable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine(shipment.GetTrackingStatus());
            }
        }
        public static void PrintInsurance(IInsurable shipment)
        {
            if (shipment != null)
            {
                Console.WriteLine($"Insurance Cost: {shipment.CalculateInsurance():C}");
            }
        }
    }
}
