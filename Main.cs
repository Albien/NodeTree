
using System.IO;

namespace NS {

 class Node{
	public Node leftNode;
	public Node rightNode;
	public int valueI;
	public int eval(){return valueI;}
	}

 class DelitNode : Node{
	override int eval(){return leftNode.eval()/rightNode.eval();}
	}

 class UmnozNode : Node{
	override int eval(){return leftNode.eval()*rightNode.eval();}
	}

}
