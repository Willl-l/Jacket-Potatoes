using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenJacketPotatoes.Mains;
internal class PlatedJacketPotato : CustomItemGroup
{
	public override string UniqueNameID => "Plated Jacket Potato";

	public override GameObject Prefab => GameObjectUtils.GetChildObject(Prefab, "Potato - Baked");
	public override ItemCategory ItemCategory => ItemCategory.Generic;

	public override ItemStorage ItemStorageFlags => ItemStorage.None;

	public override ItemValue ItemValue => ItemValue.Medium;

	public override Item DisposesTo => Refs.Plate;

	public override Item DirtiesTo => Refs.DirtyPlate;

	public override bool CanContainSide => true;

	public override List<ItemGroup.ItemSet> Sets => new List<ItemGroup.ItemSet>
	{
		new ItemGroup.ItemSet
		{
			Max = 1,
			Min = 1,
			IsMandatory = true,
			Items = new List<Item> { Refs.Plate }
		},
		new ItemGroup.ItemSet
		{
			Max = 2,
			Min = 1,
			IsMandatory = true,
			Items = new List<Item>
			{
				Refs.Potato,
			}
		}
	};
	public override void OnRegister(GameDataObject gameDataObject)
	{
		GameObject child = GameObjectUtils.GetChild(((CustomItem<ItemGroup>)(object)this).Prefab, "Potato");
		GameObject child2 = GameObjectUtils.GetChild(((CustomItem<ItemGroup>)(object)this).Prefab, "Plate/Plate.001");
	}
}

