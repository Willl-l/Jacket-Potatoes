﻿using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenJacketPotatoes.Mains
{
    internal class JacketPotatoesDish : CustomDish
    {
        public override string UniqueNameID => "Jacket Potatoes Dish";

        public override DishType Type => DishType.Base;

        public override DishCustomerChange CustomerMultiplier => DishCustomerChange.None;

        public override CardType CardType => CardType.Default;

        public override Unlock.RewardLevel ExpReward => Unlock.RewardLevel.Large;
        public override UnlockGroup UnlockGroup => UnlockGroup.Dish;

        public override bool IsSpecificFranchiseTier => false;

        public override bool DestroyAfterModUninstall => false;

        public override bool IsUnlockable => true;

        public override bool IsAvailableAsLobbyOption => true;

        public override int Difficulty => 2;

        public override List<string> StartingNameSet => new List<string> { "Spud Bros", "Spud Man", "Tater Town", "Hot Potatoe" };

        public override List<Dish.MenuItem> ResultingMenuItems => new List<Dish.MenuItem>
    {
        new Dish.MenuItem
        {
            Item = Refs.ButterSlice,
            Phase = MenuPhase.Main,
            Weight = 1f,
        }
    };

        public override HashSet<Item> MinimumIngredients => new HashSet<Item>
    {
        Refs.Butter,
        Refs.Potato,
    };

        public override HashSet<Process> RequiredProcesses => new HashSet<Process>
    {
        Refs.Oven,
        Refs.Chop
    };

        public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string> {
    {
        Locale.English,
        "Cook Potato, Slice Butter, portion and add to potato. Then add other toppings"
    } };



    }
}
