using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VetClinicPatientMgtProject.BaseClass
{
    public class Node<T>
    {

        public T data { get; set; }
        public Node<T> next { get; set; }
        public Node<T> pre { get; set; }

        public Node(T data)
        {
            this.data = data;
            next = null;
            pre = null;
        }
    }

    public class DoublyLinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;


        public void PrintAllNodes()
        {
            Node<T> current = _head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }

        }
        public Node<T> GetHead()
        {

            return _head;
        }

        public Node<T> GetTail()
        {

            return _head;
        }

        public void PushFront(T data)
        {

            Node<T> node = new Node<T>(data);
            node.data = data;

            if (_head != null)
            {
                _head.pre = node;
                node.next = _head;
            }
            else
            {
                _tail = node;
            }
            _head = node;
        }


        public void PushBack(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (_head is null)
            {
                _head = newNode;
                _tail = newNode;
                return;
            }
            else
            {
                _tail.next = newNode;
                newNode.pre = _tail;
                _tail = newNode;
            }
        }

        public bool IsEmpty() { return _head == null; }

        public T PopFront()
        {

            Node<T> first = _head;

            if (first is null)
            {
                throw new InvalidOperationException("The list is empty");

            }
            T first_data = _head.data;

            if (_tail == _head)
            {
                _head = null;
                _tail = null;
            }
            else
            {

                _head = first.next;
                _head.pre = null;
            }
            return first_data;
        }

        public T PopBack()
        {

            if (_tail is null)
            {
                throw new InvalidOperationException("The list is empty");


            }
            Node<T> last = _tail;

            T last_data = last.data;

            if (_tail == _head)
            {
                _head = null;
                _tail = null;
            }
            else
            {

                _tail = _tail.pre;
                _tail.next = null;
            }
            return last_data;
        }

        public int Size()
        {
            int count = 0;

            Node<T> current = _head;
            while (current != null)
            {
                count++;
                current = current.next;
            }
            return count;
        }


    }
}
