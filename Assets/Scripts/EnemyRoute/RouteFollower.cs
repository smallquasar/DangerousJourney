using UnityEngine;

public class RouteFollower : MonoBehaviour
{
    [SerializeField] private Transform _traveler;
    [SerializeField] private float _speed = 6f;

    private Transform[] _routeNodes;
    private int _nodesCount = 0;
    private int _firstNodeIndex = 1;
    private int _currentNodeIndex = 0;

    private Vector3 _targetRoutePosition = Vector3.zero;

    private INodeChooser _nodeChooser;

    private void Awake()
    {
        _nodeChooser = GetComponent<INodeChooser>();
    }

    private void Start()
    {
        _routeNodes = GetComponentsInChildren<Transform>();
        _nodesCount = _routeNodes != null ? _routeNodes.Length : 0;

        if (_nodesCount > 0 && _nodeChooser != null)
        {
            _nodeChooser.SetNodes(_firstNodeIndex, _nodesCount);
            DefineNextNode();
        }
    }

    private void DefineNextNode()
    {
        _currentNodeIndex = _nodeChooser.DefineNextNode(_currentNodeIndex);
        _targetRoutePosition = _routeNodes[_currentNodeIndex].position;
    }

    private void Update()
    {
        if (_nodesCount == 0 || _traveler == null || _nodeChooser == null)
            return;

        _traveler.position = Vector3.MoveTowards(_traveler.position, _targetRoutePosition, _speed * Time.deltaTime);

        if (_traveler.position == _targetRoutePosition)
        {
            DefineNextNode();
        }
    }
}
