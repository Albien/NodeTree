
using System.IO;

namespace NS {

 class Node{
	public Node leftNode;
	public Node rightNode;
	public int valueI;
	public int eval() { return valueI; }
	}


 class PlusNode : Node { // Плюс
	override int eval() { return leftNode.eval() + rightNode.eval(); }
	}

 class MinusNode : Node { // Минус
	override int eval() { return leftNode.eval() - rightNode.eval(); }

 class DelitNode : Node { // Деление
	override int eval() { return leftNode.eval()/rightNode.eval(); }
	}

 class UmnozNode : Node{ // Умножение
	override int eval() { return leftNode.eval()*rightNode.eval(); }
	}

}
