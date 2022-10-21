using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class ResourceConcentrator 
{
    [SerializeField] private ResourceTypes resourceType;
    [SerializeField] private Sprite enrichmentSprite;
    [SerializeField] private Sprite readyToBreakSprite;

    public ResourceTypes ResourceType => resourceType;
    public Sprite EnrichmentSprite => enrichmentSprite;
    public Sprite ReadyToBreakSprite => readyToBreakSprite;
}
