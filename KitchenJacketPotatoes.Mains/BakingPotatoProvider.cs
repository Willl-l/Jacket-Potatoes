using System.Collections.Generic;
using Kitchen;
using Kitchen.Components;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenJacketPotatoes.Mains;

internal class BakingPotatoProvider : CustomAppliance
{
    public override string UniqueNameID => "BakingPotatoProvider";

    public override GameObject Prefab => Mod.Bundle.LoadAsset<GameObject>("Baking Potato Provider").AssignMaterialsByNames();

    public override List<IApplianceProperty> Properties => new List<IApplianceProperty>
        {
            KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<BakingPotato>().ID)
        };

    public override PriceTier PriceTier => PriceTier.Medium;

    public override RarityTier RarityTier => RarityTier.Uncommon;

    public override bool IsPurchasable => true;

    public override bool SellOnlyAsDuplicate => true;

    public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)>
        {
            (Locale.English, new ApplianceInfo
            {
                Name = "Baking Potato",
                Description = "Provides Baking Potato"
            })
        };
    public override void OnRegister(Appliance gameDataObject)
    {
        base.OnRegister(gameDataObject);

    }
}
