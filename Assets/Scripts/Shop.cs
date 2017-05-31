using System.Collections.Generic;
using UnityEngine;


public class Shop : MonoBehaviour {

    BuildManager buildmanager;
    void Start()
    {
        buildmanager = BuildManager.instance;
    }
    public void PurchaseStandardTurrent()
    {
        Debug.Log("Standard Turrent Selected ");
        buildmanager.SetTurrentToBuild(buildmanager.standardTurretPrefab);
    }
    public void PurchaseMissileLauncher()
    {
        Debug.Log("Missile Launcher Selected ");
        buildmanager.SetTurrentToBuild(buildmanager.missileLauncherPrefab);
    }
}
