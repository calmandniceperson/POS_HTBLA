// Michael Koeppl 4AHIF
// Binary Tree (recursive)
// 10 June 2016

import java.util.Scanner;

class BinaryTree {

    private static Node root = null;

    private static void out(Node lastNode) {
        if (lastNode.getLeft() != null && lastNode.getRight() != null) {
            System.out.println(
                    "[Left node: " + lastNode.getLeft().getNum() + 
                    " | Value: " + lastNode.getNum() +
                    " | Right node: " + lastNode.getRight().getNum() + "]");
            out(lastNode.getLeft());
            out(lastNode.getRight());
        } else if(lastNode.getRight() == null) {
            System.out.println(
                    "[Left node: " + lastNode.getLeft().getNum() + 
                    " | Value: " + lastNode.getNum() +
                    " | Right node: null]");

        } else if(lastNode.getLeft() == null) {
             System.out.println(
                    "[Left node: null" + 
                    " | Value: " + lastNode.getNum() +
                    " | Right node: " + lastNode.getRight().getNum() + "]");
        }
    }

    private static void insert(int num, Node lastNode) {
        if(num < lastNode.getNum()) {
            if(lastNode.getLeft() == null) {
                lastNode.setLeft(new Node(num, null, null));
                return;
            }
            insert(num, lastNode.getLeft());
        } else if(num > lastNode.getNum()) {
            if(lastNode.getRight() == null) {
                lastNode.setRight(new Node(num, null, null));
                return;
            }
            insert(num, lastNode.getRight());
        } else if(num == lastNode.getNum()) {
            return;
        }
    }

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        do {
            System.out.print("Enter a number: ");
            int num = Integer.parseInt(input.next());
            if(root == null) {
                root = new Node(num, null, null);
            } else {
                insert(num, root);
            }
            System.out.println("Do you want to enter another number? (y/n)");
        } while(input.next().toLowerCase().charAt(0) == 'y');
        out(root);
    }
}

class Node {
    private int data;
    private Node left, right;

    public Node(int data, Node left, Node right) {
        this.data = data;
        this.left = left;
        this.right = right;
    }

    public void setLeft(Node left) {
        this.left = left;
    }

    public void setRight(Node right) {
        this.right = right;
    }

    public int getNum() {
        return this.data;
    }
    public Node getLeft() {
        return this.left;
    }

    public Node getRight() {
        return this.right;
    }
}
