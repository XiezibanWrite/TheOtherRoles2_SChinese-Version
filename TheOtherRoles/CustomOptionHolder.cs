using System.Collections.Generic;
using UnityEngine;
using static TheOtherRoles.TheOtherRoles;
using Types = TheOtherRoles.CustomOption.CustomOptionType;

namespace TheOtherRoles {
    public class CustomOptionHolder {
        public static string[] rates = new string[] { "0%", "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%" };
        public static string[] ratesModifier = new string[] { "1", "2", "3" };
        public static string[] presets = new string[] { "���� 1", "���� 2", "���� 3", "���� 4", "���� 5" };

        public static CustomOption presetSelection;
        public static CustomOption activateRoles;
        public static CustomOption crewmateRolesCountMin;
        public static CustomOption crewmateRolesCountMax;
        public static CustomOption neutralRolesCountMin;
        public static CustomOption neutralRolesCountMax;
        public static CustomOption impostorRolesCountMin;
        public static CustomOption impostorRolesCountMax;
        public static CustomOption modifiersCountMin;
        public static CustomOption modifiersCountMax;
        
        public static CustomOption cultistSpawnRate;

        public static CustomOption swooperSpawnRate;
        public static CustomOption swooperCooldown;
        public static CustomOption swooperAsWell;
        public static CustomOption swooperDuration;
        public static CustomOption swooperHasImpVision;
        
        public static CustomOption minerSpawnRate;
		public static CustomOption minerCooldown;
		
        public static CustomOption mafiaSpawnRate;
        public static CustomOption janitorCooldown;

        public static CustomOption morphlingSpawnRate;
        public static CustomOption morphlingCooldown;
        public static CustomOption morphlingDuration;
        
        public static CustomOption bomberSpawnRate;
        public static CustomOption bomberBombCooldown;
        public static CustomOption bomberDelay;
        public static CustomOption bomberTimer;

        public static CustomOption undertakerSpawnRate;
        public static CustomOption undertakerDragingDelaiAfterKill;
        public static CustomOption undertakerCanDragAndVent;

        public static CustomOption camouflagerSpawnRate;
        public static CustomOption camouflagerCooldown;
        public static CustomOption camouflagerDuration;

        public static CustomOption vampireSpawnRate;
        public static CustomOption vampireKillDelay;
        public static CustomOption vampireCooldown;
        public static CustomOption vampireGarlicButton;
        public static CustomOption vampireCanKillNearGarlics;

        public static CustomOption guesserShowInfoInGhostChat;

        public static CustomOption eraserSpawnRate;
        public static CustomOption eraserCooldown;
        public static CustomOption eraserCanEraseAnyone;
        public static CustomOption guesserSpawnRate;
        public static CustomOption guesserIsImpGuesserRate;
        public static CustomOption guesserNumberOfShots;
        public static CustomOption guesserHasMultipleShotsPerMeeting;
        public static CustomOption guesserKillsThroughShield;
        public static CustomOption guesserEvilCanKillSpy;
        public static CustomOption guesserSpawnBothRate;
        public static CustomOption guesserCantGuessSnitchIfTaksDone;

        public static CustomOption jesterSpawnRate;
        public static CustomOption jesterCanCallEmergency;
        public static CustomOption jesterCanVent;
        public static CustomOption jesterHasImpostorVision;
		
        public static CustomOption prosecutorSpawnRate;
        public static CustomOption prosecutorPreferAmnesiac;

        public static CustomOption amnisiacSpawnRate;
        public static CustomOption amnisiacShowArrows;
        public static CustomOption amnisiacResetRole;

        public static CustomOption arsonistSpawnRate;
        public static CustomOption arsonistCooldown;
        public static CustomOption arsonistDuration;

        public static CustomOption jackalSpawnRate;
        public static CustomOption jackalKillCooldown;
        public static CustomOption jackalCreateSidekickCooldown;
        public static CustomOption jackalCanUseVents;
        public static CustomOption jackalCanUseSabo;
        public static CustomOption jackalhasChat;
        public static CustomOption jackalCanCreateSidekick;
        public static CustomOption sidekickPromotesToJackal;
        public static CustomOption sidekickCanKill;
        public static CustomOption sidekickCanUseVents;
        public static CustomOption jackalPromotedFromSidekickCanCreateSidekick;
        public static CustomOption jackalCanCreateSidekickFromImpostor;
        public static CustomOption jackalAndSidekickHaveImpostorVision;

        public static CustomOption bountyHunterSpawnRate;
        public static CustomOption bountyHunterBountyDuration;
        public static CustomOption bountyHunterReducedCooldown;
        public static CustomOption bountyHunterPunishmentTime;
        public static CustomOption bountyHunterShowArrow;
        public static CustomOption bountyHunterArrowUpdateIntervall;

        public static CustomOption witchSpawnRate;
        public static CustomOption witchCooldown;
        public static CustomOption witchAdditionalCooldown;
        public static CustomOption witchCanSpellAnyone;
        public static CustomOption witchSpellCastingDuration;
        public static CustomOption witchTriggerBothCooldowns;
        public static CustomOption witchVoteSavesTargets;

        public static CustomOption ninjaSpawnRate;
        public static CustomOption ninjaCooldown;
        public static CustomOption ninjaKnowsTargetLocation;
        public static CustomOption ninjaTraceTime;
        public static CustomOption ninjaTraceColorTime;
        public static CustomOption ninjaInvisibleDuration;

        public static CustomOption blackmailerSpawnRate;
        public static CustomOption blackmailerCooldown;

        public static CustomOption shifterSpawnRate;
        public static CustomOption shifterShiftsModifiers;
        public static CustomOption mayorSpawnRate;
        public static CustomOption mayorCanSeeVoteColors;
        public static CustomOption mayorTasksNeededToSeeVoteColors;
        public static CustomOption mayorMeetingButton;
        public static CustomOption mayorMaxRemoteMeetings;

        public static CustomOption portalmakerSpawnRate;
        public static CustomOption portalmakerCooldown;
        public static CustomOption portalmakerUsePortalCooldown;
        public static CustomOption portalmakerLogOnlyColorType;
        public static CustomOption portalmakerLogHasTime;

        public static CustomOption engineerSpawnRate;
        public static CustomOption engineerNumberOfFixes;
        public static CustomOption engineerHighlightForImpostors;
        public static CustomOption engineerHighlightForTeamJackal;

        public static CustomOption sheriffSpawnRate;
        public static CustomOption sheriffCooldown;
        public static CustomOption sheriffCanKillNeutrals;
        public static CustomOption deputySpawnRate;

        public static CustomOption deputyNumberOfHandcuffs;
        public static CustomOption deputyHandcuffCooldown;
        public static CustomOption deputyGetsPromoted;
        public static CustomOption deputyKeepsHandcuffs;
        public static CustomOption deputyHandcuffDuration;
        public static CustomOption deputyKnowsSheriff;

        public static CustomOption lighterSpawnRate;
        public static CustomOption lighterModeLightsOnVision;
        public static CustomOption lighterModeLightsOffVision;
        public static CustomOption lighterCooldown;
        public static CustomOption lighterDuration;

        public static CustomOption detectiveSpawnRate;
        public static CustomOption detectiveAnonymousFootprints;
        public static CustomOption detectiveFootprintIntervall;
        public static CustomOption detectiveFootprintDuration;
        public static CustomOption detectiveReportNameDuration;
        public static CustomOption detectiveReportColorDuration;

        public static CustomOption timeMasterSpawnRate;
        public static CustomOption timeMasterCooldown;
        public static CustomOption timeMasterRewindTime;
        public static CustomOption timeMasterShieldDuration;


        public static CustomOption veterenSpawnRate;
        public static CustomOption veterenCooldown;
        public static CustomOption veterenAlertDuration;

        public static CustomOption medicSpawnRate;
        public static CustomOption medicShowShielded;
        public static CustomOption medicShowAttemptToShielded;
        public static CustomOption medicSetOrShowShieldAfterMeeting;
        public static CustomOption medicShowAttemptToMedic;
        public static CustomOption medicSetShieldAfterMeeting;

        public static CustomOption swapperSpawnRate;
        public static CustomOption swapperCanCallEmergency;
        public static CustomOption swapperCanOnlySwapOthers;
        public static CustomOption swapperSwapsNumber;
        public static CustomOption swapperRechargeTasksNumber;

        public static CustomOption seerSpawnRate;
        public static CustomOption seerMode;
        public static CustomOption seerSoulDuration;
        public static CustomOption seerLimitSoulDuration;

        public static CustomOption hackerSpawnRate;
        public static CustomOption hackerCooldown;
        public static CustomOption hackerHackeringDuration;
        public static CustomOption hackerOnlyColorType;
        public static CustomOption hackerToolsNumber;
        public static CustomOption hackerRechargeTasksNumber;
        public static CustomOption hackerNoMove;

        public static CustomOption trackerSpawnRate;
        public static CustomOption trackerUpdateIntervall;
        public static CustomOption trackerResetTargetAfterMeeting;
        public static CustomOption trackerCanTrackCorpses;
        public static CustomOption trackerCorpsesTrackingCooldown;
        public static CustomOption trackerCorpsesTrackingDuration;

        public static CustomOption snitchSpawnRate;
        public static CustomOption snitchLeftTasksForReveal;
        public static CustomOption snitchIncludeTeamJackal;
        public static CustomOption snitchTeamJackalUseDifferentArrowColor;

        public static CustomOption spySpawnRate;
        public static CustomOption spyCanDieToSheriff;
        public static CustomOption spyImpostorsCanKillAnyone;
        public static CustomOption spyCanEnterVents;
        public static CustomOption spyHasImpostorVision;

        public static CustomOption tricksterSpawnRate;
        public static CustomOption tricksterPlaceBoxCooldown;
        public static CustomOption tricksterLightsOutCooldown;
        public static CustomOption tricksterLightsOutDuration;

        public static CustomOption cleanerSpawnRate;
        public static CustomOption cleanerCooldown;
        
        public static CustomOption warlockSpawnRate;
        public static CustomOption warlockCooldown;
        public static CustomOption warlockRootTime;

        public static CustomOption securityGuardSpawnRate;
        public static CustomOption securityGuardCooldown;
        public static CustomOption securityGuardTotalScrews;
        public static CustomOption securityGuardCamPrice;
        public static CustomOption securityGuardVentPrice;
        public static CustomOption securityGuardCamDuration;
        public static CustomOption securityGuardCamMaxCharges;
        public static CustomOption securityGuardCamRechargeTasksNumber;
        public static CustomOption securityGuardNoMove;

        public static CustomOption bodyGuardSpawnRate;
        public static CustomOption bodyGuardResetTargetAfterMeeting;

        public static CustomOption vultureSpawnRate;
        public static CustomOption vultureCooldown;
        public static CustomOption vultureNumberToWin;
        public static CustomOption vultureCanUseVents;
        public static CustomOption vultureShowArrows;

        public static CustomOption mediumSpawnRate;
        public static CustomOption mediumCooldown;
        public static CustomOption mediumDuration;
        public static CustomOption mediumOneTimeUse;

        public static CustomOption lawyerSpawnRate;
        public static CustomOption lawyerIsProsecutorChance;
        public static CustomOption lawyerTargetCanBeJester;
        public static CustomOption lawyerVision;
        public static CustomOption lawyerKnowsRole;
        public static CustomOption lawyerCanCallEmergency;
        public static CustomOption pursuerCooldown;
        public static CustomOption pursuerBlanksNumber;

        public static CustomOption werewolfSpawnRate;
        public static CustomOption werewolfRampageCooldown;
        public static CustomOption werewolfRampageDuration;
        public static CustomOption werewolfKillCooldown;
        
        public static CustomOption thiefSpawnRate;
        public static CustomOption thiefCooldown;
        public static CustomOption thiefHasImpVision;
        public static CustomOption thiefCanUseVents;
        public static CustomOption thiefCanKillSheriff;


        public static CustomOption trapperSpawnRate;
        public static CustomOption trapperCooldown;
        public static CustomOption trapperMaxCharges;
        public static CustomOption trapperRechargeTasksNumber;
        public static CustomOption trapperTrapNeededTriggerToReveal;
        public static CustomOption trapperAnonymousMap;
        public static CustomOption trapperInfoType;
        public static CustomOption trapperTrapDuration;

        public static CustomOption modifiersAreHidden;

        public static CustomOption modifierBait;
        public static CustomOption modifierBaitQuantity;
        public static CustomOption modifierBaitReportDelayMin;
        public static CustomOption modifierBaitReportDelayMax;
        public static CustomOption modifierBaitShowKillFlash;

        public static CustomOption modifierLover;
        public static CustomOption modifierLoverImpLoverRate;
        public static CustomOption modifierLoverBothDie;
        public static CustomOption modifierLoverEnableChat;

        public static CustomOption modifierBloody;
        public static CustomOption modifierBloodyQuantity;
        public static CustomOption modifierBloodyDuration;

        public static CustomOption modifierAntiTeleport;
        public static CustomOption modifierAntiTeleportQuantity;

        public static CustomOption modifierTieBreaker;

        public static CustomOption modifierSunglasses;
        public static CustomOption modifierSunglassesQuantity;
        public static CustomOption modifierSunglassesVision;
        
        public static CustomOption modifierMini;
        public static CustomOption modifierMiniGrowingUpDuration;
        public static CustomOption modifierMiniGrowingUpInMeeting;

        public static CustomOption modifierIndomitable;
        public static CustomOption modifierTunneler;
        public static CustomOption modifierBlind;
        public static CustomOption modifierSlueth;
		public static CustomOption modifierCursed;

        public static CustomOption modifierVip;
        public static CustomOption modifierVipQuantity;
        public static CustomOption modifierVipShowColor;

        public static CustomOption modifierInvert;
        public static CustomOption modifierInvertQuantity;
        public static CustomOption modifierInvertDuration;

        public static CustomOption modifierChameleon;
        public static CustomOption modifierChameleonQuantity;
        public static CustomOption modifierChameleonHoldDuration;
        public static CustomOption modifierChameleonFadeDuration;
        public static CustomOption modifierChameleonMinVisibility;

        public static CustomOption modifierShifter;

        public static CustomOption maxNumberOfMeetings;
        public static CustomOption blockSkippingInEmergencyMeetings;
        public static CustomOption noVoteIsSelfVote;
        public static CustomOption hidePlayerNames;
        public static CustomOption showButtonTarget;
        public static CustomOption blockGameEnd;
        public static CustomOption allowParallelMedBayScans;
        public static CustomOption shieldFirstKill;

        public static CustomOption randomGameStartPosition;
        public static CustomOption allowModGuess;
        public static CustomOption resetRoundStartCooldown;

        public static CustomOption dynamicMap;
        public static CustomOption dynamicMapEnableSkeld;
        public static CustomOption dynamicMapEnableMira;
        public static CustomOption dynamicMapEnablePolus;
        public static CustomOption dynamicMapEnableAirShip;
        public static CustomOption dynamicMapEnableSubmerged;
		
		public static CustomOption movePolusVents;
		public static CustomOption swapNavWifi;
		public static CustomOption movePolusVitals;
		public static CustomOption enableBetterPolus;
		public static CustomOption moveColdTemp;
		
		
		public static CustomOption enableCamoComms;
		
        public static CustomOption restrictDevices;
        public static CustomOption restrictAdmin;
        public static CustomOption restrictCameras;
        public static CustomOption restrictVents;

        //Guesser Gamemode
        public static CustomOption guesserGamemodeCrewNumber;
        public static CustomOption guesserGamemodeNeutralNumber;
        public static CustomOption guesserGamemodeImpNumber;
        public static CustomOption guesserForceJackalGuesser;
        public static CustomOption guesserGamemodeHaveModifier;
        public static CustomOption guesserGamemodeNumberOfShots;
        public static CustomOption guesserGamemodeHasMultipleShotsPerMeeting;
        public static CustomOption guesserGamemodeKillsThroughShield;
        public static CustomOption guesserGamemodeEvilCanKillSpy;
        public static CustomOption guesserGamemodeCantGuessSnitchIfTaksDone;

        // Hide N Seek Gamemode
        public static CustomOption hideNSeekHunterCount;
        public static CustomOption hideNSeekKillCooldown;
        public static CustomOption hideNSeekHunterVision;
        public static CustomOption hideNSeekHuntedVision;
        public static CustomOption hideNSeekTimer;
        public static CustomOption hideNSeekCommonTasks;
        public static CustomOption hideNSeekShortTasks;
        public static CustomOption hideNSeekLongTasks;
        public static CustomOption hideNSeekTaskWin;
        public static CustomOption hideNSeekTaskPunish;
        public static CustomOption hideNSeekCanSabotage;
        public static CustomOption hideNSeekMap;
        public static CustomOption hideNSeekHunterWaiting;

        public static CustomOption hunterLightCooldown;
        public static CustomOption hunterLightDuration;
        public static CustomOption hunterLightVision;
        public static CustomOption hunterLightPunish;
        public static CustomOption hunterAdminCooldown;
        public static CustomOption hunterAdminDuration;
        public static CustomOption hunterAdminPunish;
        public static CustomOption hunterArrowCooldown;
        public static CustomOption hunterArrowDuration;
        public static CustomOption hunterArrowPunish;

        public static CustomOption huntedShieldCooldown;
        public static CustomOption huntedShieldDuration;
        public static CustomOption huntedShieldRewindTime;
        public static CustomOption huntedShieldNumber;

        internal static Dictionary<byte, byte[]> blockedRolePairings = new Dictionary<byte, byte[]>();

        public static string cs(Color c, string s) {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), s);
        }
 
        private static byte ToByte(float f) {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }

        public static void Load() {


            // Role Options
            presetSelection = CustomOption.Create(0, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����"), presets, null, true);
            activateRoles = CustomOption.Create(1, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ģ��ְҵ������ԭ��ְҵ"), true, null, true);

            // Using new id's for the options to not break compatibilty with older versions
            crewmateRolesCountMin = CustomOption.Create(300, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С��Աְҵ��"), 15f, 0f, 15f, 1f, null, true);
            crewmateRolesCountMax = CustomOption.Create(301, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���Աְҵ��"), 15f, 0f, 15f, 1f);
            neutralRolesCountMin = CustomOption.Create(302, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С����ְҵ��"), 15f, 0f, 15f, 1f);
            neutralRolesCountMax = CustomOption.Create(303, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "�������ְҵ��"), 15f, 0f, 15f, 1f);
            impostorRolesCountMin = CustomOption.Create(304, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��С�ڹ�ְҵ��"), 15f, 0f, 3f, 1f);
            impostorRolesCountMax = CustomOption.Create(305, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "����ڹ�ְҵ��"), 15f, 0f, 3f, 1f);
            modifiersCountMin = CustomOption.Create(306, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "��СЧ����"), 15f, 0f, 15f, 1f);
            modifiersCountMax = CustomOption.Create(307, Types.General, cs(new Color(204f / 255f, 204f / 255f, 0, 1f), "���Ч����"), 15f, 0f, 15f, 1f);

            mafiaSpawnRate = CustomOption.Create(10, Types.Impostor, cs(Janitor.color, "���ֵ�"), rates, null, true);
            janitorCooldown = CustomOption.Create(11, Types.Impostor, "��๤��ȴʱ��", 30f, 10f, 60f, 2.5f, mafiaSpawnRate);

            morphlingSpawnRate = CustomOption.Create(20, Types.Impostor, cs(Morphling.color, "������"), rates, null, true);
            morphlingCooldown = CustomOption.Create(21, Types.Impostor, "������ȴʱ��", 30f, 10f, 60f, 2.5f, morphlingSpawnRate);
            morphlingDuration = CustomOption.Create(22, Types.Impostor, "���γ���ʱ��", 10f, 1f, 20f, 0.5f, morphlingSpawnRate);

            // public static CustomOption bomberSpawnRate;
            // public static CustomOption bomberBombCooldown;
            // public static CustomOption bomberDelay;
            // public static CustomOption bomberTimer;

            bomberSpawnRate = CustomOption.Create(8840, Types.Impostor, cs(Bomber.color, "ը���� [���԰�]"), rates, null, true);
            bomberBombCooldown = CustomOption.Create(8841, Types.Impostor, "ը������ȴʱ��", 30f, 25f, 60f, 2.5f, bomberSpawnRate);
            bomberDelay = CustomOption.Create(8842, Types.Impostor, "ը����ʱ", 10f, 1f, 20f, 0.5f, bomberSpawnRate);
            bomberTimer = CustomOption.Create(8843, Types.Impostor, "ը����ʱ��", 10f, 5f, 30f, 5f, bomberSpawnRate);



            undertakerSpawnRate = CustomOption.Create(1201, Types.Impostor, cs(Undertaker.color, "������"), rates, null, true);
            undertakerDragingDelaiAfterKill = CustomOption.Create(1202, Types.Impostor, "ɱ�˺���ӳ���ק", 0f, 0f, 15, 1f, undertakerSpawnRate);
            undertakerCanDragAndVent = CustomOption.Create(1203, Types.Impostor, "�������϶�ʱ���", true, undertakerSpawnRate);


            camouflagerSpawnRate = CustomOption.Create(30, Types.Impostor, cs(Camouflager.color, "������"), rates, null, true);
            camouflagerCooldown = CustomOption.Create(31, Types.Impostor, "������ȴʱ��", 30f, 10f, 60f, 2.5f, camouflagerSpawnRate);
            camouflagerDuration = CustomOption.Create(32, Types.Impostor, "���γ���ʱ��", 10f, 1f, 20f, 0.5f, camouflagerSpawnRate);

            vampireSpawnRate = CustomOption.Create(40, Types.Impostor, cs(Vampire.color, "��Ѫ��"), rates, null, true);
            vampireKillDelay = CustomOption.Create(41, Types.Impostor, "��Ѫ���ɱ��ʱ", 10f, 1f, 20f, 1f, vampireSpawnRate);
            vampireCooldown = CustomOption.Create(42, Types.Impostor, "��Ѫ����ȴʱ��", 30f, 10f, 60f, 2.5f, vampireSpawnRate);
            vampireGarlicButton = CustomOption.Create(43, Types.Impostor, "���ô���", true, vampireSpawnRate);
            vampireCanKillNearGarlics = CustomOption.Create(44, Types.Impostor, "��Ѫ������ڴ��⸽����ɱ", true, vampireGarlicButton);


            eraserSpawnRate = CustomOption.Create(230, Types.Impostor, cs(Eraser.color, "Ĩ����"), rates, null, true);
            eraserCooldown = CustomOption.Create(231, Types.Impostor, "Ĩ����ȴʱ��", 30f, 10f, 120f, 5f, eraserSpawnRate);
            eraserCanEraseAnyone = CustomOption.Create(232, Types.Impostor, "Ĩ���߿���Ĩ��������", false, eraserSpawnRate);

            tricksterSpawnRate = CustomOption.Create(250, Types.Impostor, cs(Trickster.color, "ƭ��ʦ"), rates, null, true);
            tricksterPlaceBoxCooldown = CustomOption.Create(251, Types.Impostor, "ƭ��ʦ��ֹ������ȴʱ��", 10f, 2.5f, 30f, 2.5f, tricksterSpawnRate);
            tricksterLightsOutCooldown = CustomOption.Create(252, Types.Impostor, "ƭ��ʦ�ص���ȴʱ��", 30f, 10f, 60f, 5f, tricksterSpawnRate);
            tricksterLightsOutDuration = CustomOption.Create(253, Types.Impostor, "ƭ��ʦ�صƳ���ʱ��", 15f, 5f, 60f, 2.5f, tricksterSpawnRate);

            cleanerSpawnRate = CustomOption.Create(260, Types.Impostor, cs(Cleaner.color, "������"), rates, null, true);
            cleanerCooldown = CustomOption.Create(261, Types.Impostor, "������ȴʱ��", 30f, 10f, 60f, 2.5f, cleanerSpawnRate);

            warlockSpawnRate = CustomOption.Create(270, Types.Impostor, cs(Cleaner.color, "��ʿ"), rates, null, true);
            warlockCooldown = CustomOption.Create(271, Types.Impostor, "��ʿ��ȴʱ��", 30f, 10f, 60f, 2.5f, warlockSpawnRate);
            warlockRootTime = CustomOption.Create(272, Types.Impostor, "��ʿ��ɱʱ��", 5f, 0f, 15f, 1f, warlockSpawnRate);

            bountyHunterSpawnRate = CustomOption.Create(320, Types.Impostor, cs(BountyHunter.color, "�ͽ�����"), rates, null, true);
            bountyHunterBountyDuration = CustomOption.Create(321, Types.Impostor, "�ͽ�Ŀ��仯����", 60f, 10f, 180f, 10f, bountyHunterSpawnRate);
            bountyHunterReducedCooldown = CustomOption.Create(322, Types.Impostor, "��ɱ��ȷĿ����ȴ", 2.5f, 0f, 30f, 2.5f, bountyHunterSpawnRate);
            bountyHunterPunishmentTime = CustomOption.Create(323, Types.Impostor, "��ɱ����Ŀ����ȴ", 20f, 0f, 60f, 2.5f, bountyHunterSpawnRate);
            bountyHunterShowArrow = CustomOption.Create(324, Types.Impostor, "��ʾָ���ͽ�Ŀ��ļ�ͷ", true, bountyHunterSpawnRate);
            bountyHunterArrowUpdateIntervall = CustomOption.Create(325, Types.Impostor, "��ͷ��������", 15f, 2.5f, 60f, 2.5f, bountyHunterShowArrow);

            witchSpawnRate = CustomOption.Create(370, Types.Impostor, cs(Witch.color, "Ů��"), rates, null, true);
            witchCooldown = CustomOption.Create(371, Types.Impostor, "Ů��������ȴʱ��", 30f, 10f, 120f, 5f, witchSpawnRate);
            witchAdditionalCooldown = CustomOption.Create(372, Types.Impostor, "Ů�׶������ȴʱ��", 10f, 0f, 60f, 5f, witchSpawnRate);
            witchCanSpellAnyone = CustomOption.Create(373, Types.Impostor, "Ů�׿�������������", false, witchSpawnRate);
            witchSpellCastingDuration = CustomOption.Create(374, Types.Impostor, "�������ʱ��", 1f, 0f, 10f, 1f, witchSpawnRate);
            witchTriggerBothCooldowns = CustomOption.Create(375, Types.Impostor, "����������ȴ����", true, witchSpawnRate);
            witchVoteSavesTargets = CustomOption.Create(376, Types.Impostor, "��Ů��Ͷ����������Ŀ��", true, witchSpawnRate);

            ninjaSpawnRate = CustomOption.Create(380, Types.Impostor, cs(Ninja.color, "����"), rates, null, true);
            ninjaCooldown = CustomOption.Create(381, Types.Impostor, "���߱����ȴʱ��", 30f, 10f, 120f, 5f, ninjaSpawnRate);
            ninjaKnowsTargetLocation = CustomOption.Create(382, Types.Impostor, "����֪��Ŀ��λ��", true, ninjaSpawnRate);
            ninjaTraceTime = CustomOption.Create(383, Types.Impostor, "׷�ٳ���ʱ��", 5f, 1f, 20f, 0.5f, ninjaSpawnRate);
            ninjaTraceColorTime = CustomOption.Create(384, Types.Impostor, "ֱ���ۼ���ɫ��ȥ��ʱ��", 2f, 0f, 20f, 0.5f, ninjaSpawnRate);
            ninjaInvisibleDuration = CustomOption.Create(385, Types.Impostor, "������ʱ�������ε�", 3f, 0f, 20f, 1f, ninjaSpawnRate);

            blackmailerSpawnRate = CustomOption.Create(710, Types.Impostor, cs(Blackmailer.color, "������"), rates, null, true);
            blackmailerCooldown = CustomOption.Create(711, Types.Impostor, "��թ��ȴʱ��", 30f, 5f, 120f, 5f, blackmailerSpawnRate);



            guesserSpawnRate = CustomOption.Create(310, Types.Modifier, cs(Guesser.color, "�Ĺ�"), false, null, true);
            guesserIsImpGuesserRate = CustomOption.Create(311, Types.Modifier, "а�����ɼ���", rates, guesserSpawnRate);
            guesserSpawnBothRate = CustomOption.Create(317, Types.Modifier, "�������ɼ���", rates, guesserSpawnRate);
            guesserNumberOfShots = CustomOption.Create(312, Types.Modifier, "�Ĺֲ²���", 2f, 1f, 15f, 1f, guesserSpawnRate);
            guesserHasMultipleShotsPerMeeting = CustomOption.Create(313, Types.Modifier, "�Ĺ���һ�ֻ����пɶ�β²�", false, guesserSpawnRate);
            guesserShowInfoInGhostChat = CustomOption.Create(314, Types.Modifier, "�Ĺֲ²��ڹ��Ƶ����ɼ�", true, guesserSpawnRate);
            guesserKillsThroughShield  = CustomOption.Create(315, Types.Modifier, "�Ĺֲ²�����ҽ������", true, guesserSpawnRate);
            guesserEvilCanKillSpy  = CustomOption.Create(316, Types.Modifier, "а��ĶĹֿ��Բ²��Ե�", true, guesserSpawnRate);
            guesserCantGuessSnitchIfTaksDone = CustomOption.Create(318, Types.Modifier, "�Ĺֲ����Բ²��������ĸ�����", true, guesserSpawnRate);

            jesterSpawnRate = CustomOption.Create(60, Types.Neutral, cs(Jester.color, "С��"), rates, null, true);
            jesterCanCallEmergency = CustomOption.Create(61, Types.Neutral, "С������ٿ���������", true, jesterSpawnRate);
            jesterCanVent = CustomOption.Create(1901, Types.Neutral, "С�����ʹ�ùܵ�", true, jesterSpawnRate);
            jesterHasImpostorVision = CustomOption.Create(62, Types.Neutral, "С��ӵ���ڹ���Ұ", false, jesterSpawnRate);

            prosecutorSpawnRate = CustomOption.Create(615, Types.Neutral, cs(Prosecutor.color, "������"), rates, null, true);

            amnisiacSpawnRate = CustomOption.Create(616, Types.Neutral, cs(Amnisiac.color, "ʧ����"), rates, null, true);
            amnisiacShowArrows = CustomOption.Create(617, Types.Neutral, "չʾ����ʬ��ļ�ͷ", true, amnisiacSpawnRate);
            amnisiacResetRole = CustomOption.Create(618, Types.Neutral, "��ȡʱ���ý�ɫ", true, amnisiacSpawnRate);


            arsonistSpawnRate = CustomOption.Create(290, Types.Neutral, cs(Arsonist.color, "�ݻ�"), rates, null, true);
            arsonistCooldown = CustomOption.Create(291, Types.Neutral, "�ݻ���ȴʱ��", 12.5f, 2.5f, 60f, 2.5f, arsonistSpawnRate);
            arsonistDuration = CustomOption.Create(292, Types.Neutral, "�ݻ𷸽���ʱ��", 3f, 1f, 10f, 1f, arsonistSpawnRate);

            jackalSpawnRate = CustomOption.Create(220, Types.Neutral, cs(Jackal.color, "����"), rates, null, true);
            jackalKillCooldown = CustomOption.Create(221, Types.Neutral, "����/�����ɱ��ȴ", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalCreateSidekickCooldown = CustomOption.Create(222, Types.Neutral, "������ļ������ȴ", 30f, 10f, 60f, 2.5f, jackalSpawnRate);
            jackalhasChat = CustomOption.Create(1197, Types.Neutral, "�����Ŷӿ�����", false, jackalSpawnRate);
            jackalCanUseVents = CustomOption.Create(223, Types.Neutral, "���ǿ���ʹ�ùܵ�", true, jackalSpawnRate);
            jackalCanUseSabo = CustomOption.Create(8876, Types.Neutral, "������Ӫ�����ƻ�", false, jackalSpawnRate);
            jackalCanCreateSidekick = CustomOption.Create(224, Types.Neutral, "���ǿ�����ļ����", false, jackalSpawnRate);
            sidekickPromotesToJackal = CustomOption.Create(225, Types.Neutral, "�����ڲ�������ʱ��Ϊ����", false, jackalCanCreateSidekick);
            sidekickCanKill = CustomOption.Create(226, Types.Neutral, "������Ի�ɱ", false, jackalCanCreateSidekick);
            sidekickCanUseVents = CustomOption.Create(227, Types.Neutral, "�������ʹ�ùܵ�", true, jackalCanCreateSidekick);
            jackalPromotedFromSidekickCanCreateSidekick = CustomOption.Create(228, Types.Neutral, "�������Ϊ���ǿ�������ļ", true, sidekickPromotesToJackal);
            jackalCanCreateSidekickFromImpostor = CustomOption.Create(229, Types.Neutral, "���ǿ�����ļ�ڹ�Ϊ����", true, jackalCanCreateSidekick);
            jackalAndSidekickHaveImpostorVision = CustomOption.Create(430, Types.Neutral, "������Ӫӵ���ڹ���Ұ", false, jackalSpawnRate);

            swooperSpawnRate = CustomOption.Create(1110, Types.Neutral, cs(Swooper.color, "������"), rates, null, true); //jackalSpawnRate);
            swooperAsWell = CustomOption.Create(1113, Types.Neutral, "����ʱ��Ϊ����", false, swooperSpawnRate);
            swooperCooldown = CustomOption.Create(1111, Types.Neutral, "������ȴ", 30f, 10f, 60f, 2.5f, swooperSpawnRate);
            swooperDuration = CustomOption.Create(1112, Types.Neutral, "����ʱ��", 10f, 1f, 20f, 0.5f, swooperSpawnRate);
            swooperHasImpVision = CustomOption.Create(1114, Types.Neutral, "������ӵ���ڹ���Ұ", true, swooperSpawnRate);

            minerSpawnRate = CustomOption.Create(1120, Types.Impostor, cs(Miner.color, "�ܵ���"), rates, null, true); //jackalSpawnRate);
            minerCooldown = CustomOption.Create(1121, Types.Impostor, "�½��ܵ���ȴʱ��", 25f, 10f, 60f, 2.5f, minerSpawnRate);

            vultureSpawnRate = CustomOption.Create(340, Types.Neutral, cs(Vulture.color, "ͺ��"), rates, null, true);
            vultureCooldown = CustomOption.Create(341, Types.Neutral, "ͺ����ȴʱ��", 15f, 10f, 60f, 2.5f, vultureSpawnRate);
            vultureNumberToWin = CustomOption.Create(342, Types.Neutral, "��Ҫ���Ե���ʬ�������", 4f, 1f, 10f, 1f, vultureSpawnRate);
            vultureCanUseVents = CustomOption.Create(343, Types.Neutral, "ͺ�տ���ʹ�ùܵ�", true, vultureSpawnRate);
            vultureShowArrows = CustomOption.Create(344, Types.Neutral, "��ʾָ��ʬ��ļ�ͷ", true, vultureSpawnRate);

            lawyerSpawnRate = CustomOption.Create(350, Types.Neutral, cs(Lawyer.color, "��ʦ"), rates, null, true);
            lawyerIsProsecutorChance = CustomOption.Create(358, Types.Neutral, "��ʦ�Ǵ����ߵļ���", rates, lawyerSpawnRate);
            lawyerVision = CustomOption.Create(354, Types.Neutral, "��Ұ", 1f, 0.25f, 3f, 0.25f, lawyerSpawnRate);
            lawyerKnowsRole = CustomOption.Create(355, Types.Neutral, "��ʦ/������ ֪��Ŀ���ְҵ", false, lawyerSpawnRate);
            lawyerCanCallEmergency = CustomOption.Create(352, Types.Neutral, "��ʦ/������ �����ٿ���������", true, lawyerSpawnRate);
            lawyerTargetCanBeJester = CustomOption.Create(351, Types.Neutral, "��ʦĿ�������С��", false, lawyerSpawnRate);
            pursuerCooldown = CustomOption.Create(356, Types.Neutral, "�հ�����ȴʱ��", 30f, 5f, 60f, 2.5f, lawyerSpawnRate);
            pursuerBlanksNumber = CustomOption.Create(357, Types.Neutral, "�հ�������", 5f, 1f, 20f, 1f, lawyerSpawnRate);

            werewolfSpawnRate = CustomOption.Create(1501, Types.Neutral, cs(Werewolf.color, "����"), rates, null, true);
            werewolfRampageCooldown = CustomOption.Create(1502, Types.Neutral, "���ֱײ��ȴʱ��", 30f, 10f, 60f, 2.5f, werewolfSpawnRate);
            werewolfRampageDuration = CustomOption.Create(1503, Types.Neutral, "���ֱײ����ʱ��", 15f, 1f, 20f, 0.5f, werewolfSpawnRate);
            werewolfKillCooldown = CustomOption.Create(1504, Types.Neutral, "��ɱ��ȴʱ��", 3f, 1f, 60f, 1f, werewolfSpawnRate);

            mayorSpawnRate = CustomOption.Create(80, Types.Crewmate, cs(Mayor.color, "�г�"), rates, null, true);
            mayorCanSeeVoteColors = CustomOption.Create(81, Types.Crewmate, "�г����Կ���ͶƱ����ɫ", false, mayorSpawnRate);
            mayorTasksNeededToSeeVoteColors = CustomOption.Create(82, Types.Crewmate, "����ͶƱ����ɫ�����������", 5f, 0f, 20f, 1f, mayorCanSeeVoteColors);
            mayorMeetingButton = CustomOption.Create(83, Types.Crewmate, "ӵ���ƶ�ʽ������ť", true, mayorSpawnRate);
            mayorMaxRemoteMeetings = CustomOption.Create(84, Types.Crewmate, "Զ�̻��������", 1f, 1f, 5f, 1f, mayorMeetingButton);

            engineerSpawnRate = CustomOption.Create(90, Types.Crewmate, cs(Engineer.color, "����ʦ"), rates, null, true);
            engineerNumberOfFixes = CustomOption.Create(91, Types.Crewmate, "��������", 1f, 1f, 3f, 1f, engineerSpawnRate);
            engineerHighlightForImpostors = CustomOption.Create(92, Types.Crewmate, "�ڹ���Կ���ͨ��ڸ���", true, engineerSpawnRate);
            engineerHighlightForTeamJackal = CustomOption.Create(93, Types.Crewmate, "������Ӫ���Կ���ͨ��ڸ��� ", true, engineerSpawnRate);

            sheriffSpawnRate = CustomOption.Create(100, Types.Crewmate, cs(Sheriff.color, "����"), rates, null, true);
            sheriffCooldown = CustomOption.Create(101, Types.Crewmate, "������ȴʱ��", 30f, 10f, 60f, 2.5f, sheriffSpawnRate);
            sheriffCanKillNeutrals = CustomOption.Create(102, Types.Crewmate, "�������Ի�ɱ����", false, sheriffSpawnRate);
            deputySpawnRate = CustomOption.Create(103, Types.Crewmate, "������һ������", rates, sheriffSpawnRate);
            deputyNumberOfHandcuffs = CustomOption.Create(104, Types.Crewmate, "����ӵ�����������", 3f, 1f, 10f, 1f, deputySpawnRate);
            deputyHandcuffCooldown = CustomOption.Create(105, Types.Crewmate, "�������ȴʱ��", 30f, 10f, 60f, 2.5f, deputySpawnRate);
            deputyHandcuffDuration = CustomOption.Create(106, Types.Crewmate, "�������ʱ��", 15f, 5f, 60f, 2.5f, deputySpawnRate);
            deputyKnowsSheriff = CustomOption.Create(107, Types.Crewmate, "�����Ͳ���֮�以��֪�� ", true, deputySpawnRate);
            deputyGetsPromoted = CustomOption.Create(108, Types.Crewmate, "�ھ������󲶿���Ϊ����", new string[] { "��", "�� (����)", "�� (����֮��)" }, deputySpawnRate);
            deputyKeepsHandcuffs = CustomOption.Create(109, Types.Crewmate, "������Ϊ�������Ա�������", true, deputyGetsPromoted);

            lighterSpawnRate = CustomOption.Create(110, Types.Crewmate, cs(Lighter.color, "ִ����"), rates, null, true);
            lighterModeLightsOnVision = CustomOption.Create(111, Types.Crewmate, "ִ����ִ���ڿ���״̬�µ���Ұ", 2f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterModeLightsOffVision = CustomOption.Create(112, Types.Crewmate, "ִ����ִ���ڹص�״̬�µ���Ұ", 0.75f, 0.25f, 5f, 0.25f, lighterSpawnRate);
            lighterCooldown = CustomOption.Create(113, Types.Crewmate, "ִ����ȴʱ��", 30f, 5f, 120f, 5f, lighterSpawnRate);
            lighterDuration = CustomOption.Create(114, Types.Crewmate, "ִ�Ƴ���ʱ��", 5f, 2.5f, 60f, 2.5f, lighterSpawnRate);

            detectiveSpawnRate = CustomOption.Create(120, Types.Crewmate, cs(Detective.color, "��̽"), rates, null, true);
            detectiveAnonymousFootprints = CustomOption.Create(121, Types.Crewmate, "��ӡ����", false, detectiveSpawnRate);
            detectiveFootprintIntervall = CustomOption.Create(122, Types.Crewmate, "��ӡ��ʧ���ʱ��", 0.5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveFootprintDuration = CustomOption.Create(123, Types.Crewmate, "��ӡ����ʱ��", 5f, 0.25f, 10f, 0.25f, detectiveSpawnRate);
            detectiveReportNameDuration = CustomOption.Create(124, Types.Crewmate, "�ڶ������ڱ�����̽��֪��������", 0, 0, 60, 2.5f, detectiveSpawnRate);
            detectiveReportColorDuration = CustomOption.Create(125, Types.Crewmate, "�ڶ������ڱ�����̽��֪������ɫ����", 20, 0, 120, 2.5f, detectiveSpawnRate);

            timeMasterSpawnRate = CustomOption.Create(130, Types.Crewmate, cs(TimeMaster.color, "ʱ��֮��"), rates, null, true);
            timeMasterCooldown = CustomOption.Create(131, Types.Crewmate, "ʱ��֮����ȴʱ��", 30f, 10f, 120f, 2.5f, timeMasterSpawnRate);
            timeMasterRewindTime = CustomOption.Create(132, Types.Crewmate, "����ʱ��", 3f, 1f, 10f, 1f, timeMasterSpawnRate);
            timeMasterShieldDuration = CustomOption.Create(133, Types.Crewmate, "ʱ��֮�ܳ���ʱ��", 3f, 1f, 20f, 1f, timeMasterSpawnRate);

            veterenSpawnRate = CustomOption.Create(4450, Types.Crewmate, cs(Veteren.color, "�ϱ�"), rates, null, true);
            veterenCooldown = CustomOption.Create(4451, Types.Crewmate, "������ȴʱ��", 30f, 10f, 120f, 2.5f, veterenSpawnRate);
            veterenAlertDuration = CustomOption.Create(4452, Types.Crewmate, "�������ʱ��", 3f, 1f, 20f, 1f, veterenSpawnRate);

            medicSpawnRate = CustomOption.Create(140, Types.Crewmate, cs(Medic.color, "ҽ��"), rates, null, true);
            medicShowShielded = CustomOption.Create(143, Types.Crewmate, "��ʾ�ܸ����", new string[] { "������", "��������ߺ�ҽ��", "ҽ��" }, medicSpawnRate);
            medicShowAttemptToShielded = CustomOption.Create(144, Types.Crewmate, "��������߿�֪��ɱ����", false, medicSpawnRate);
            medicSetOrShowShieldAfterMeeting = CustomOption.Create(145, Types.Crewmate, "�ܱ�����ʱ��", new string[] { "����", "˲��,�ɼ�\n����֮��", "����֮��" }, medicSpawnRate);
            medicShowAttemptToMedic = CustomOption.Create(146, Types.Crewmate, "ҽ���ɼ�����������ܵ��Ļ�ɱ����", false, medicSpawnRate);

            swapperSpawnRate = CustomOption.Create(150, Types.Crewmate, cs(Swapper.color, "��Ʊʦ"), rates, null, true);
            swapperCanCallEmergency = CustomOption.Create(151, Types.Crewmate, "��Ʊʦ�����ٿ���������", false, swapperSpawnRate);
            swapperCanOnlySwapOthers = CustomOption.Create(152, Types.Crewmate, "��Ʊʦ�����Խ�������ͶƱ", false, swapperSpawnRate);

            swapperSwapsNumber = CustomOption.Create(153, Types.Crewmate, "��ʼ��Ʊ����", 1f, 0f, 5f, 1f, swapperSpawnRate);
            swapperRechargeTasksNumber = CustomOption.Create(154, Types.Crewmate, "��ɶ�������ɳ���һ�λ�Ʊ����", 2f, 1f, 10f, 1f, swapperSpawnRate);


            seerSpawnRate = CustomOption.Create(160, Types.Crewmate, cs(Seer.color, "��ý"), rates, null, true);
            seerMode = CustomOption.Create(161, Types.Crewmate, "��ýģʽ", new string[] { "��ʾ�������� + ���", "��ʾ��������", "չʾ���" }, seerSpawnRate);
            seerLimitSoulDuration = CustomOption.Create(163, Types.Crewmate, "������ý�Ŀɼ����ʱ��", false, seerSpawnRate);
            seerSoulDuration = CustomOption.Create(162, Types.Crewmate, "��ý�ɼ����ʱ��", 15f, 0f, 120f, 5f, seerLimitSoulDuration);

            hackerSpawnRate = CustomOption.Create(170, Types.Crewmate, cs(Hacker.color, "�ڿ�"), rates, null, true);
            hackerCooldown = CustomOption.Create(171, Types.Crewmate, "������ȴ", 30f, 5f, 60f, 5f, hackerSpawnRate);
            hackerHackeringDuration = CustomOption.Create(172, Types.Crewmate, "�������ʱ��", 10f, 2.5f, 60f, 2.5f, hackerSpawnRate);
            hackerOnlyColorType = CustomOption.Create(173, Types.Crewmate, "�ڿ�ֻ�ܿ�����ɫ����", false, hackerSpawnRate);
            hackerToolsNumber = CustomOption.Create(174, Types.Crewmate, "�����ƶ�����ʹ�õ���", 5f, 1f, 30f, 1f, hackerSpawnRate);
            hackerRechargeTasksNumber = CustomOption.Create(175, Types.Crewmate, "��������������", 2f, 1f, 5f, 1f, hackerSpawnRate);
            hackerNoMove = CustomOption.Create(176, Types.Crewmate, "���ƶ����߳���ʱ���ڲ����ƶ�", true, hackerSpawnRate);

            trackerSpawnRate = CustomOption.Create(200, Types.Crewmate, cs(Tracker.color, "׷����"), rates, null, true);
            trackerUpdateIntervall = CustomOption.Create(201, Types.Crewmate, "׷�ٸ��¼��", 5f, 1f, 30f, 1f, trackerSpawnRate);
            trackerResetTargetAfterMeeting = CustomOption.Create(202, Types.Crewmate, "׷�����ڻ��������Ŀ��", false, trackerSpawnRate);
            trackerCanTrackCorpses = CustomOption.Create(203, Types.Crewmate, "׷���߿���׷��ʬ��", true, trackerSpawnRate);
            trackerCorpsesTrackingCooldown = CustomOption.Create(204, Types.Crewmate, "ʬ��׷����ȴʱ��", 30f, 5f, 120f, 5f, trackerCanTrackCorpses);
            trackerCorpsesTrackingDuration = CustomOption.Create(205, Types.Crewmate, "ʬ��׷�ٳ���ʱ��", 5f, 2.5f, 30f, 2.5f, trackerCanTrackCorpses);

            snitchSpawnRate = CustomOption.Create(210, Types.Crewmate, cs(Snitch.color, "������"), rates, null, true);
            snitchLeftTasksForReveal = CustomOption.Create(211, Types.Crewmate, "�����߱�¶������", 1f, 0f, 5f, 1f, snitchSpawnRate);
            snitchIncludeTeamJackal = CustomOption.Create(212, Types.Crewmate, "���������Ŷ�", false, snitchSpawnRate);
            snitchTeamJackalUseDifferentArrowColor = CustomOption.Create(213, Types.Crewmate, "Ϊ�����Ŷ�ʹ�ò�ͬ�ļ�ͷ��ɫ", true, snitchIncludeTeamJackal);

            spySpawnRate = CustomOption.Create(240, Types.Crewmate, cs(Spy.color, "�Ե�"), rates, null, true);
            spyCanDieToSheriff = CustomOption.Create(241, Types.Crewmate, "�Ե׿ɱ�������ɱ", false, spySpawnRate);
            spyImpostorsCanKillAnyone = CustomOption.Create(242, Types.Crewmate, "�����Ե�ʱ�ڹ�ɻ�ɱ������", true, spySpawnRate);
            spyCanEnterVents = CustomOption.Create(243, Types.Crewmate, "�Ե׿������", false, spySpawnRate);
            spyHasImpostorVision = CustomOption.Create(244, Types.Crewmate, "�Ե����ڹ���Ұ", false, spySpawnRate);

            portalmakerSpawnRate = CustomOption.Create(390, Types.Crewmate, cs(Portalmaker.color, "������������"), rates, null, true);
            portalmakerCooldown = CustomOption.Create(391, Types.Crewmate, "��������������ȴ", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerUsePortalCooldown = CustomOption.Create(392, Types.Crewmate, "������ʹ����ȴ", 30f, 10f, 60f, 2.5f, portalmakerSpawnRate);
            portalmakerLogOnlyColorType = CustomOption.Create(393, Types.Crewmate, "��������������־ֻ��ʾ��ɫ����", true, portalmakerSpawnRate);
            portalmakerLogHasTime = CustomOption.Create(394, Types.Crewmate, "��־չʾʱ��", true, portalmakerSpawnRate);
            securityGuardSpawnRate = CustomOption.Create(280, Types.Crewmate, cs(SecurityGuard.color, "����"), rates, null, true);
            securityGuardCooldown = CustomOption.Create(281, Types.Crewmate, "������ȴ", 30f, 10f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardTotalScrews = CustomOption.Create(282, Types.Crewmate, "������������", 7f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamPrice = CustomOption.Create(283, Types.Crewmate, "���ü��ʹ�õĶ�������", 2f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardVentPrice = CustomOption.Create(284, Types.Crewmate, "���ͨ���ʹ�õĶ�������", 1f, 1f, 15f, 1f, securityGuardSpawnRate);
            securityGuardCamDuration = CustomOption.Create(285, Types.Crewmate, "����ʹ�ü���ʱ��", 10f, 2.5f, 60f, 2.5f, securityGuardSpawnRate);
            securityGuardCamMaxCharges = CustomOption.Create(286, Types.Crewmate, "��˿����󲹳�����", 5f, 1f, 30f, 1f, securityGuardSpawnRate);
            securityGuardCamRechargeTasksNumber = CustomOption.Create(287, Types.Crewmate, "������˿����Ҫ����������", 3f, 1f, 10f, 1f, securityGuardSpawnRate);
            securityGuardNoMove = CustomOption.Create(288, Types.Crewmate, "������������ͷʱ��ͣ��ʱ��", true, securityGuardSpawnRate);

            mediumSpawnRate = CustomOption.Create(360, Types.Crewmate, cs(Medium.color, "ͨ��ʦ"), rates, null, true);
            mediumCooldown = CustomOption.Create(361, Types.Crewmate, "ͨ��ʦͨ����ȴʱ��", 30f, 5f, 120f, 5f, mediumSpawnRate);
            mediumDuration = CustomOption.Create(362, Types.Crewmate, "ͨ��ʦͨ������ʱ��", 3f, 0f, 15f, 1f, mediumSpawnRate);
            mediumOneTimeUse = CustomOption.Create(363, Types.Crewmate, "ÿ�����ֻ�ܱ���һ��", false, mediumSpawnRate);

            bodyGuardSpawnRate = CustomOption.Create(8820, Types.Crewmate, cs(BodyGuard.color, "����"), rates, null, true);
            bodyGuardResetTargetAfterMeeting = CustomOption.Create(8821, Types.Crewmate, "�ڻ��������Ŀ��", true, bodyGuardSpawnRate);



            thiefSpawnRate = CustomOption.Create(400, Types.Neutral, cs(Thief.color, "����"), rates, null, true);
            thiefCooldown = CustomOption.Create(401, Types.Neutral, "͵����ȴʱ��", 30f, 5f, 120f, 5f, thiefSpawnRate);
            thiefCanKillSheriff = CustomOption.Create(402, Types.Neutral, "�������Ի�ɱ����", true, thiefSpawnRate);
            thiefHasImpVision = CustomOption.Create(403, Types.Neutral, "����ӵ���ڹ���Ұ", true, thiefSpawnRate);
            thiefCanUseVents = CustomOption.Create(404, Types.Neutral, "��������ʹ�ùܵ�", true, thiefSpawnRate);

            trapperSpawnRate = CustomOption.Create(410, Types.Crewmate, cs(Trapper.color, "����ʦ"), rates, null, true);
            trapperCooldown = CustomOption.Create(420, Types.Crewmate, "����������ȴʱ��", 30f, 5f, 120f, 5f, trapperSpawnRate);
            trapperMaxCharges = CustomOption.Create(440, Types.Crewmate, "���������", 5f, 1f, 15f, 1f, trapperSpawnRate);
            trapperRechargeTasksNumber = CustomOption.Create(450, Types.Crewmate, "�������������", 2f, 1f, 15f, 1f, trapperSpawnRate);
            trapperTrapNeededTriggerToReveal = CustomOption.Create(451, Types.Crewmate, "������Ҫ���������Ҵ�", 3f, 2f, 10f, 1f, trapperSpawnRate);
            trapperAnonymousMap = CustomOption.Create(452, Types.Crewmate, "��ʾ������ͼ", false, trapperSpawnRate);
            trapperInfoType = CustomOption.Create(453, Types.Crewmate, "������Ϣ����", new string[] { "ְҵ", "��/�� ְҵ", "����" }, trapperSpawnRate);
            trapperTrapDuration = CustomOption.Create(454, Types.Crewmate, "�������ʱ��", 5f, 1f, 15f, 1f, trapperSpawnRate);

            // Modifier (1000 - 1999)
            modifiersAreHidden = CustomOption.Create(1009, Types.Modifier, cs(Color.yellow, "��������Ч��"), true, null, true);



            modifierBloody = CustomOption.Create(1000, Types.Modifier, cs(Color.yellow, "��Ѫ��"), rates, null, true);
            modifierBloodyQuantity = CustomOption.Create(1001, Types.Modifier, cs(Color.yellow, "��Ѫ����"), ratesModifier, modifierBloody);
            modifierBloodyDuration = CustomOption.Create(1002, Types.Modifier, "·��ʱ��", 10f, 3f, 60f, 1f, modifierBloody);

            modifierAntiTeleport = CustomOption.Create(1010, Types.Modifier, cs(Color.yellow, "ͨѶ��"), rates, null, true);
            modifierAntiTeleportQuantity = CustomOption.Create(1011, Types.Modifier, cs(Color.yellow, "ͨѶ������"), ratesModifier, modifierAntiTeleport);

            modifierTieBreaker = CustomOption.Create(1020, Types.Modifier, cs(Color.yellow, "��ƽ��"), rates, null, true);

            modifierBait = CustomOption.Create(1030, Types.Modifier, cs(Color.yellow, "�ն�"), rates, null, true);
            modifierBaitQuantity = CustomOption.Create(1031, Types.Modifier, cs(Color.yellow, "�ն�����"), ratesModifier, modifierBait);
            modifierBaitReportDelayMin = CustomOption.Create(1032, Types.Modifier, "�ն�������С�ӳ�ʱ��", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitReportDelayMax = CustomOption.Create(1033, Types.Modifier, "�ն���������ӳ�ʱ��", 0f, 0f, 10f, 1f, modifierBait);
            modifierBaitShowKillFlash = CustomOption.Create(1034, Types.Modifier, "�����⾯��ɱ��", true, modifierBait);

            modifierLover = CustomOption.Create(1040, Types.Modifier, cs(Color.yellow, "����"), rates, null, true);
            modifierLoverImpLoverRate = CustomOption.Create(1041, Types.Modifier, "һ���������ڹ�ļ���", rates, modifierLover);
            modifierLoverBothDie = CustomOption.Create(1042, Types.Modifier, "���˹���", true, modifierLover);
            modifierLoverEnableChat = CustomOption.Create(1043, Types.Modifier, "��������˽��", true, modifierLover);

            modifierSunglasses = CustomOption.Create(1050, Types.Modifier, cs(Color.yellow, "̫����"), rates, null, true);
            modifierSunglassesQuantity = CustomOption.Create(1051, Types.Modifier, cs(Color.yellow, "̫��������"), ratesModifier, modifierSunglasses);
            modifierSunglassesVision = CustomOption.Create(1052, Types.Modifier, "̫��������Ұ", new string[] { "-10%", "-20%", "-30%", "-40%", "-50%" }, modifierSunglasses);

            modifierMini = CustomOption.Create(1061, Types.Modifier, cs(Color.yellow, "���㴬Ա"), rates, null, true);
            modifierMiniGrowingUpDuration = CustomOption.Create(1062, Types.Modifier, "���㴬Ա����ʱ��", 400f, 100f, 1500f, 100f, modifierMini);
            modifierMiniGrowingUpInMeeting = CustomOption.Create(1063, Types.Modifier, "���㴬Ա�ڻ����г���", true, modifierMini);

            modifierIndomitable = CustomOption.Create(1276, Types.Modifier, cs(Color.yellow, "���Ĺ�"), rates, null, true);

            modifierBlind = CustomOption.Create(8810, Types.Modifier, cs(Color.yellow, "��С��"), rates, null, true);
            modifierTunneler = CustomOption.Create(8819, Types.Modifier, cs(Color.yellow, "�����"), rates, null, true);
            modifierSlueth = CustomOption.Create(8830, Types.Modifier, cs(Color.yellow, "��Ĺ��"), rates, null, true);
            modifierCursed = CustomOption.Create(1277, Types.Modifier, cs(Color.yellow, "����"), rates, null, true);

            modifierVip = CustomOption.Create(1070, Types.Modifier, cs(Color.yellow, "VIP"), rates, null, true);
            modifierVipQuantity = CustomOption.Create(1071, Types.Modifier, cs(Color.yellow, "VIP����"), ratesModifier, modifierVip);
            modifierVipShowColor = CustomOption.Create(1072, Types.Modifier, "չʾ��Ӫ��ɫ", true, modifierVip);

            modifierInvert = CustomOption.Create(1080, Types.Modifier, cs(Color.yellow, "���"), rates, null, true);
            modifierInvertQuantity = CustomOption.Create(1081, Types.Modifier, cs(Color.yellow, "Ч������"), ratesModifier, modifierInvert);
            modifierInvertDuration = CustomOption.Create(1082, Types.Modifier, "�ߵ��Ļ������", 3f, 1f, 15f, 1f, modifierInvert);

            modifierChameleon = CustomOption.Create(1090, Types.Modifier, cs(Color.yellow, "��ɫ��"), rates, null, true);
            modifierChameleonQuantity = CustomOption.Create(1091, Types.Modifier, cs(Color.yellow, "��ɫ������"), ratesModifier, modifierChameleon);
            modifierChameleonHoldDuration = CustomOption.Create(1092, Types.Modifier, "��ɫ��ʼ��ʱ��", 3f, 1f, 10f, 0.5f, modifierChameleon);
            modifierChameleonFadeDuration = CustomOption.Create(1093, Types.Modifier, "��ɫ����ʱ��", 1f, 0.25f, 10f, 0.25f, modifierChameleon);
            modifierChameleonMinVisibility = CustomOption.Create(1094, Types.Modifier, "�����Ұ", new string[] { "0%", "10%", "20%", "30%", "40%", "50%" }, modifierChameleon);

            modifierShifter = CustomOption.Create(1100, Types.Modifier, cs(Color.yellow, "����ʦ"), rates, null, true);

            // Guesser Gamemode (2000 - 2999)
            guesserGamemodeCrewNumber = CustomOption.Create(2001, Types.Guesser, cs(Guesser.color, "��Ա�Ĺ�����"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeNeutralNumber = CustomOption.Create(2002, Types.Guesser, cs(Guesser.color, "�����Ĺ�����"), 15f, 1f, 15f, 1f, null, true);
            guesserGamemodeImpNumber = CustomOption.Create(2003, Types.Guesser, cs(Guesser.color, "�ڹ�Ĺ�����"), 15f, 1f, 15f, 1f, null, true);
            guesserForceJackalGuesser = CustomOption.Create(2007, Types.Guesser, "����ǿ��Ϊ�Ĺ�", false, null, true);
            guesserGamemodeHaveModifier = CustomOption.Create(2004, Types.Guesser, "�Ĺֿ���ӵ�и���ְҵ", true, null);
            guesserGamemodeNumberOfShots = CustomOption.Create(2005, Types.Guesser, "�Ĺֲ²���", 3f, 1f, 15f, 1f, null);
            guesserGamemodeHasMultipleShotsPerMeeting = CustomOption.Create(2006, Types.Guesser, "�Ĺ���һ�ֻ����пɶ�β²�", false, null);
            guesserGamemodeKillsThroughShield = CustomOption.Create(2008, Types.Guesser, "�Ĺ�����ҽ������", true, null);
            guesserGamemodeEvilCanKillSpy = CustomOption.Create(2009, Types.Guesser, "а��ĶĹֿ��Բ²��Ե�", true, null);
            guesserGamemodeCantGuessSnitchIfTaksDone = CustomOption.Create(2010, Types.Guesser, "�Ĺֲ����Բ²��������ĸ�����", true, null);

            // Hide N Seek Gamemode (3000 - 3999)
            hideNSeekMap = CustomOption.Create(3020, Types.HideNSeekMain, cs(Color.yellow, "��ͼ"), new string[] { "The Skeld", "Mira", "Polus", "Airship", "Submerged" }, null, true);
            hideNSeekHunterCount = CustomOption.Create(3000, Types.HideNSeekMain, cs(Color.yellow, "ɱ������"), 1f, 1f, 3f, 1f);
            hideNSeekKillCooldown = CustomOption.Create(3021, Types.HideNSeekMain, cs(Color.yellow, "��ɱ��ȴ"), 10f, 2.5f, 60f, 2.5f);
            hideNSeekHunterVision = CustomOption.Create(3001, Types.HideNSeekMain, cs(Color.yellow, "ɱ����ȴ"), 0.5f, 0.25f, 2f, 0.25f);
            hideNSeekHuntedVision = CustomOption.Create(3002, Types.HideNSeekMain, cs(Color.yellow, "�������Ұ"), 2f, 0.25f, 5f, 0.25f);
            hideNSeekCommonTasks = CustomOption.Create(3023, Types.HideNSeekMain, cs(Color.yellow, "��ͬ����"), 1f, 0f, 4f, 1f);
            hideNSeekShortTasks = CustomOption.Create(3024, Types.HideNSeekMain, cs(Color.yellow, "������"), 3f, 1f, 23f, 1f);
            hideNSeekLongTasks = CustomOption.Create(3025, Types.HideNSeekMain, cs(Color.yellow, "������"), 3f, 0f, 15f, 1f);
            hideNSeekTimer = CustomOption.Create(3003, Types.HideNSeekMain, cs(Color.yellow, "ʤ��������ʱ��"), 5f, 1f, 30f, 1f);
            hideNSeekTaskWin = CustomOption.Create(3004, Types.HideNSeekMain, cs(Color.yellow, "��������ʤ��"), false);
            hideNSeekTaskPunish = CustomOption.Create(3017, Types.HideNSeekMain, cs(Color.yellow, "�������ͷ�ʱ��"), 10f, 0f, 30f, 1f);
            hideNSeekCanSabotage = CustomOption.Create(3019, Types.HideNSeekMain, cs(Color.yellow, "�����ƻ�"), false);
            hideNSeekHunterWaiting = CustomOption.Create(3022, Types.HideNSeekMain, cs(Color.yellow, "ɱ����Ҫ�ȴ���ʱ��"), 15f, 2.5f, 60f, 2.5f);

            hunterLightCooldown = CustomOption.Create(3005, Types.HideNSeekRoles, cs(Color.red, "ɱ�������ȴʱ��"), 30f, 5f, 60f, 1f, null, true);
            hunterLightDuration = CustomOption.Create(3006, Types.HideNSeekRoles, cs(Color.red, "ɱ���������"), 5f, 1f, 60f, 1f);
            hunterLightVision = CustomOption.Create(3007, Types.HideNSeekRoles, cs(Color.red, "ɱ�������Ұ"), 3f, 1f, 5f, 0.25f);
            hunterLightPunish = CustomOption.Create(3008, Types.HideNSeekRoles, cs(Color.red, "ɱ����Ƶĵķ�ʱ"), 5f, 0f, 30f, 1f);
            hunterAdminCooldown = CustomOption.Create(3009, Types.HideNSeekRoles, cs(Color.red, "ɱ�ֹ���Ա��ȴ"), 30f, 5f, 60f, 1f);
            hunterAdminDuration = CustomOption.Create(3010, Types.HideNSeekRoles, cs(Color.red, "ɱ�ֹ���Ա����"), 5f, 1f, 60f, 1f);
            hunterAdminPunish = CustomOption.Create(3011, Types.HideNSeekRoles, cs(Color.red, "ɱ�ֹ���Ա�ķ�ʱ"), 5f, 0f, 30f, 1f);
            hunterArrowCooldown = CustomOption.Create(3012, Types.HideNSeekRoles, cs(Color.red, "ɱ�ּ�ͷ��ȴ"), 30f, 5f, 60f, 1f);
            hunterArrowDuration = CustomOption.Create(3013, Types.HideNSeekRoles, cs(Color.red, "ɱ�ּ�ͷ����"), 5f, 0f, 60f, 1f);
            hunterArrowPunish = CustomOption.Create(3014, Types.HideNSeekRoles, cs(Color.red, "ɱ�ּ�ͷ��ʱ"), 5f, 0f, 30f, 1f);

            huntedShieldCooldown = CustomOption.Create(3015, Types.HideNSeekRoles, cs(Color.gray, "����߻�����ȴ"), 30f, 5f, 60f, 1f, null, true);
            huntedShieldDuration = CustomOption.Create(3016, Types.HideNSeekRoles, cs(Color.gray, "����߻�������"), 5f, 1f, 60f, 1f);
            huntedShieldRewindTime = CustomOption.Create(3018, Types.HideNSeekRoles, cs(Color.gray, "����ߵ���ʱ��"), 3f, 1f, 10f, 1f);
            huntedShieldNumber = CustomOption.Create(3026, Types.HideNSeekRoles, cs(Color.gray, "����߻�������"), 3f, 1f, 15f, 1f);

            // Other options
            maxNumberOfMeetings = CustomOption.Create(3, Types.General, "���������������г����飩", 10, 0, 15, 1, null, true);
            blockSkippingInEmergencyMeetings = CustomOption.Create(4, Types.General, "���������е�����", false);
            noVoteIsSelfVote = CustomOption.Create(5, Types.General, "��ͶƱ��Ϊ��Ͷ", false, blockSkippingInEmergencyMeetings);
            hidePlayerNames = CustomOption.Create(6, Types.General, "�����������", false);
            allowParallelMedBayScans = CustomOption.Create(7, Types.General, "�������ɨ��", false);
            shieldFirstKill = CustomOption.Create(8, Types.General, "���Ͼֱ��׵����˶�", false);

            dynamicMap = CustomOption.Create(500, Types.General, "���������ͼ", false, null, false);
            dynamicMapEnableSkeld = CustomOption.Create(501, Types.General, "����Skeld", true, dynamicMap, false);
            dynamicMapEnableMira = CustomOption.Create(502, Types.General, "����Mira", true, dynamicMap, false);
            dynamicMapEnablePolus = CustomOption.Create(503, Types.General, "����Polus", true, dynamicMap, false);
            dynamicMapEnableAirShip = CustomOption.Create(504, Types.General, "����Airship", true, dynamicMap, false);
            dynamicMapEnableSubmerged = CustomOption.Create(505, Types.General, "����Ǳͧ��ͼ", true, dynamicMap, false);
            enableBetterPolus = CustomOption.Create(7878, Types.General, "�������õ�Polus", false, null, false);
            movePolusVents = CustomOption.Create(7879, Types.General, "�����ܵ�", false, enableBetterPolus, false);
            movePolusVitals = CustomOption.Create(7880, Types.General, "�ƶ���������ǵ�ʵ����", false, enableBetterPolus, false);
			swapNavWifi = CustomOption.Create(7881, Types.General, "��������Wifi���ȶ�����", false, enableBetterPolus, false);
			moveColdTemp = CustomOption.Create(7882, Types.General, "�����ȳ̶ȼ�����ƶ���������", false, enableBetterPolus, false);



	enableCamoComms = CustomOption.Create(1105, Types.General, "�����ƻ�ͨѶʱ����", false,  null, false);

            restrictDevices = CustomOption.Create(1101, Types.General, "�޶���ͼ��Ϣ", new string[] { "��", "ÿ�غ�", "ÿ����Ϸ" }, null, false);
            restrictAdmin = CustomOption.Create(1102, Types.General, "���ƹ����ͼ", 30f, 0f, 600f, 5f, restrictDevices);
            restrictCameras = CustomOption.Create(1103, Types.General, "��������ͷ", 30f, 0f, 600f, 5f, restrictDevices);
            restrictVents = CustomOption.Create(1104, Types.General, "�����������", 30f, 0f, 600f, 5f, restrictDevices);


            showButtonTarget = CustomOption.Create(9994, Types.General, "��ʾ��ťĿ��", true);
            blockGameEnd = CustomOption.Create(9995, Types.General, "��ֹ�ڳ��ܴ�Ա����ʱ��Ϸ����", false);


            randomGameStartPosition = CustomOption.Create(9041, Types.General, "��������ص�", false);
            allowModGuess = CustomOption.Create(9043, Types.General, "����²�Ч��", false);
            resetRoundStartCooldown = CustomOption.Create(9042, Types.General, "����������ȴ", false);

            blockedRolePairings.Add((byte)RoleId.Vampire, new [] { (byte)RoleId.Warlock});
            blockedRolePairings.Add((byte)RoleId.Warlock, new [] { (byte)RoleId.Vampire});
            blockedRolePairings.Add((byte)RoleId.Spy, new [] { (byte)RoleId.Mini});
            blockedRolePairings.Add((byte)RoleId.Mini, new [] { (byte)RoleId.Spy});
            blockedRolePairings.Add((byte)RoleId.Vulture, new [] { (byte)RoleId.Cleaner});
            blockedRolePairings.Add((byte)RoleId.Cleaner, new [] { (byte)RoleId.Vulture});

			// Prosecutor
			blockedRolePairings.Add((byte)RoleId.Lawyer, new[] { (byte)RoleId.Prosecutor });
            blockedRolePairings.Add((byte)RoleId.Prosecutor, new[] { (byte)RoleId.Lawyer });            
        }
    }
}
