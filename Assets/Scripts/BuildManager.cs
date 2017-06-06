﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;

	void Awake(){
		if(instance != null){
			Debug.LogError("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}



    public GameObject buildEffect;

    private TurrentBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurrentOn(Node node)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not Enough monet to build that");
            return;
        }
        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(),Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject) Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);
        Debug.Log("Turrent build! Money left : " + PlayerStats.Money);
    }

    public void SelectTurrentToBuild(TurrentBlueprint turret)
    {
        turretToBuild = turret;
    }
}
