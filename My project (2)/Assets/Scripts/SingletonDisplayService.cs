using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDisplayService
{
    private Resource—oncentratorBD resource—oncentratorBD = (Resource—oncentratorBD)Resources.Load("SOs/Resource—oncentratorBD");
    private static SingletonDisplayService instance;
    public static SingletonDisplayService Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonDisplayService();
            }

            return instance;
        }
    }

    public Sprite GetEnrichmentSprite(ResourceTypes resourceType)
    {
        switch (resourceType)
        {
            case ResourceTypes.URANIUM:
                return resource—oncentratorBD.Resource—oncentrators[0].EnrichmentSprite;
            case ResourceTypes.PLUTONIUM:
                return resource—oncentratorBD.Resource—oncentrators[1].EnrichmentSprite;
            case ResourceTypes.GERMANIUM:
                return resource—oncentratorBD.Resource—oncentrators[2].EnrichmentSprite;
            case ResourceTypes.VANADIUM:
                return resource—oncentratorBD.Resource—oncentrators[3].EnrichmentSprite;
            case ResourceTypes.KRYPTON:
                return resource—oncentratorBD.Resource—oncentrators[4].EnrichmentSprite;
            default:
                return null;
        }
    }

    public Sprite GetDecaySprite(ResourceTypes resourceType)
    {
        switch (resourceType)
        {
            case ResourceTypes.URANIUM:
                return resource—oncentratorBD.Resource—oncentrators[0].ReadyToBreakSprite;
            case ResourceTypes.PLUTONIUM:
                return resource—oncentratorBD.Resource—oncentrators[1].ReadyToBreakSprite;
            case ResourceTypes.GERMANIUM:
                return resource—oncentratorBD.Resource—oncentrators[2].ReadyToBreakSprite;
            case ResourceTypes.VANADIUM:
                return resource—oncentratorBD.Resource—oncentrators[3].ReadyToBreakSprite;
            case ResourceTypes.KRYPTON:
                return resource—oncentratorBD.Resource—oncentrators[4].ReadyToBreakSprite;
            default:
                return null;
        }
    }
}
