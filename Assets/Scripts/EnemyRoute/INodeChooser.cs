public interface INodeChooser
{
    void SetNodes(int firstNodeIndex, int nodesCount);
    int DefineNextNode(int currentNodeIndex);
}
