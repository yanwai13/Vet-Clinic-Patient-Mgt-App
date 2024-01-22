using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VetClinicPatientMgtProject.Clinic;

namespace VetClinicPatientMgtProject.BaseClass
{
    public class PriorityQueue
    {

        private DoublyLinkedList<Pet> pets_queue;

        public PriorityQueue()
        {
            pets_queue = new DoublyLinkedList<Pet>();
        }
        public bool isEmpty()
        {

            return pets_queue.IsEmpty();
        }

        public DoublyLinkedList<Pet> getPatients()
        {
            return pets_queue;
        }

        public int size()
        {
            return pets_queue.Size();
        }//end of size


        public Pet dequeue()
        {



            if (isEmpty())
            {
                throw new InvalidOperationException("The list is empty");
            }

            Pet pet = pets_queue.GetHead().data;

            pets_queue.PopFront();

            return pet;


        }//end of dequeue

        //Use  Singleton method to create only one queue

        public Node<Pet> getHead()
        {

            if (pets_queue == null)
            {
                pets_queue = new DoublyLinkedList<Pet>();
            }

            var first_node = pets_queue.GetHead();

            return first_node;
        }

        public void enqueue(Pet p)
        {

            //cursor
            var left_node = getHead();

            //if this is the first element
            if (left_node == null)
            {

                pets_queue.PushBack(p);

                return;
            }
            //if the current patient got the biggest score
            if (p.CalculateScore() > left_node.data.CalculateScore())
            {
                pets_queue.PushFront(p);

                return;

            }
            else
            {

                //create a new node and assign P to this node
                Node<Pet> node = new Node<Pet>(p);


                //traverse one by one and stop the pos
                if (left_node is not null)
                {

                    while (left_node.next is not null)
                    {

                        //if current node score bigger than the new  node
                        //move to next node
                        if (left_node.data.CalculateScore() > p.CalculateScore())
                        {
                            left_node = left_node.next;

                        }
                        //if p score > current score
                        // current score move left
                        if (p.CalculateScore() > left_node.data.CalculateScore())
                        {
                            left_node = left_node.pre;
                            break;

                        }
                        //if scores are equal
                        if (p.CalculateScore() == left_node.data.CalculateScore())
                        {

                            break;
                        }



                    }// end of while

                    //if cursor go to the tail
                    if (left_node.next == null)
                    {
                        pets_queue.PushBack(p);
                        return;
                    }

                    //insert process beign
                    //create a new right node
                    // assign the previous next link to the right node
                    Node<Pet> right_node = left_node.next;

                    //now the cursor next node will be the new patient node "p"
                    left_node.next = node;

                    //if the right_node got some,
                    //the right node previous is the new p node
                    if (right_node is not null)
                    {
                        right_node.pre = node;
                    }

                    //new p node previous is the left node
                    //new p node next is the right node
                    node.pre = left_node;
                    node.next = right_node;



                }





            }//end of enqueue



        }

    }
}
