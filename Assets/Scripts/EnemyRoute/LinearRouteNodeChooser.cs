using UnityEngine;

public class LinearRouteNodeChooser : MonoBehaviour, INodeChooser
{
    private bool _isDirectRoute;
    private int _firstNodeIndex;
    private int _nodesCount;

    private void Start()
    {
        _isDirectRoute = true;
    }

    public void SetNodes(int firstNodeIndex, int nodesCount)
    {
        _firstNodeIndex = firstNodeIndex;
        _nodesCount = nodesCount;
    }

    public int DefineNextNode(int currentNodeIndex)
    {
        if (_isDirectRoute)
            DefineTargetNodeDirect(ref currentNodeIndex);
        else
            DefineTargetNodeReturn(ref currentNodeIndex);

        return currentNodeIndex;
    }

    private void DefineTargetNodeDirect(ref int currentNodeIndex)
    {
        if (currentNodeIndex < _nodesCount - 1)
        {
            currentNodeIndex++;
        }
        else
        {
            currentNodeIndex--;
            _isDirectRoute = false;
        }
    }

    private void DefineTargetNodeReturn(ref int currentNodeIndex)
    {
        if (currentNodeIndex > _firstNodeIndex)
        {
            currentNodeIndex--;
        }
        else
        {
            currentNodeIndex++;
            _isDirectRoute = true;
        }
    }
}
