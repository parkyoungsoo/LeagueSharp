﻿namespace Valvrave_Sharp.Evade
{
    using LeagueSharp;
    using LeagueSharp.SDK.Core.Enumerations;

    public class SpellData
    {
        #region Fields

        public bool AddHitbox;

        public bool CanBeRemoved = false;

        public bool Centered;

        public string ChampionName;

        public CollisionableObjects[] CollisionObjects = { };

        public int DangerValue;

        public int Delay;

        public bool DisabledByDefault = false;

        public bool DisableFowDetection = false;

        public bool DontAddExtraDuration;

        public bool DontCheckForDuplicates = false;

        public bool DontCross = false;

        public bool DontRemove = false;

        public int ExtraDuration;

        public string[] ExtraMissileNames = { };

        public int ExtraRange = -1;

        public string[] ExtraSpellNames = { };

        public bool FixedRange;

        public bool FollowCaster = false;

        public bool ForceRemove = false;

        public string FromObject = "";

        public string[] FromObjects = { };

        public bool Invert;

        public bool IsDangerous = false;

        public int MissileAccel = 0;

        public bool MissileDelayed;

        public bool MissileFollowsUnit;

        public int MissileMaxSpeed;

        public int MissileMinSpeed;

        public int MissileSpeed;

        public string MissileSpellName = "";

        public float MultipleAngle;

        public int MultipleNumber = -1;

        public int RingRadius;

        public SpellSlot Slot;

        public string SourceObjectName = "";

        public string SpellName;

        public bool TakeClosestPath = false;

        public string ToggleParticleName = "";

        public SkillShotType Type;

        #endregion

        #region Public Properties

        public int Radius
        {
            get
            {
                return (!this.AddHitbox)
                           ? this.RawRadius + Config.SkillShotsExtraRadius
                           : Config.SkillShotsExtraRadius + this.RawRadius + (int)ObjectManager.Player.BoundingRadius;
            }
            set
            {
                this.RawRadius = value;
            }
        }

        public int Range
        {
            get
            {
                return this.RawRange
                       + (this.Type == SkillShotType.SkillshotLine || this.Type == SkillShotType.SkillshotMissileLine
                              ? Config.SkillShotsExtraRange
                              : 0);
            }
            set
            {
                this.RawRange = value;
            }
        }

        public int RawRadius { get; private set; }

        public int RawRange { get; private set; }

        #endregion
    }
}