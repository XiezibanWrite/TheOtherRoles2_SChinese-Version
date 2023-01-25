using System.Linq;
using System;
using System.Collections.Generic;
using TheOtherRoles.Players;
using static TheOtherRoles.TheOtherRoles;
using UnityEngine;

namespace TheOtherRoles
{
    class RoleInfo {
        public Color color;
        public string name;
        public string introDescription;
        public string shortDescription;
        public RoleId roleId;
        public bool isNeutral;
		public bool isGuessable;
        public bool isModifier;

        RoleInfo(string name, Color color, string introDescription, string shortDescription, RoleId roleId, bool isNeutral = false, bool isModifier = false, bool isGuessable = false) {
            this.color = color;
            this.name = name;
            this.introDescription = introDescription;
            this.shortDescription = shortDescription;
            this.roleId = roleId;
            this.isNeutral = isNeutral;
            this.isModifier = isModifier;
			this.isGuessable = isGuessable;
        }

        public static RoleInfo jester = new RoleInfo("小丑", Jester.color, "想办法被投出去", "想办法被投出去", RoleId.Jester, true);
        public static RoleInfo werewolf = new RoleInfo("狼人", Werewolf.color, "横冲直撞，杀死所有人", "横冲直撞，杀死所有人", RoleId.Werewolf, true);
        public static RoleInfo prosecutor = new RoleInfo("处决者", Prosecutor.color, "投出你的目标", "投出你的目标", RoleId.Prosecutor, true);
        public static RoleInfo swooper = new RoleInfo("隐形人", Swooper.color, "隐形并杀死所有人", "隐形", RoleId.Swooper, true);
        public static RoleInfo mayor = new RoleInfo("市长", Mayor.color, "你的投票算作两票", "你的投票算作两票", RoleId.Mayor);
        public static RoleInfo portalmaker = new RoleInfo("传送门制造商", Portalmaker.color, "你可以新建传送门", "你可以新建传送门", RoleId.Portalmaker);
        public static RoleInfo engineer = new RoleInfo("工程师", Engineer.color, "修理船上的破坏", "修理破坏", RoleId.Engineer);
        public static RoleInfo sheriff = new RoleInfo("警长", Sheriff.color, "杀死 <color=#FF1919FF>内鬼</color>", "杀死内鬼", RoleId.Sheriff);
        public static RoleInfo bodyguard = new RoleInfo("保镖", BodyGuard.color, "用自己的生命保护他人", "你是守卫它人的盾牌!", RoleId.BodyGuard, false);
        public static RoleInfo deputy = new RoleInfo("捕快", Sheriff.color, "用手铐铐住 <color=#FF1919FF>内鬼</color>", "用手铐铐住内鬼", RoleId.Deputy);
        public static RoleInfo lighter = new RoleInfo("执灯人", Lighter.color, "你的灯光永不熄灭", "Your light never goes out", RoleId.Lighter);
        public static RoleInfo godfather = new RoleInfo("教父(黑手党)", Godfather.color, "杀死全部船员", "杀死全部船员", RoleId.Godfather);
        public static RoleInfo mafioso = new RoleInfo("小弟(黑手党)", Mafioso.color, "帮助 <color=#FF1919FF>黑手党</color>杀死全部船员", "杀死全部船员", RoleId.Mafioso);
        public static RoleInfo janitor = new RoleInfo("清洁工（黑手党)", Janitor.color, "帮助<color=#FF1919FF>黑手党</color>隐藏尸体", "隐藏尸体", RoleId.Janitor);
        public static RoleInfo morphling = new RoleInfo("化形者", Morphling.color, "改变你的外观以避免被识出", "改变你的外观", RoleId.Morphling);
        public static RoleInfo bomber = new RoleInfo("炸弹手", Bomber.color, "给玩家提供炸弹", "炸死所有人", RoleId.Bomber);
        public static RoleInfo camouflager = new RoleInfo("隐蔽者", Camouflager.color, "隐蔽并杀死船员们", "隐藏在其他人之中", RoleId.Camouflager);
        public static RoleInfo miner = new RoleInfo("管道工", Miner.color, "新建新的管道", "创建管道", RoleId.Miner);
        public static RoleInfo vampire = new RoleInfo("吸血鬼", Vampire.color, "用你的牙杀死船员们", "咬死你的敌人", RoleId.Vampire);
        public static RoleInfo eraser = new RoleInfo("抹除者", Eraser.color, "杀死船员并抹除他们的角色", "抹去你的敌人的职业", RoleId.Eraser);
        public static RoleInfo trickster = new RoleInfo("骗术师", Trickster.color, "用你的盒子给别人带来惊喜", "给你的目标惊喜", RoleId.Trickster);
        public static RoleInfo cleaner = new RoleInfo("清理者", Cleaner.color, "杀光所有人，不留痕迹", "清理尸体", RoleId.Cleaner);
        public static RoleInfo undertaker = new RoleInfo("送葬者", Undertaker.color, "杀光所有人，不留痕迹", "拖动尸体并隐藏起来", RoleId.Undertaker);
        public static RoleInfo warlock = new RoleInfo("术士", Warlock.color, "诅咒其他玩家并杀死所有人", "诅咒并杀死所有人", RoleId.Warlock);
        public static RoleInfo bountyHunter = new RoleInfo("赏金猎人", BountyHunter.color, "追杀你的赏金目标", "追杀你的赏金目标", RoleId.BountyHunter);
        public static RoleInfo detective = new RoleInfo("侦探", Detective.color, "通过脚印找到<color=#FF1919FF>内鬼</color>", "检查脚印", RoleId.Detective);
        public static RoleInfo timeMaster = new RoleInfo("时间之主", TimeMaster.color, "用你的时间之盾拯救你自己", "使用你的时间之盾", RoleId.TimeMaster);
        public static RoleInfo veteren = new RoleInfo("老兵", Veteren.color, "保护自己免受伤害", "保护自己免受伤害", RoleId.Veteren);
        public static RoleInfo medic = new RoleInfo("医生", Medic.color, "用你的盾牌保护别人", "保护其他玩家", RoleId.Medic);
        public static RoleInfo shifter = new RoleInfo("交换师", Shifter.color, "偷走他人的职业", "偷走他人的职业", RoleId.Shifter);
        public static RoleInfo swapper = new RoleInfo("换票师", Swapper.color, "通过换票投出<color=#FF1919FF>内鬼</color>", "交换投票", RoleId.Swapper);
        public static RoleInfo seer = new RoleInfo("灵媒", Seer.color, "你能预知死亡", "你能预知死亡", RoleId.Seer);
        public static RoleInfo hacker = new RoleInfo("黑客", Hacker.color, "黑入系统来发现<color=#FF1919FF>内鬼</color>", "黑入系统来发现内鬼", RoleId.Hacker);
        public static RoleInfo tracker = new RoleInfo("追踪者", Tracker.color, "追踪<color=#FF1919FF>内鬼</color>", "追踪内鬼", RoleId.Tracker);
        public static RoleInfo snitch = new RoleInfo("告密者", Snitch.color, "完成任务来找到<color=#FF1919FF>内鬼</color>", "完成你的任务", RoleId.Snitch);
        public static RoleInfo jackal = new RoleInfo("豺狼", Jackal.color, "杀死所有船员和<color=#FF1919FF>内鬼</color>来胜利", "杀死所有人", RoleId.Jackal, true);
        public static RoleInfo sidekick = new RoleInfo("跟班", Sidekick.color, "帮助豺狼杀死所有人", "帮助豺狼杀死所有人", RoleId.Sidekick, true);
        public static RoleInfo spy = new RoleInfo("卧底", Spy.color, "迷惑<color=#FF1919FF>内鬼</color>", "迷惑内鬼", RoleId.Spy);
        public static RoleInfo securityGuard = new RoleInfo("保安", SecurityGuard.color, "封锁管道和放置摄像头", "封锁管道和放置摄像头", RoleId.SecurityGuard);
        public static RoleInfo arsonist = new RoleInfo("纵火犯", Arsonist.color, "让他们燃烧(比博人传燃)", "让他们燃烧(比博人传燃)", RoleId.Arsonist, true);
        public static RoleInfo amnisiac = new RoleInfo("失忆者", Amnisiac.color, "从死者身上偷取角色", "你忘记了", RoleId.Amnisiac, true);
        public static RoleInfo vulture = new RoleInfo("秃鹫", Vulture.color, "靠吃尸体取胜", "吃尸体", RoleId.Vulture, true);
        public static RoleInfo medium = new RoleInfo("通灵师", Medium.color, "询问死者的灵魂以获得信息", "询问灵魂", RoleId.Medium);
        public static RoleInfo lawyer = new RoleInfo("律师", Lawyer.color, "给你的客户辩护", "给你的客户辩护", RoleId.Lawyer, true);
        public static RoleInfo pursuer = new RoleInfo("追捕者", Pursuer.color, "打掉内鬼", "打掉内鬼", RoleId.Pursuer);
        public static RoleInfo impostor = new RoleInfo("内鬼", Palette.ImpostorRed, Helpers.cs(Palette.ImpostorRed, "破坏并杀死所有人"), "破坏并杀死所有人", RoleId.Impostor);
        public static RoleInfo crewmate = new RoleInfo("船员", Color.white, "找到内鬼", "找到内鬼", RoleId.Crewmate);
        public static RoleInfo witch = new RoleInfo("女巫", Witch.color, "对你的敌人施放咒语", "对你的敌人施放咒语", RoleId.Witch);
        public static RoleInfo ninja = new RoleInfo("忍者", Ninja.color, "出其不意地刺杀你的敌人", "出其不意地刺杀你的敌人", RoleId.Ninja);
        public static RoleInfo blackmailer = new RoleInfo("勒索者", Blackmailer.color, "敲诈那些试图伤害你的人", "敲诈那些试图伤害你的人", RoleId.Blackmailer);


        // Modifier
        public static RoleInfo bloody = new RoleInfo("溅血者", Color.yellow, "击杀你的凶手将会留下血迹", "击杀你的凶手将会留下血迹", RoleId.Bloody, false, true);
        public static RoleInfo antiTeleport = new RoleInfo("通讯兵", Color.yellow, "你不会被传送", "你不会被传送", RoleId.AntiTeleport, false, true);
        public static RoleInfo tiebreaker = new RoleInfo("破平者", Color.yellow, "你的投票打破了平局", "打破平局", RoleId.Tiebreaker, false, true);
        public static RoleInfo bait = new RoleInfo("诱饵", Color.yellow, "诱骗你的敌人", "诱骗你的敌人", RoleId.Bait, false, true);
        public static RoleInfo sunglasses = new RoleInfo("太阳镜", Color.yellow, "你得到了太阳镜", "你的视野下降", RoleId.Sunglasses, false, true);
        public static RoleInfo lover = new RoleInfo("恋人", Lovers.color, $"你坠入了爱河", $"你坠入了爱河", RoleId.Lover, false, true);
        public static RoleInfo mini = new RoleInfo("迷你", Color.yellow, "在你长大之前没有人能伤害你", "没有人能伤害你", RoleId.Mini, false, true);
        public static RoleInfo vip = new RoleInfo("VIP", Color.yellow, "你是VIP", "当你死亡时，每个人都会得到通知", RoleId.Vip, false, true);
        public static RoleInfo indomitable = new RoleInfo("反赌怪", Color.yellow, "你的角色不能被猜测", "你无法被猜测!", RoleId.Indomitable, false, true);
        public static RoleInfo slueth = new RoleInfo("掘墓者", Color.yellow, "了解你报告的尸体的角色", "谁的数据?", RoleId.Indomitable, false, true);
        public static RoleInfo cursed = new RoleInfo("反骨", Color.yellow, "你现在是船员", "发现你的真正潜力", RoleId.Cursed, false, true, true);
        public static RoleInfo invert = new RoleInfo("醉鬼", Color.yellow, "你的移动是颠倒的", "你的移动是颠倒的", RoleId.Invert, false, true);
        public static RoleInfo blind = new RoleInfo("盲人", Color.yellow, "你不能看见报告按键!", "那是一具尸体吗?", RoleId.Blind, false, true);
        public static RoleInfo tunneler = new RoleInfo("隧道工", Color.yellow, "完成你的任务，以获得钻管道的能力", "完成工作，你就可以玩了", RoleId.Tunneler, false, true);
        public static RoleInfo goodGuesser = new RoleInfo("正义的赌怪", Color.yellow, "猜测和射杀", "猜测和射杀", RoleId.NiceGuesser, false, true);
        public static RoleInfo badGuesser = new RoleInfo("邪恶的赌怪", Color.yellow, "猜测和射杀", "猜测和射杀", RoleId.EvilGuesser, false, true);



        public static List<RoleInfo> allRoleInfos = new List<RoleInfo>() {
            impostor,
            godfather,
            mafioso,
            janitor,
            morphling,
            bomber,
            camouflager,
            vampire,
            eraser,
            trickster,
            cleaner,
            undertaker,
            warlock,
            werewolf,
			cursed,
            bountyHunter,
            witch,
            ninja,
            bodyguard,
            blackmailer,
            miner,
			swooper,
            goodGuesser,
            badGuesser,
            lover,
            jester,
            prosecutor,
            arsonist,
            jackal,
            sidekick,
            vulture,
            pursuer,
            lawyer,
            crewmate,
            shifter,
            mayor,
            portalmaker,
            engineer,
            sheriff,
            deputy,
            lighter,
            detective,
            timeMaster,
            amnisiac,
            veteren,
            medic,
            swapper,
            seer,
            hacker,
            tracker,
            snitch,
            spy,
            securityGuard,
            bait,
            medium,
            bloody,
            antiTeleport,
            tiebreaker,
            sunglasses,
            mini,
            vip,
            indomitable,
            slueth,
            blind,
            tunneler,
            invert
        };

        public static List<RoleInfo> getRoleInfoForPlayer(PlayerControl p, bool showModifier = true, bool onlyMods = false) {
            List<RoleInfo> infos = new List<RoleInfo>();
            if (p == null) return infos;

            // Modifier
            if (showModifier) {
                // after dead modifier
                if (!CustomOptionHolder.modifiersAreHidden.getBool() || PlayerControl.LocalPlayer.Data.IsDead)
                {
                    if (Bait.bait.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bait);
                    if (Bloody.bloody.Any(x => x.PlayerId == p.PlayerId)) infos.Add(bloody);
                    if (Vip.vip.Any(x => x.PlayerId == p.PlayerId)) infos.Add(vip);
                    if (p == Tiebreaker.tiebreaker) infos.Add(tiebreaker);
                    if (p == Indomitable.indomitable) infos.Add(indomitable);
                }
                if (PlayerControl.LocalPlayer.Data.IsDead) {
                    if (p == Cursed.cursed) infos.Add(cursed);
                }
                if (p == Lovers.lover1 || p == Lovers.lover2) infos.Add(lover);
                if (AntiTeleport.antiTeleport.Any(x => x.PlayerId == p.PlayerId)) infos.Add(antiTeleport);
                if (Sunglasses.sunglasses.Any(x => x.PlayerId == p.PlayerId)) infos.Add(sunglasses);
                if (p == Mini.mini) infos.Add(mini);
                if (p == Blind.blind) infos.Add(blind);
                if (p == Tunneler.tunneler) infos.Add(tunneler);
                if (p == Slueth.slueth) infos.Add(slueth);
                if (Invert.invert.Any(x => x.PlayerId == p.PlayerId)) infos.Add(invert);
                if (p == Guesser.niceGuesser) infos.Add(goodGuesser);
                if (p == Guesser.evilGuesser) infos.Add(badGuesser);

            }
            if (onlyMods) return infos;

            // Special roles
            if (p == Jester.jester) infos.Add(jester);
            if (p == Werewolf.werewolf) infos.Add(werewolf);
            if (p == Prosecutor.prosecutor) infos.Add(prosecutor);
            if (p == Swooper.swooper) infos.Add(swooper);
            if (p == Mayor.mayor) infos.Add(mayor);
            if (p == Portalmaker.portalmaker) infos.Add(portalmaker);
            if (p == Engineer.engineer) infos.Add(engineer);
            if (p == Sheriff.sheriff || p == Sheriff.formerSheriff) infos.Add(sheriff);
            if (p == Deputy.deputy) infos.Add(deputy);
            if (p == Lighter.lighter) infos.Add(lighter);
            if (p == Godfather.godfather) infos.Add(godfather);
            if (p == Miner.miner) infos.Add(miner);
            if (p == Mafioso.mafioso) infos.Add(mafioso);
            if (p == Janitor.janitor) infos.Add(janitor);
            if (p == Morphling.morphling) infos.Add(morphling);
            if (p == Camouflager.camouflager) infos.Add(camouflager);
            if (p == Vampire.vampire) infos.Add(vampire);
            if (p == Eraser.eraser) infos.Add(eraser);
            if (p == Trickster.trickster) infos.Add(trickster);
            if (p == Cleaner.cleaner) infos.Add(cleaner);
            if (p == Undertaker.undertaker) infos.Add(undertaker);
            if (p == Bomber.bomber) infos.Add(bomber);
            if (p == Warlock.warlock) infos.Add(warlock);
            if (p == Witch.witch) infos.Add(witch);
            if (p == Ninja.ninja) infos.Add(ninja);
            if (p == Blackmailer.blackmailer) infos.Add(blackmailer);
            if (p == Detective.detective) infos.Add(detective);
            if (p == TimeMaster.timeMaster) infos.Add(timeMaster);
            if (p == Amnisiac.amnisiac) infos.Add(amnisiac);
            if (p == Veteren.veteren) infos.Add(veteren);
            if (p == Medic.medic) infos.Add(medic);
            if (p == Shifter.shifter) infos.Add(shifter);
            if (p == Swapper.swapper) infos.Add(swapper);
            if (p == BodyGuard.bodyguard) infos.Add(bodyguard);
            if (p == Seer.seer) infos.Add(seer);
            if (p == Hacker.hacker) infos.Add(hacker);
            if (p == Tracker.tracker) infos.Add(tracker);
            if (p == Snitch.snitch) infos.Add(snitch);
            if (p == Jackal.jackal || (Jackal.formerJackals != null && Jackal.formerJackals.Any(x => x.PlayerId == p.PlayerId))) {
                if (p == Jackal.jackal && Jackal.jackal != Swooper.swooper) infos.Add(jackal);
                else if (p != Jackal.jackal) infos.Add(jackal);
            }
            if (p == Sidekick.sidekick) infos.Add(sidekick);
            if (p == Spy.spy) infos.Add(spy);
            if (p == SecurityGuard.securityGuard) infos.Add(securityGuard);
            if (p == Arsonist.arsonist) infos.Add(arsonist);
            if (p == BountyHunter.bountyHunter) infos.Add(bountyHunter);
            if (p == Vulture.vulture) infos.Add(vulture);
            if (p == Medium.medium) infos.Add(medium);
            if (p == Lawyer.lawyer) infos.Add(lawyer);
            if (p == Pursuer.pursuer) infos.Add(pursuer);

            // Default roles
            if (infos.Count == 0 && p.Data.Role.IsImpostor) infos.Add(impostor); // Just Impostor
            if (infos.Count == 0 && !p.Data.Role.IsImpostor) infos.Add(crewmate); // Just Crewmate

            return infos;
        }

        public static String GetRolesString(PlayerControl p, bool useColors, bool showModifier = true) {
            string roleName;
            roleName = String.Join(" ", getRoleInfoForPlayer(p, showModifier).Select(x => useColors ? Helpers.cs(x.color, x.name) : x.name).ToArray());
            if (Lawyer.target != null && p.PlayerId == Lawyer.target.PlayerId && CachedPlayer.LocalPlayer.PlayerControl != Lawyer.target) roleName += (useColors ? Helpers.cs(Pursuer.color, " §") : " §");
            return roleName;
        }
    }
}

