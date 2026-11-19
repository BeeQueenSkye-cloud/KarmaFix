using BepInEx;
using Mono.Cecil.Cil;
using R2API;
using RoR2;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace KarmaFixTest
{


    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]


    public class KarmaFix : BaseUnityPlugin
    {
        public const string PluginGUID = PluginAuthor + "." + PluginName;
        public const string PluginAuthor = "FeliFox";
        public const string PluginName = "KarmaFix";
        public const string PluginVersion = "1.0.1";


        public void Awake()
        {
            On.RoR2.Run.ForceChoice_RuleChoiceMask_RuleChoiceMask_string += Choices;
        }

        private void Choices(On.RoR2.Run.orig_ForceChoice_RuleChoiceMask_RuleChoiceMask_string orig, RoR2.Run self, RoR2.RuleChoiceMask mustInclude, RoR2.RuleChoiceMask mustExclude, string choiceDefGlobalName)
        {
            if (!choiceDefGlobalName.Contains("Karma.InitialLevel."))
            {
                orig(self, mustInclude, mustExclude, choiceDefGlobalName);
            }

        }


    }
}