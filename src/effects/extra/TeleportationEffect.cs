﻿using GTA_SA_Chaos.util;
using System;

namespace GTA_SA_Chaos.effects
{
    public class TeleportationEffect : AbstractEffect
    {
        private readonly Location location;

        public TeleportationEffect(string description, string word, Location _location)
            : base(Category.Teleportation, description, word)
        {
            location = _location;
        }

        public override void RunEffect()
        {
            StoreEffectToFile();

            ProcessHooker.NewThreadStartClient("teleport");
            ProcessHooker.NewThreadStartClient(location.ToString());
        }
    }
}