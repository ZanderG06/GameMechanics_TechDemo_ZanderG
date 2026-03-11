using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PortalMenuManager : MonoBehaviour
{
    public List<GameObject> portals = new();
    public Transform playerPos;

    public void OnClick(int portalNumber)
    {
        playerPos.position = portals[portalNumber].transform.position;
    }
}
