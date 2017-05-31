using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Node : MonoBehaviour {


	public Color hoverColor;

	private Renderer rend;
	private Color startColor;
	private GameObject turret;
    BuildManager buildmanager;

	void Start()
	{
		rend = GetComponent<Renderer>();
		startColor = rend.material.color;
        buildmanager = BuildManager.instance;
	}

	void OnMouseDown()
	{
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildmanager.GetTurretToBuid()==null)
            return;
		if(turret != null){
			Debug.Log("Can't build here");
			return;
		}
		GameObject turretToBuid = buildmanager.GetTurretToBuid();
		turret = (GameObject) Instantiate(turretToBuid, transform.position, transform.rotation);
	}
	void OnMouseEnter()
	{
        if(EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildmanager.GetTurretToBuid() == null)
            return;

        rend.material.color = hoverColor;
	}


	void OnMouseExit()
	{
		rend.material.color = startColor;
	}
}
