using System;
using System.Collections.Generic;
using System.Text;

namespace G_ASP_NET_99_OOP_04
{
    internal abstract class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;
        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }
        public decimal Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }
        public DeliveryAddress Destination { get; set; }
        public abstract decimal EstimatedCost
        {
            get;
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN";
            this.description = !string.IsNullOrWhiteSpace(description) ? description : "No Description";
            this.weight = weight > 0 ? weight : 1.0m;
            this.deliveryFee = deliveryFee > 0 ? deliveryFee : 10.0m;
            this.Destination = destination;
        }

        public Shipment(string trackingCode)
            : this(trackingCode, "No Description", 1.0m, 10.0m, new DeliveryAddress("Cairo", "Egypt", 2))
        {
        }
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                deliveryFee = newFee;
            }
        }
        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                weight = newWeight;
            }
        }
        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
            {
                weight = newWeight + extraPackingWeight;
            }
        }
        public abstract void PrintShipment();
      
    }
}
