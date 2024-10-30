using System.Collections.Generic;
using KitchenData;
using KitchenJacketPotatoes
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenJacketPotatoes.Mains;

internal class FoilTable : CustomAppliance
{
    public override string UniqueNameID => "Foil Table";

    public override GameObject Prefab => GameDataObjectUtils.GetChildObject("Cereal Provider");

    public override PriceTier PriceTier => PriceTier.Medium;

    public override bool SellOnlyAsDuplicate => true;

    public override bool IsPurchasable => true;

}
