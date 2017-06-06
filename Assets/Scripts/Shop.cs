using System.Collections.Generic;
using UnityEngine;


public class Shop : MonoBehaviour {

    public TurrentBlueprint standardTurrent;
    public TurrentBlueprint missleLauncher;
    public TurrentBlueprint laserBeamer;

    BuildManager buildmanager;
    void Start()
    {
        buildmanager = BuildManager.instance;
    }
    public void SelectStandardTurrent()
    {
        Debug.Log("Standard Turrent Selected ");
        buildmanager.SelectTurrentToBuild(standardTurrent);
    }
    public void SelectMissileLauncher()
    {
        Debug.Log("Missile Launcher Selected ");
        buildmanager.SelectTurrentToBuild(missleLauncher);
    }

     public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Selected ");
        buildmanager.SelectTurrentToBuild(laserBeamer);
    }
}
