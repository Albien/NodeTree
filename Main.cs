
using System.IO;

namespace NS {

 class Node{
	public Node leftNode;
	public Node rightNode;
	public int valueI;
	}

 class PlusNode : Node {
	int eval() { return leftNode.eval() + rightNode.eval(); }
	}

 class MinusNode : Node {
	int eval() { return leftNode.eval() - rightNode.eval(); }
	}

}
