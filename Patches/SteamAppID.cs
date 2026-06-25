using HarmonyLib;

namespace BSPiracy
{
    [HarmonyPatch(typeof(SteamManager), "DeleteSteamAppIDFile")]
    public class SteamAppID
    {
        [HarmonyPrefix]
        public static bool Prefix(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}
