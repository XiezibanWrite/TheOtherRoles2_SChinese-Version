﻿using AmongUs.GameOptions;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using static UnityEngine.UI.Button;

namespace TheOtherRoles.Patches {
    [HarmonyPatch(typeof(CreateOptionsPicker))]
    class CreateOptionsPickerPatch {
        private static List<SpriteRenderer> renderers = new List<SpriteRenderer>();

        [HarmonyPatch(typeof(CreateOptionsPicker), nameof(CreateOptionsPicker.SetGameMode))]
        public static bool Prefix(CreateOptionsPicker __instance, ref GameModes mode) {
            if (mode <= GameModes.HideNSeek) {
                MapOptionsTor.gameMode = CustomGamemodes.Classic;
                return true;
            }

            __instance.SetGameMode(GameModes.Normal);  //__instance.Refresh();

            if ((int)mode == 3) {
                __instance.GameModeText.text = "超多职业赌怪模式";
                MapOptionsTor.gameMode = CustomGamemodes.Guesser;
            } else {
                __instance.GameModeText.text = "超多职业躲猫猫模式";
                MapOptionsTor.gameMode = CustomGamemodes.HideNSeek;
            }
            return false;
        }


        [HarmonyPatch(typeof(CreateOptionsPicker), nameof(CreateOptionsPicker.Refresh))]
        public static void Postfix(CreateOptionsPicker __instance) {
            if (MapOptionsTor.gameMode == CustomGamemodes.Guesser) {
                __instance.GameModeText.text = "超多职业赌怪模式";
            }
            else if (MapOptionsTor.gameMode == CustomGamemodes.HideNSeek) {
                __instance.GameModeText.text = "超多职业躲猫猫模式";
            }
        }
    }

    [HarmonyPatch(typeof(GameModeMenu))]
    class GameModeMenuPatch {
        [HarmonyPatch(typeof(GameModeMenu), nameof(GameModeMenu.OnEnable))]
        public static bool Prefix(GameModeMenu __instance) {
            uint gameMode = (uint)__instance.Parent.GetTargetOptions().GameMode;
            float num = ((float)Mathf.CeilToInt(4f / 10f) / 2f - 0.5f) * -2.5f;   // 4 for 4 buttons!
            __instance.controllerSelectable.Clear();
            int num2 = 0;
            __instance.ButtonPool.poolSize = 4;
            for (int i=0; i <= 4; i++) {
                    GameModes entry = (GameModes)i;
                if (entry != GameModes.None) {
                    ChatLanguageButton chatLanguageButton = __instance.ButtonPool.Get<ChatLanguageButton>();
                    chatLanguageButton.transform.localPosition = new Vector3(num + (float)(num2 / 10) * 2.5f, 2f - (float)(num2 % 10) * 0.5f, 0f);
                    if (i <= 2)
                        chatLanguageButton.Text.text = DestroyableSingleton<TranslationController>.Instance.GetString(GameModesHelpers.ModeToName[entry], new Il2CppReferenceArray<Il2CppSystem.Object>(0));
                    else {
                        chatLanguageButton.Text.text = i == 3 ? "超多职业赌怪模式" : "超多职业躲猫猫模式";
                    }
                    chatLanguageButton.Button.OnClick.RemoveAllListeners();
                    chatLanguageButton.Button.OnClick.AddListener((System.Action)delegate {
                        __instance.ChooseOption(entry);
                    });

                    bool isCurrentMode = i <= 2 && MapOptionsTor.gameMode == CustomGamemodes.Classic ? (long)entry == (long)((ulong)gameMode) : (i == 3 && MapOptionsTor.gameMode == CustomGamemodes.Guesser || i == 4 && MapOptionsTor.gameMode == CustomGamemodes.HideNSeek);
                    chatLanguageButton.SetSelected(isCurrentMode);
                    __instance.controllerSelectable.Add(chatLanguageButton.Button);
                    if (isCurrentMode) {
                        __instance.defaultButtonSelected = chatLanguageButton.Button;
                    }
                    num2++;
                }
            }
            ControllerManager.Instance.OpenOverlayMenu(__instance.name, __instance.BackButton, __instance.defaultButtonSelected, __instance.controllerSelectable, false);
            return false;
        }
    }
}
