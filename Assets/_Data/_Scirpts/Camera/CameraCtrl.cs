using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraCtrl : MonoBehaviour
{
    [SerializeField] protected PolygonCollider2D polygonCollider2D;
    [SerializeField] protected CinemachineConfiner2D cinemachineConfiner2D;

    private void Start()
    {
        cinemachineConfiner2D = transform.GetComponent<CinemachineConfiner2D>();
        cinemachineConfiner2D.m_BoundingShape2D = polygonCollider2D;
    }
}
