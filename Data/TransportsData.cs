using Mafi;
using Mafi.Base;
using Mafi.Collections.ImmutableCollections;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Factory.Transports;
using Mafi.Core.Mods;
using Mafi.Core.Ports.Io;
using Mafi.Core.Prototypes;
using Mafi.Localization;

namespace ExtraTransports.Data
{
    internal class TransportsData : IModData
    {
        public void RegisterData(ProtoRegistrator registrator)
        {
            Log.Info("TransportData: Registering extra transports data");

            this.RegisterFlatConveyorT4(registrator);
            this.RegisterFlatConveyorT5(registrator);

            this.RegisterLooseMaterialConveyorT4(registrator);
            this.RegisterLooseMaterialConveyorT5(registrator);

            this.RegisterFluidPipeT5(registrator);
        }


        // Register Flat Conveyor Prototype
        private void RegisterFlatConveyorT4(ProtoRegistrator registrator)
        {
            var cost = TransportsCost.FlatConveyorT4.MapToEntityCosts(registrator);

            ProtosDb prototypesDb = registrator.PrototypesDb;

            TransportProto t3Proto = prototypesDb.GetOrThrow<TransportProto>(Ids.Transports.FlatConveyorT3);
            IoPortShapeProto portShape = prototypesDb.GetOrThrow<IoPortShapeProto>(Ids.IoPortShapes.FlatConveyor);

            ImmutableArray<ToolbarEntryData> categoriesProtos = registrator.GetCategoriesProtos(new Proto.ID[] { Ids.ToolbarCategories.Transports_Flat });
            LocStr locStr = Loc.Str(TransportsId.Transports.FlatConveyorT4.Value + "__name", "Flat Conveyor IV", "unit product conveyor belt");
            LocStr locStr2 = Loc.Str(TransportsId.Transports.FlatConveyorT4.Value + "__desc", "Conveys unit products or finished goods, can carry multiple types of goods simultaneously.", "description of flat conveyor belt");
            TransportProto transportProto = new TransportProto(TransportsId.Transports.FlatConveyorT4, Proto.CreateStrFromLocalized(TransportsId.Transports.FlatConveyorT4, locStr, locStr2), t3Proto.SurfaceRelativeHeight, 3.Quantity(), 0.58.Tiles(), RelTile1f.FromTilesPerSecond(2.9), t3Proto.ZStepLength, t3Proto.NeedsPillarsAtGround, t3Proto.CanBeBuried, t3Proto.TileSurfaceWhenOnGround, t3Proto.MaxPillarSupportRadius, portShape, new Electricity(((float)Costs.Transports.ConveyorT3ElectricityPer100.Value * 1.5f).ToFix32().ToIntCeiled()), t3Proto.CornersSharpnessPercent, t3Proto.AllowMixedProducts, t3Proto.IsBuildable, cost, t3Proto.ConstructionDurationPerProduct, this.CreateFlatConveyorT4Gfx(t3Proto, categoriesProtos));
            prototypesDb.Add<TransportProto>(transportProto, false);
            t3Proto.SetNextTier(transportProto, true);
            Log.Info("Transport Data: 4th tier flat conveyor registered");
        }

        private void RegisterFlatConveyorT5(ProtoRegistrator registrator)
        {
            var cost = TransportsCost.FlatConveyorT5.MapToEntityCosts(registrator);

            ProtosDb prototypesDb = registrator.PrototypesDb;

            TransportProto t4Proto = prototypesDb.GetOrThrow<TransportProto>(TransportsId.Transports.FlatConveyorT4);
            IoPortShapeProto portShape = prototypesDb.GetOrThrow<IoPortShapeProto>(Ids.IoPortShapes.FlatConveyor);

            ImmutableArray<ToolbarEntryData> categoriesProtos = registrator.GetCategoriesProtos(new Proto.ID[] { Ids.ToolbarCategories.Transports_Flat });
            LocStr locStr = Loc.Str(TransportsId.Transports.FlatConveyorT5.Value + "__name", "Flat Conveyor V", "unit product conveyor belt");
            LocStr locStr2 = Loc.Str(TransportsId.Transports.FlatConveyorT5.Value + "__name", "Conveyor unit products or finished goods, can carry multiple types of goods simulaneously.", "description of  flat conveyor belt");
            TransportProto transportProto = new TransportProto(TransportsId.Transports.FlatConveyorT5, Proto.CreateStrFromLocalized(TransportsId.Transports.FlatConveyorT5, locStr, locStr2), t4Proto.SurfaceRelativeHeight, 3.Quantity(), 0.58.Tiles(), RelTile1f.FromTilesPerSecond(5.8), t4Proto.ZStepLength, t4Proto.NeedsPillarsAtGround, t4Proto.CanBeBuried, t4Proto.TileSurfaceWhenOnGround, t4Proto.MaxPillarSupportRadius, portShape, new Electricity(((float)Costs.Transports.ConveyorT3ElectricityPer100.Value * 2.25f).ToFix32().ToIntCeiled()), t4Proto.CornersSharpnessPercent, t4Proto.AllowMixedProducts, t4Proto.IsBuildable, cost, t4Proto.ConstructionDurationPerProduct, this.CreateFlatConveyorT5Gfx(t4Proto, categoriesProtos));
            prototypesDb.Add<TransportProto>(transportProto, false);
            t4Proto.SetNextTier(transportProto, true);
            Log.Info("Transport Data: 5th tier flat conveyor registered");
        }

        // Register Loose Conveyor Prototype
        private void RegisterLooseMaterialConveyorT4(ProtoRegistrator registrator)
        {
            var cost = TransportsCost.LooseMaterialConveyorT4.MapToEntityCosts(registrator);

            ProtosDb prototypesDb = registrator.PrototypesDb;

            TransportProto t3Proto = prototypesDb.GetOrThrow<TransportProto>(Ids.Transports.LooseMaterialConveyorT3);
            IoPortShapeProto portShape = prototypesDb.GetOrThrow<IoPortShapeProto>(Ids.IoPortShapes.LooseMaterialConveyor);

            ImmutableArray<ToolbarEntryData> categoriesProtos = registrator.GetCategoriesProtos(new Proto.ID[] { Ids.ToolbarCategories.Transports_Loose });
            LocStr locStr = Loc.Str(TransportsId.Transports.LooseMaterialConveyorT4.Value + "__name", "Loose Conveyor IV", "unit product conveyor belt");
            LocStr locStr2 = Loc.Str(TransportsId.Transports.LooseMaterialConveyorT4.Value + "__desc", "Transports bulk materials. Can load multiple types of goods simultaneously.", "description of u-shaped conveyor belt");
            TransportProto transportProto = new TransportProto(TransportsId.Transports.LooseMaterialConveyorT4, Proto.CreateStrFromLocalized(TransportsId.Transports.LooseMaterialConveyorT4, locStr, locStr2), t3Proto.SurfaceRelativeHeight, 3.Quantity(), 0.58.Tiles(), RelTile1f.FromTilesPerSecond(2.9), t3Proto.ZStepLength, t3Proto.NeedsPillarsAtGround, t3Proto.CanBeBuried, t3Proto.TileSurfaceWhenOnGround, t3Proto.MaxPillarSupportRadius, portShape, new Electricity(((float)Costs.Transports.ConveyorT3ElectricityPer100.Value * 1.5f).ToFix32().ToIntCeiled()), t3Proto.CornersSharpnessPercent, t3Proto.AllowMixedProducts, t3Proto.IsBuildable, cost, t3Proto.ConstructionDurationPerProduct, this.CreateLooseMaterialConveyorT4Gfx(t3Proto, categoriesProtos));
            prototypesDb.Add<TransportProto>(transportProto, false);
            t3Proto.SetNextTier(transportProto, true);
            Log.Info("Transport Data: 4th tier loose material conveyor registered");
        }

        private void RegisterLooseMaterialConveyorT5(ProtoRegistrator registrator)
        {
            var cost = TransportsCost.LooseMaterialConveyorT5.MapToEntityCosts(registrator);

            ProtosDb prototypesDb = registrator.PrototypesDb;

            TransportProto t4Proto = prototypesDb.GetOrThrow<TransportProto>(TransportsId.Transports.LooseMaterialConveyorT4);
            IoPortShapeProto portShape = prototypesDb.GetOrThrow<IoPortShapeProto>(Ids.IoPortShapes.LooseMaterialConveyor);

            ImmutableArray<ToolbarEntryData> categoriesProtos = registrator.GetCategoriesProtos(new Proto.ID[] { Ids.ToolbarCategories.Transports_Loose });
            LocStr locStr = Loc.Str(TransportsId.Transports.LooseMaterialConveyorT5.Value + "__name", "Loose Conveyor V", "unit product conveyor belt");
            LocStr locStr2 = Loc.Str(TransportsId.Transports.LooseMaterialConveyorT5.Value + "__name", "Transports bulk materials. Can load multiple types of goods simultaneously.", "description of u-shaped conveyor belt");
            TransportProto transportProto = new TransportProto(TransportsId.Transports.LooseMaterialConveyorT5, Proto.CreateStrFromLocalized(TransportsId.Transports.LooseMaterialConveyorT5, locStr, locStr2), t4Proto.SurfaceRelativeHeight, 3.Quantity(), 0.58.Tiles(), RelTile1f.FromTilesPerSecond(5.8), t4Proto.ZStepLength, t4Proto.NeedsPillarsAtGround, t4Proto.CanBeBuried, t4Proto.TileSurfaceWhenOnGround, t4Proto.MaxPillarSupportRadius, portShape, new Electricity(((float)Costs.Transports.ConveyorT3ElectricityPer100.Value * 2.25f).ToFix32().ToIntCeiled()), t4Proto.CornersSharpnessPercent, t4Proto.AllowMixedProducts, t4Proto.IsBuildable, cost, t4Proto.ConstructionDurationPerProduct, this.CreateLooseMaterialConveyorT5Gfx(t4Proto, categoriesProtos));
            prototypesDb.Add<TransportProto>(transportProto, false);
            t4Proto.SetNextTier(transportProto, true);
            Log.Info("Transport Data: 5th tier loose material conveyor registered");
        }

        // Register Pipe Prototype
        private void RegisterFluidPipeT5(ProtoRegistrator registrator)
        {
            var cost = TransportsCost.PipeT5.MapToEntityCosts(registrator);

            ProtosDb prototypesDb = registrator.PrototypesDb;

            TransportProto t4Proto = prototypesDb.GetOrThrow<TransportProto>(Ids.Transports.PipeT4);
            IoPortShapeProto portShape = prototypesDb.GetOrThrow<IoPortShapeProto>(Ids.IoPortShapes.Pipe);

            ImmutableArray<ToolbarEntryData> categoriesProtos = registrator.GetCategoriesProtos(new Proto.ID[] { Ids.ToolbarCategories.Transports_Fluid });
            LocStr locStr = Loc.Str(TransportsId.Transports.FluidPipeT5.Value + "__name", "Pipe V", "fluid product transports");
            LocStr locStr2 = Loc.Str(TransportsId.Transports.FluidPipeT5.Value + "__name", "Transport liquid and gasses. Each pipe segment can transport only one product type at a time.", "description of fluid pipe");
            TransportProto transportProto = new TransportProto(TransportsId.Transports.FluidPipeT5, Proto.CreateStrFromLocalized(TransportsId.Transports.FluidPipeT5, locStr, locStr2), t4Proto.SurfaceRelativeHeight, 3.Quantity(), 0.58.Tiles(), RelTile1f.FromTilesPerSecond(5.8), t4Proto.ZStepLength, t4Proto.NeedsPillarsAtGround, t4Proto.CanBeBuried, t4Proto.TileSurfaceWhenOnGround, t4Proto.MaxPillarSupportRadius, portShape, Electricity.Zero, t4Proto.CornersSharpnessPercent, t4Proto.AllowMixedProducts, t4Proto.IsBuildable, cost, t4Proto.ConstructionDurationPerProduct, this.CreatePipeT5Gfx(t4Proto, categoriesProtos));
            prototypesDb.Add<TransportProto>(transportProto, false);
            t4Proto.SetNextTier(transportProto, true);
            Log.Info("Transport Data: 5th tier fluid pipe registered");
        }

        // Flat Conveyor Renderer
        private TransportProto.Gfx CreateFlatConveyorT4Gfx(TransportProto source, ImmutableArray<ToolbarEntryData> categories)
        {
            return new TransportProto.Gfx(
                source.Graphics.CrossSectionLods,
                source.Graphics.RenderProducts,
                "Assets/conveyors/t4conveyors/FlatConveyorT4.mat",
                source.Graphics.TransportUvLength,
                source.Graphics.RenderTransportedProducts,
                source.Graphics.SoundOnBuildPrefabPath,
                source.Graphics.FlowIndicator,
                source.Graphics.VerticalConnectorPrefabPath,
                source.Graphics.PillarAttachments,
                source.Graphics.UvShiftY,
                new TransportProto.Gfx.TransportInstancedRenderingData(),  // ← new instance!
                source.Graphics.CrossSectionRadius,
                source.Graphics.CrossSectionScale,
                source.Graphics.UsePerProductColoring,
                Option<string>.Some("Assets/conveyors/t4conveyors/FlatConveyorT4.png"),
                true,
                source.Graphics.MaxRenderedLod,
                new ImmutableArray<ToolbarEntryData>?(categories),
                false);
        }
        private TransportProto.Gfx CreateFlatConveyorT5Gfx(TransportProto source, ImmutableArray<ToolbarEntryData> categories)
        {
            return new TransportProto.Gfx(
                source.Graphics.CrossSectionLods,
                source.Graphics.RenderProducts,
                "Assets/conveyors/t5conveyors/FlatConveyorT5.mat",
                source.Graphics.TransportUvLength,
                source.Graphics.RenderTransportedProducts,
                source.Graphics.SoundOnBuildPrefabPath,
                source.Graphics.FlowIndicator,
                source.Graphics.VerticalConnectorPrefabPath,
                source.Graphics.PillarAttachments,
                source.Graphics.UvShiftY,
                new TransportProto.Gfx.TransportInstancedRenderingData(),  // ← new instance!
                source.Graphics.CrossSectionRadius,
                source.Graphics.CrossSectionScale,
                source.Graphics.UsePerProductColoring,
                Option<string>.Some("Assets/conveyors/t5conveyors/FlatConveyorT5.png"),
                true,
                source.Graphics.MaxRenderedLod,
                new ImmutableArray<ToolbarEntryData>?(categories),
                false);
        }

        // Loose Material Conveyor Renderer

        private TransportProto.Gfx CreateLooseMaterialConveyorT4Gfx(TransportProto source, ImmutableArray<ToolbarEntryData> categories)
        {
            return new TransportProto.Gfx(
                source.Graphics.CrossSectionLods,
                source.Graphics.RenderProducts,
                "Assets/conveyors/t4conveyors/LooseMaterialConveyorT4.mat",
                source.Graphics.TransportUvLength,
                source.Graphics.RenderTransportedProducts,
                source.Graphics.SoundOnBuildPrefabPath,
                source.Graphics.FlowIndicator,
                source.Graphics.VerticalConnectorPrefabPath,
                source.Graphics.PillarAttachments,
                source.Graphics.UvShiftY,
                new TransportProto.Gfx.TransportInstancedRenderingData(),  // ← new instance!
                source.Graphics.CrossSectionRadius,
                source.Graphics.CrossSectionScale,
                source.Graphics.UsePerProductColoring,
                Option<string>.Some("Assets/conveyors/t4conveyors/LooseMaterialConveyorT4.png"),
                true,
                source.Graphics.MaxRenderedLod,
                new ImmutableArray<ToolbarEntryData>?(categories),
                false);
        }
        private TransportProto.Gfx CreateLooseMaterialConveyorT5Gfx(TransportProto source, ImmutableArray<ToolbarEntryData> categories)
        {
            return new TransportProto.Gfx(
                source.Graphics.CrossSectionLods,
                source.Graphics.RenderProducts,
                "Assets/conveyors/t5conveyors/LooseMaterialConveyorT5.mat",
                source.Graphics.TransportUvLength,
                source.Graphics.RenderTransportedProducts,
                source.Graphics.SoundOnBuildPrefabPath,
                source.Graphics.FlowIndicator,
                source.Graphics.VerticalConnectorPrefabPath,
                source.Graphics.PillarAttachments,
                source.Graphics.UvShiftY,
                new TransportProto.Gfx.TransportInstancedRenderingData(),  // ← new instance!
                source.Graphics.CrossSectionRadius,
                source.Graphics.CrossSectionScale,
                source.Graphics.UsePerProductColoring,
                Option<string>.Some("Assets/conveyors/t5conveyors/LooseMaterialConveyorT5.png"),
                true,
                source.Graphics.MaxRenderedLod,
                new ImmutableArray<ToolbarEntryData>?(categories),
                false);
        }

        // Pipe Renderer
        private TransportProto.Gfx CreatePipeT5Gfx(TransportProto source, ImmutableArray<ToolbarEntryData> categories)
        {
            return new TransportProto.Gfx(
                source.Graphics.CrossSectionLods,
                source.Graphics.RenderProducts,
                source.Graphics.MaterialPath,
                source.Graphics.TransportUvLength,
                source.Graphics.RenderTransportedProducts,
                source.Graphics.SoundOnBuildPrefabPath,
                source.Graphics.FlowIndicator,
                source.Graphics.VerticalConnectorPrefabPath,
                source.Graphics.PillarAttachments,
                source.Graphics.UvShiftY,
                source.Graphics.InstancedRenderingData,
                source.Graphics.CrossSectionRadius,
                source.Graphics.CrossSectionScale,
                source.Graphics.UsePerProductColoring,
                Option<string>.Some("Assets/pipes/FluidPipeT5.png"),
                true,
                source.Graphics.MaxRenderedLod,
                new ImmutableArray<ToolbarEntryData>?(categories),
                false);
        }
    }
}
