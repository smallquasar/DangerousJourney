using UnityEngine;

public class CircularRouteNodeChooser : MonoBehaviour, INodeChooser
{
    private int _firstNodeIndex;
    private int _nodesCount;

    public void SetNodes(int firstNodeIndex, int nodesCount)
    {
        _firstNodeIndex = firstNodeIndex;
        _nodesCount = nodesCount;
    }

    public int DefineNextNode(int currentNodeIndex)
    {
        if (currentNodeIndex < _nodesCount - 1)
        {
            currentNodeIndex++;
        }
        else
        {
            currentNodeIndex = _firstNodeIndex;
        }

        return currentNodeIndex;
    }
}
