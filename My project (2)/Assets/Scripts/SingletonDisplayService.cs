using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDisplayService
{
    private ResourceConcentratorBD resourceConcentratorBD;
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
        resourceConcentratorBD = (ResourceConcentratorBD)Resources.Load("SOs/ResourceConcentratorBD");
        switch (resourceType)
        {
            case ResourceTypes.URANIUM:
                return resourceConcentratorBD.ResourceConcentrators[0].EnrichmentSprite;
            case ResourceTypes.PLUTONIUM:
                return resourceConcentratorBD.ResourceConcentrators[1].EnrichmentSprite;
            case ResourceTypes.GERMANIUM:
                return resourceConcentratorBD.ResourceConcentrators[2].EnrichmentSprite;
            case ResourceTypes.VANADIUM:
                return resourceConcentratorBD.ResourceConcentrators[3].EnrichmentSprite;
            case ResourceTypes.KRYPTON:
                return resourceConcentratorBD.ResourceConcentrators[4].EnrichmentSprite;
            default:
                return null;
        }
    }

    public Sprite GetDecaySprite(ResourceTypes resourceType)
    {
        switch (resourceType)
        {
            case ResourceTypes.URANIUM:
                return resourceConcentratorBD.ResourceConcentrators[0].ReadyToBreakSprite;
            case ResourceTypes.PLUTONIUM:
                return resourceConcentratorBD.ResourceConcentrators[1].ReadyToBreakSprite;
            case ResourceTypes.GERMANIUM:
                return resourceConcentratorBD.ResourceConcentrators[2].ReadyToBreakSprite;
            case ResourceTypes.VANADIUM:
                return resourceConcentratorBD.ResourceConcentrators[3].ReadyToBreakSprite;
            case ResourceTypes.KRYPTON:
                return resourceConcentratorBD.ResourceConcentrators[4].ReadyToBreakSprite;
            default:
                return null;
        }
    }
}
