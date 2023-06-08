﻿namespace OmegaCrosspathing.Merging.MergeFixes;

public class FixCannonShips : PostMergeFix
{
    public override void Apply(TowerModel model)
    {
        if (model.appliedUpgrades.Contains(UpgradeType.CannonShip))
        {
            if (model.appliedUpgrades.Contains(UpgradeType.AircraftCarrier))
            {
                {
                    //TODO fix the attack angles without crashing
                }
            }

            if (model.appliedUpgrades.Contains(UpgradeType.Destroyer)) // TODO apply rate buffs to all weapons
            {
                model.GetWeapon(4).Rate /= 5f;
                model.GetWeapon(5).Rate /= 5f;
            }
        }
    }
}
