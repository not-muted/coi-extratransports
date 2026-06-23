using Mafi.Core.Entities.Static;
using Mafi.Core.Research;

namespace ExtraTransports
{
    public static class TransportsId
    {

        public static class Transports
        {

            // Loose Material Transports

            public static readonly StaticEntityProto.ID LooseMaterialConveyorT4 = new StaticEntityProto.ID("LooseMaterialConveyorT4");

            public static readonly StaticEntityProto.ID LooseMaterialConveyorT5 = new StaticEntityProto.ID("LooseMaterialConveyorT5");

            // Unit Item Transports

            public static readonly StaticEntityProto.ID FlatConveyorT4 = new StaticEntityProto.ID("FlatConveyorT4");

            public static readonly StaticEntityProto.ID FlatConveyorT5 = new StaticEntityProto.ID("FlatConveyorT5");

            // Fluid Transpots

            public static readonly StaticEntityProto.ID FluidPipeT5 = new StaticEntityProto.ID("FluidPipeT5");
        }

        public static class Research
        {

            // Tier 4 Conveyor Research

            public static readonly ResearchNodeProto.ID ConveyorBeltsT4 =
                new ResearchNodeProto.ID("ConveyorBeltsT4");

            // Tier 5 Conveyor Research

            public static readonly ResearchNodeProto.ID ConveyorBeltsT5 =
                new ResearchNodeProto.ID("ConveyorBeltsT5");

            // Tier 5 Pipe Research

            public static readonly ResearchNodeProto.ID PipeT5 =
                new ResearchNodeProto.ID("PipeT5");
        }
    }
}
