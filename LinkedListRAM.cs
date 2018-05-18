﻿using System;

namespace ConsoleApplication1
{
    internal class LinkedListRAM : LinkedList
    {
        public LinkedListRAM(int count, int seed)
        {
            Count = count;
            var rand = new Random(seed);

            for (var i = 0; i < count; i++)
            {
                AddLast(rand.Next(Sort.maxValue));
            }
        }

        public void AddLast(int data)
        {
            if (Last == null)
            {
                First = new LinkedListNode
                {
                    Value = data
                };

                Last = First;
            }
            else
            {
                var toAdd = new LinkedListNode
                {
                    Value = data,
                };

                Last.Next = toAdd;
                Last = NextOf(Last);
            }
        }

        public override LinkedListNode GetFirstNode()
        {
            return First;
        }

        public override LinkedListNode NextOf(LinkedListNode node)
        {
            return node.Next;
        }

        public override void SetValue(LinkedListNode node, int value)
        {
            node.Value = value;
        }

        public override void Swap(LinkedListNode node1, LinkedListNode node2)
        {
            var temp = node1.Value;
            node1.Value = node2.Value;
            node2.Value = temp;
        }
    }
}