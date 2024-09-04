using System.Data;

namespace DataStructure{
    public class Queue
    {
        private class Node{
            public int val;
            public Node next;
            public Node(int value){
                val = value;
            }
        }
        
        private Node head, tail;

        public Queue(){
            head = null;
            tail = head;
        }
        public Queue(int[] array){
            head = new Node(array[0]);
            Node temp = head;
            for(int i  = 1; i< array.Length; i++){
                temp.next = new Node(array[i]);
                temp = temp.next;
            }
            tail = temp;
        }

        public int Peek(){
            return this.head.val;
        }
        public int Pop(){
            int temp = this.head.val;
            head = head.next;
            if (head==null){
                tail=null;
            }
            return temp;
        }
        public void Add(int num){
            Node node  = new Node(num);
            if (tail!=null){
                tail.next = node;  
            }
            tail = node;
            if(head == null){
                head = node;
            }
        }
        public bool IsEmpty(){
            return head==null;
        }
    }
}