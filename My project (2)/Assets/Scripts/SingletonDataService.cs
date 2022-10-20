using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDataService
{
    Dictionary<ResourceTypes, ResourceTimeData> dictionaryOfResourceTime = new Dictionary<ResourceTypes, ResourceTimeData>()
    {
        {ResourceTypes.URANIUM, (ResourceTimeData)Resources.Load("SOs/UraniumTime") },
        {ResourceTypes.PLUTONIUM, (ResourceTimeData)Resources.Load("SOs/PlutoniumTime") },
        {ResourceTypes.KRYPTON, (ResourceTimeData)Resources.Load("SOs/KryptonTime") },
        {ResourceTypes.VANADIUM, (ResourceTimeData)Resources.Load("SOs/VanadiumTime") },
        {ResourceTypes.GERMANIUM, (ResourceTimeData)Resources.Load("SOs/GermaniumTime") }
    };
    
    private static SingletonDataService instance;
    public static SingletonDataService Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SingletonDataService();
            }

            return instance;
        }
    }

    public float GetEnchrichmentTime(ResourceTypes resourceType)
    {
        return dictionaryOfResourceTime[resourceType].ResourceTime.EnrichmentTime;
    }

    public float GetDecayTime(ResourceTypes resourceType)
    {
        return dictionaryOfResourceTime[resourceType].ResourceTime.DecayTime;
    }
}
