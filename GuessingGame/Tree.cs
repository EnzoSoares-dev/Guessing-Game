using System;
using System.Collections.Generic;

namespace GuessingGame
{
    public class Tree
    {
        public Node node;
        Node temp = new Node();
        public void startGame()
        {            
            char resp;
            insertNode(node);
            if(node.left != null && node.right != null)
            {               
                Console.WriteLine("Your animal have "+node.content+"?");
                Console.WriteLine("y-Yes / n-No");
                resp = char.Parse(Console.ReadLine());
                if(resp == 'y')
                {
                    temp = node;
                    node = node.left;
                    startGame();
                }
                else if(resp == 'n')
                {
                    temp = node;
                    node = node.right;
                    startGame();
                }
            }
            else
            {
                Console.WriteLine("Your animal is: "+node.content+"?");
                Console.WriteLine("y-Yes / n-No");
                resp = char.Parse(Console.ReadLine());
                if (resp == 'y')
                {
                    Console.WriteLine("I win!! I am the smartest!");
                    Console.WriteLine("Do you wanna play again?");
                    Console.WriteLine("y-Yes / n-No");
                    resp = char.Parse(Console.ReadLine());
                    if (resp == 'y')
                    {
                        Console.Clear();
                        node = temp;
                        startGame();
                    }
                    else if (resp == 'n') Console.WriteLine("That was a great game");
                }
                else if (resp == 'n')
                {
                    Console.WriteLine("Tell me one characterisc about your animal");
                    String characAnswer = Console.ReadLine();
                    Console.WriteLine("And what animal were you thinking? ");
                    String AnimalAnswer = Console.ReadLine();
                    Console.WriteLine("Do you wanna play again?");
                    Console.WriteLine("y-Yes / n-No");
                    resp = char.Parse(Console.ReadLine());
                    if(resp == 'y')
                    {
                        Node tempNode;
                        String tempAnimal = node.content;
                        node.content = characAnswer;
                        node.left = new Node();
                        node.left.content = AnimalAnswer;
                        node.right = new Node();
                        node.right.content = tempAnimal;
                        tempNode = node;
                        node = temp;
                        if(node.left.content == tempAnimal)
                        {
                            node.left = tempNode;
                        }
                        else
                        {
                            node.right = tempNode;
                        }
                        Console.Clear();
                        startGame();
                    }
                        
                }
            }
        }


        public Node insertNode(Node firstNode)
        {
            if(firstNode == null)
            {
                firstNode = new Node();
                firstNode.content = "Four legs";
                firstNode.right = new Node();
                firstNode.right.content = "Whale";
                firstNode.left = new Node();
                firstNode.left.content = "Horse";
                node = firstNode;
                return node;
            }
            else
            {
                return node;
            }
        }  
    }
}
