﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using Kitchen;
using KitchenData;
using KitchenLib;
using KitchenLib.Event;
using KitchenLib.Preferences;
using KitchenLib.Utils;
using KitchenMods;
using TMPro;
using UnityEngine;
using KitchenJacketPotatoes.Mains;

namespace KitchenJacketPotatoes;

public class Mod : BaseMod
{
	public const string MOD_GUID = "Willl.PlateUp.JacketPotatoes";

	public const string MOD_NAME = "Jacket Potatoes";

	public const string MOD_VERSION = "0.0.1";

	public const string MOD_AUTHOR = "Willl";

	public const string MOD_GAMEVERSION = ">=1.0.0";

	public const bool DEBUG_MODE = false;

	internal static AssetBundle Bundle;

	public Mod() : base(MOD_GUID, MOD_NAME, MOD_AUTHOR, MOD_VERSION, MOD_GAMEVERSION, Assembly.GetExecutingAssembly())
	{
	}

	protected override void OnInitialise()
	{
		LogWarning("Willl.PlateUp.JacketPotatoes v0.0.1 in use!");
	}

	private void AddGameData()
	{
		LogInfo("Attempting to register game data...");
		//((BaseMod)this).AddGameDataObject<AmericanBreakfastDish>();
		((BaseMod)this).AddGameDataObject<BakingPotato>();
		((BaseMod)this).AddGameDataObject<BakingPotatoProvider>();
		((BaseMod)this).AddGameDataObject<JacketPotatoesDish>();
		LogInfo("Done loading game data. Hopefully?");
	}

    protected override void OnPostActivate(KitchenMods.Mod mod)
    {
		Bundle = mod.GetPacks<AssetBundleModPack>().SelectMany(e => e.AssetBundles).FirstOrDefault();

		AddGameData();
    }


	public static void LogInfo(string _log)
	{
		Debug.Log("[Jacket Potatoes] " + _log);
	}

	public static void LogWarning(string _log)
	{
		Debug.LogWarning("[Jacket Potatoes] " + _log);
	}

	public static void LogError(string _log)
	{
		Debug.LogError("[Jacket Potatoes] " + _log);
	}

	public static void LogInfo(object _log)
	{
		LogInfo(_log.ToString());
	}

	public static void LogWarning(object _log)
	{
		LogWarning(_log.ToString());
	}

	public static void LogError(object _log)
	{
		LogError(_log.ToString());
	}
}


