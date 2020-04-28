using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouteFollower : MonoBehaviour
{
    [SerializeField] private Transform _traveler;
    [SerializeField] private float _speed = 4f;

    private Node[] _routeNodes;
    private int _nodesCount = 0;

    private Vector3 _targetRoutePosition = Vector3.zero;
    private int _currentNodeIndex = -1;
    private bool _isDirectRoute = true;

    private void Start()
    {
        _routeNodes = GetComponentsInChildren<Node>();
        _nodesCount = _routeNodes != null ? _routeNodes.Length : 0;

        if (_nodesCount > 0)
            DefineTargetNode();
    }

    private void DefineTargetNode()
    {
        if (_isDirectRoute)
            DefineTargetNodeDirect();
        else
            DefineTargetNodeReturn();

        _targetRoutePosition = _routeNodes[_currentNodeIndex].transform.position;
    }

    private void DefineTargetNodeDirect()
    {
        if (_currentNodeIndex < _nodesCount - 1)
        {
            _currentNodeIndex++;
        }
        else
        {
            _currentNodeIndex--;
            _isDirectRoute = false;
        }
    }

    private void DefineTargetNodeReturn()
    {
        if (_currentNodeIndex > 0)
        {
            _currentNodeIndex--;
        }
        else
        {
            _currentNodeIndex++;
            _isDirectRoute = true;
        }
    }

    void Update()
    {
        if (_nodesCount == 0)
            return;

        _traveler.position = Vector3.MoveTowards(_traveler.position, _targetRoutePosition, _speed * Time.deltaTime);

        if (_traveler.position == _targetRoutePosition)
        {
            DefineTargetNode();
        }
    }
}
