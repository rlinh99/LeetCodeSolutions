/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/
/*
    133. Clone Graph
    Explanation: 
    BFS

    Medium
*/


public class Solution {
    public Node CloneGraph(Node node) {
        if(node == null)
            return node;
        
        Queue<Node> q = new();
        q.Enqueue(node);
        //key self, value copy
        Dictionary<Node,Node> visited = new ();
        visited.Add(node, new Node(node.val));
        
        while(q.Count > 0){
            Node curr = q.Dequeue();
            foreach(var neighbour in curr.neighbors)
            {
                if(!visited.ContainsKey(neighbour))
                {
                    visited.Add(neighbour, new Node(neighbour.val));
                    q.Enqueue(neighbour);
                }
                visited[curr].neighbors.Add(visited[neighbour]);
            }
        }
        return visited[node];
    }
}