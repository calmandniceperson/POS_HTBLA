use std::mem;

#[derive(Debug)]
pub struct List {
    head: Link
}

#[derive(Debug)]
enum Link {
    Empty,
    More(Box<Node>),
}

#[derive(Debug)]
struct Node {
    value: i32,
    next: Link,
}

impl List {
    // Self is an alias for "that type I wrote at top
    // next to impl". Great for not repeating yourself!
    pub fn new() -> Self {
        List { head: Link::Empty }
    }

    pub fn push(&mut self, elem: i32) {
        let new_node = Box::new(Node {
            value: elem,
            // Here we replace self.head temporarily with Link::Empty
            // before replacing it with the new head of the list.
            // I'm not gonna lie: this is a pretty unfortunate thing to
            // have to do. Sadly, we must (for now).
            // Replaces the value at a mutable location with a new one,
            // returning the old value, without deinitializing either one.
            next: mem::replace(&mut self.head, Link::Empty),
        });

        self.head = Link::More(new_node);
    }

    pub fn pop(&mut self) -> Option<i32> {
        match mem::replace(&mut self.head, Link::Empty) {
            Link::Empty => None,
            Link::More(boxed_node) => {
                let node = *boxed_node;
                self.head = node.next;
                Some(node.value)
            }
        }
    }
}

impl Drop for List {
    fn drop(&mut self) {
        let mut cur_link = mem::replace(&mut self.head, Link::Empty);

        // `while let` == "do this thing until this pattern doesn't match"
        while let Link::More(mut boxed_node) = cur_link {
            cur_link = mem::replace(&mut boxed_node.next, Link::Empty);
            // boxed_node goes out of scope and gets dropped here;
            // but its Node's `next` field has been set to Link::Empty
            // so no unbounded recursion occurs.
        }
    }
}

#[cfg(test)] // Only compile this when testing
mod test {
    use super::List;

    #[test]
    fn basics() {
        let mut list = List::new();

        // Check empty list behaves as it should
        // assert_eq asserts if two values are equal to
        // each other and panics if they're not.
        assert_eq!(list.pop(), None);

        // Populate the list.
        list.push(1);
        list.push(2);
        list.push(3);

        // Check if the calls to pop() return the correct
        // values for a "normal removal".
        assert_eq!(list.pop(), Some(3));
        assert_eq!(list.pop(), Some(2));

        list.push(4);
        list.push(5);

        assert_eq!(list.pop(), Some(5));
        assert_eq!(list.pop(), Some(4));

        assert_eq!(list.pop(), Some(1));
        assert_eq!(list.pop(), None);
    }
}