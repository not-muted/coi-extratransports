using Mafi.Base;
using Mafi.Core.Prototypes;

namespace ExtraTransports
{
    internal class TransportsCost
    {
        // Loose Material Transports

        public static EntityCostsTpl LooseMaterialConveyorT4
        {
            get
            {
                return EntityCostsTpl.Build.CP4(56).Product(90, Ids.Products.Rubber).MaintenanceT1(ExtraTransports.TransportsCost.ConveyorMaintenancePer100T4, ExtraTransports.TransportsCost.EXTRA_BUFFER_MONTHS)
                    .Priority(4);
            }
        }

        public static EntityCostsTpl LooseMaterialConveyorT5
        {
            get
            {
                return EntityCostsTpl.Build.CP4(84).Product(102, Ids.Products.Rubber).MaintenanceT1(ExtraTransports.TransportsCost.ConveyorMaintenancePer100T5, ExtraTransports.TransportsCost.EXTRA_BUFFER_MONTHS)
                    .Priority(4);
            }
        }

        // Unit Item Transports

        public static EntityCostsTpl FlatConveyorT4
        {
            get
            {
                return EntityCostsTpl.Build.CP4(56).Product(90, Ids.Products.Rubber).MaintenanceT1(ExtraTransports.TransportsCost.ConveyorMaintenancePer100T4, ExtraTransports.TransportsCost.EXTRA_BUFFER_MONTHS)
                    .Priority(4);
            }
        }

        public static EntityCostsTpl FlatConveyorT5
        {
            get
            {
                return EntityCostsTpl.Build.CP4(84).Product(102, Ids.Products.Rubber).MaintenanceT1(ExtraTransports.TransportsCost.ConveyorMaintenancePer100T5, ExtraTransports.TransportsCost.EXTRA_BUFFER_MONTHS)
                    .Priority(4);
            }
        }

        // Fluid Pipe Transports

        public static EntityCostsTpl PipeT5
        {
            get
            {
                return EntityCostsTpl.Build.CP4(42).Product(70, Ids.Products.Steel).MaintenanceT1(ExtraTransports.TransportsCost.PipeMaintenancePer100T5, ExtraTransports.TransportsCost.EXTRA_BUFFER_MONTHS)
                    .Priority(4);
            }
        }

        // Maintenance Costs

        public static readonly double ConveyorMaintenancePer100T4 = 2.0;

        public static readonly double ConveyorMaintenancePer100T5 = 3.0;

        public static readonly double PipeMaintenancePer100T5 = 3.0;

        // Extra Buffer Months

        public static readonly int EXTRA_BUFFER_MONTHS = 32;
    }
}
