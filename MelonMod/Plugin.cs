using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelonMod
{
    [BepInPlugin(modGUID, modName, modVersion)]
    public class MelonModBase : BaseUnityPlugin
    {
        private const string modGUID = "MelonigeMelone.MelonMod";
        private const string modName = "MelonMod";
        private const string modVersion = "1.0.0.0";

        private readonly Harmony harmony = new Harmony(modGUID);

        private static MelonModBase Instance;

        internal ManualLogSource mls;

        void Awake()
        {
            if(Instance == null)
            {
                Instance = new MelonModBase();
            }
             
            mls = BepInEx.Logging.Logger.CreateLogSource(modGUID);

            mls.LogInfo("MelonMod has awaken ;)");

            harmony.PatchAll(typeof(MelonModBase));



        }
    }
}
