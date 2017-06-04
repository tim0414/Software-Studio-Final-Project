using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Node : MonoBehaviour {


	public Color hoverColor;
	public Color notEnoughMoneyColor;
    public Vector3 positionOffest;

    private Renderer rend;
	private Color startColor;

    [Header("Optional")]
	public GameObject turret;

    BuildManager buildmanager;
    

    void Start()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
        buildmanager = BuildManager.instance;
	}

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffest;
    }
	void OnMouseDown()
	{
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (!buildmanager.CanBuild)
            return;
		if(turret != null){
			Debug.Log("Can't build here");
			return;
		}
        buildmanager.BuildTurrentOn(this);
	}
	void OnMouseEnter()
	{
        if(EventSystem.current.IsPointerOverGameObject())
            return;
        if (!buildmanager.CanBuild)
            return;

		if(buildmanager.HasMoney){
        	rend.material.color = hoverColor;
		} else {
			rend.material.color = notEnoughMoneyColor;
		}
	}


	void OnMouseExit()
	{
		rend.material.color = startColor;
	}
}
