using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_99_OOP_04
{
    internal static class DeliveryHelper
    {
        public static void PrintShipmentDetails(Shipment shipment)
        {
            if (shipment != null)
            {
                shipment.PrintShipment();
            }
        }

    }
}
