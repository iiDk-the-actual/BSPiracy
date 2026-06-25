using BSPiracy.Patches;
using IPA;

namespace BSPiracy
{
    [Plugin(RuntimeOptions.SingleStartInit)]
    public class Plugin
    {
        #region Properties
        internal static Plugin Instance { get; private set; }
        internal static IPA.Logging.Logger PluginLogger { get; private set; }
        #endregion

        [Init]
        public Plugin(IPA.Logging.Logger pluginLogs)
        {
            Instance = this;
            PluginLogger = pluginLogs;
            PatchHandler.PatchAll();
            Logger.Log($"BSPiracy by crimsoncauldron");
        }
    }
}
