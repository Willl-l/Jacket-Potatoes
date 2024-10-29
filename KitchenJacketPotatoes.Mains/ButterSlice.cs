using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenJacketPotatoes.Mains;

internal class ButterSlice : CustomItem
{
    public override string UniqueNameID => "Butter Slice";

	public override GameObject Prefab => GameObjectUtils.GetChildObject(Prefab, "Cheese - Grated");
	public override ItemCategory ItemCategory => ItemCategory.Generic;

	public override ItemStorage ItemStorageFlags => ItemStorage.StackableFood;

	public override ItemValue ItemValue => ItemValue.Medium;

	public override Item SplitSubItem => Refs.ButterSlice;

	public override List<Item> SplitDepletedItems => new List<Item> { Refs.ButterSlice };

	public override int SplitCount => 2;

	public override float SplitSpeed => 1f;
}
