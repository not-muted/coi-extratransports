using ExtraTransports.Data;
using Mafi;
using Mafi.Collections;
using Mafi.Core.Mods;
namespace ExtraTransports
{
    public sealed class ExtraTransportsMod : DataOnlyMod
    {
        public ExtraTransportsMod(ModManifest manifest) : base(manifest)
        {
            Log.Info("[ExtraTransports] Constructed");
        }

        public override void RegisterPrototypes(ProtoRegistrator registrator)
        {
            registrator.RegisterData<TransportsData>();
            registrator.RegisterData<TransportsResearchData>();
        }

        public override void MigrateJsonConfig(VersionSlim savedVersion, Dict<string, object> savedValues)
        {
            // Nothing to migrate yet
        }
    }
}