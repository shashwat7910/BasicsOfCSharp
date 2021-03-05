using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Queue
    {
        private int[] elements;
        private int rear;
        private int front;
        private int max;
        public Queue(int size)
        {
            elements = new int[size];
            max = size;
            front = 0;
            rear = -1;
        }
        public void insert(int item)
        {
            if (rear == max - 1)
                return;
            else
                elements[++rear] = item;
        }
        public int delete()
        {
            if (front == rear + 1)
                return -1;
            else
                return elements[front++];
        }
        public string printqueue()
        {

        }
    }
}
