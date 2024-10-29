using System;
using ApplianceLib.Api.References;
using IngredientLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;

namespace KitchenJacketPotatoes;

internal class Refs
{
	public static Item Plate => Find<Item>(ItemReferences.Plate);

	public static Item DirtyPlate => Find<Item>(ItemReferences.PlateDirty);

	public static Item Butter => Find<Item>(ItemReferences.Butter);

	public static Item Potato => Find<Item>(ItemReferences.Potato);

	public static Process Cook => Find<Process>(ProcessReferences.Cook);

	public static Process Chop => Find<Process>(ProcessReferences.Chop);

	public static Process Knead => Find<Process>(ProcessReferences.Knead);

	public static Process Oven => Find<Process>(ProcessReferences.RequireOven);

	public static Item SlicedButter => Find<Item>(References.GetIngredient("Sliced Butter"));
	public static Item ButterSlice => Find<Item>(References.GetIngredient("Butter Slice"));
	public static Item PlatedJacketPotato => Find<Item>(References.GetIngredient("PlatedJacketPotato"));

	internal static T Find<T>(int id) where T : GameDataObject
	{
		return ((T)GDOUtils.GetExistingGDO(id)) ?? ((T)(GDOUtils.GetCustomGameDataObject(id)?.GameDataObject));
	}

	internal static T Find<T, C>() where T : GameDataObject where C : CustomGameDataObject
	{
		return GDOUtils.GetCastedGDO<T, C>();
	}

	internal static T Find<T>(string modName, string name) where T : GameDataObject
	{
		return GDOUtils.GetCastedGDO<T>(modName, name);
	}

	private static Appliance.ApplianceProcesses FindApplianceProcess<C>() where C : CustomSubProcess
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		Appliance.ApplianceProcesses result = default(Appliance.ApplianceProcesses);
		((CustomApplianceProccess)CustomSubProcess.GetSubProcess<C>()).Convert(out result);
		return result;
	}
}
