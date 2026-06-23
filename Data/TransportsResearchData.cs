using Mafi;
using Mafi.Base.Prototypes.Research;
using ModIds = ExtraTransports.TransportsId;
using BaseIds = Mafi.Base.Ids;
using Mafi.Core.Mods;
using Mafi.Core.Research;
using MafiBuilder = Mafi.Core.Research.ResearchNodeProtoBuilderExtensions;

namespace ExtraTransports.Data
{
    internal class TransportsResearchData : IModData
    {
        public void RegisterData(ProtoRegistrator registrator)
        {
            TransportsResearchData.registerNewTransports(registrator);
        }

        private static void registerNewTransports(ProtoRegistrator registrator)
        {

            // Tier 4 Converyor Registration

            var t4c = registrator.ResearchNodeProtoBuilder
                .Start("Conveyor Belts IV", ModIds.Research.ConveyorBeltsT4, ResearchCosts.ConveyorBeltsT3 * 2, "title of a research node in the research tree")
                .Description("Conveyor belts with an increase throughput.", "description of a research node in the research tree")
                .SetGridPosition(new Vector2i(148, 14))
                .AddParents(new ResearchNodeProto[] { registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(BaseIds.Research.ResearchLab4) });
            MafiBuilder.AddTransportToUnlock(t4c, ModIds.Transports.LooseMaterialConveyorT4);
            MafiBuilder.AddTransportToUnlock(t4c, ModIds.Transports.FlatConveyorT4);
            ResearchNodeProto t4node = t4c.BuildAndAdd();

            // Tier 5 Conveyor and Pipe Registration

            var t5cp = registrator.ResearchNodeProtoBuilder
                .Start("Conveyor and Pipes V", ModIds.Research.ConveyorBeltsT5, ResearchCosts.ConveyorBeltsT3 * 3, "title of a research node in the research tree")
                .Description("Increase throughput of conveyor belts and pipes.", "description of a research node in the research tree")
                .SetGridPosition(new Vector2i(168, 14))
                .AddParents(new ResearchNodeProto[] { t4node });
            MafiBuilder.AddTransportToUnlock(t5cp, ModIds.Transports.LooseMaterialConveyorT5);
            MafiBuilder.AddTransportToUnlock(t5cp, ModIds.Transports.FlatConveyorT5);
            MafiBuilder.AddTransportToUnlock(t5cp, ModIds.Transports.FluidPipeT5);
            t5cp.BuildAndAdd();

        }
    }
}