using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenJacketPotatoes.Mains;

internal class BakingPotato : CustomItem
{
    public override string UniqueNameID => "BakingPotato";

    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Baking Potato").AssignMaterialsByNames();

    public override Appliance DedicatedProvider => (Appliance)GDOUtils.GetCustomGameDataObject<BakingPotatoProvider>().GameDataObject;
}
