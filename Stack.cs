using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace DataStructure{
    public class Stack
    {
        private class Node{
            public int val;
            public Node next;
            public Node(int value){
                val = value;
            }
        }
        
        private Node top;

        public Stack(){
            top = null;
        }
        public Stack(int[] array){
            foreach(int a in array){
                this.Push(a);
            }
        }

        public void Push(int num){
            Node node  = new Node(num);
            node.next = top;
            top = node;
        }

        public int Peek(){
            return top.val;
        }
        public int Pop(){
            int temp = top.val;
            top = top.next;
            return temp;
        }

        public bool IsEmpty(){
            return top == null;
        }

    }
}