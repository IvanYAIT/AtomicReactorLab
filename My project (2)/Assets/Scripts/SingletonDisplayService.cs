using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDisplayService
{
    private ResourceÑoncentratorBD resourceÑoncentratorBD = (ResourceÑoncentratorBD)Resources.Load("SOs/ResourceÑoncentratorBD");
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
                return resourceÑoncentratorBD.ResourceÑoncentrators[0].EnrichmentSprite;
            case ResourceTypes.PLUTONIUM:
                return resourceÑoncentratorBD.ResourceÑoncentrators[1].EnrichmentSprite;
            case ResourceTypes.GERMANIUM:
                return resourceÑoncentratorBD.ResourceÑoncentrators[2].EnrichmentSprite;
            case ResourceTypes.VANADIUM:
                return resourceÑoncentratorBD.ResourceÑoncentrators[3].EnrichmentSprite;
            case ResourceTypes.KRYPTON:
                return resourceÑoncentratorBD.ResourceÑoncentrators[4].EnrichmentSprite;
            default:
                return null;
        }
    }

    public Sprite GetDecaySprite(ResourceTypes resourceType)
    {
        switch (resourceType)
        {
            case ResourceTypes.URANIUM:
                return resourceÑoncentratorBD.ResourceÑoncentrators[0].ReadyToBreakSprite;
            case ResourceTypes.PLUTONIUM:
                return resourceÑoncentratorBD.ResourceÑoncentrators[1].ReadyToBreakSprite;
            case ResourceTypes.GERMANIUM:
                return resourceÑoncentratorBD.ResourceÑoncentrators[2].ReadyToBreakSprite;
            case ResourceTypes.VANADIUM:
                return resourceÑoncentratorBD.ResourceÑoncentrators[3].ReadyToBreakSprite;
            case ResourceTypes.KRYPTON:
                return resourceÑoncentratorBD.ResourceÑoncentrators[4].ReadyToBreakSprite;
            default:
                return null;
        }
    }
}
