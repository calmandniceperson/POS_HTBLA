#[derive(Debug)]
pub struct List<T> {
    head: Link<T>,
}

type Link<T> = Option<Box<Node<T>>>;

#[derive(Debug)]
struct Node<T> {
    value: T,
    next: Link<T>,
}

pub struct IntoIter<T>(List<T>);

// Iter is generic over *some* lifetime, it doesn't care
pub struct Iter<'a, T: 'a> {
    next: Option<&'a Node<T>>,
}

pub struct IterMut<'a, T: 'a> {
    next: Option<&'a mut Node<T>>,
}

// No lifetime here, List doesn't have any associated lifetimes
impl<T> List<T> {
    pub fn into_iter(self) -> IntoIter<T> {
        IntoIter(self)
    }

    // We declare a fresh lifetime here for the *exact* borrow that
    // creates the iter. Now &self needs to be valid as long as the
    // Iter is around.
    // Lifetime elision here!
    pub fn iter(&self) -> Iter<T> {
        Iter { next: self.head.as_ref().map(|node| &**node) } // double dereference to get to node
    }

    pub fn iter_mut(&mut self) -> IterMut<T> {
        IterMut { next: self.head.as_mut().map(|node| &mut **node) }
    }

    // Self is an alias for "that type I wrote at top
    // next to impl". Great for not repeating yourself!
    pub fn new() -> Self {
        List { head: None }
    }

    pub fn push(&mut self, elem: T) {
        let new_node = Box::new(Node {
            value: elem,
            // Here we replace self.head temporarily with Link::Empty
            // before replacing it with the new head of the list.
            // I'm not gonna lie: this is a pretty unfortunate thing to
            // have to do. Sadly, we must (for now).
            // Replaces the value at a mutable location with a new one,
            // returning the old value, without deinitializing either one.
            next: self.head.take(),
        });
        self.head = Some(new_node);
    }

    pub fn pop(&mut self) -> Option<T> {
        // map "Maps an Option<T> to Option<U> by applying a function
        // to a contained value".
        // In this case, the function that is applied to the contained
        // value is a closure. The value in between the "pipes" is the argument
        // passed to the function. Return types and argument types don't
        // need to be specified, but can be specified.
        // take() "Takes the value out of the option, leaving a None in its place".
        self.head.take().map(|node| {
            let node = *node; // dereference here, since node is a Box (memory)
            self.head = node.next;
            node.value
        })
    }

    pub fn peek(&self) -> Option<&T> {
        // Map takes self by value, which would move the Option out of the thing
        // it's in. Previously this was fine because we had just taken it out,
        // but now we actually want to leave it where it was. The correct way to
        // handle this is with the as_ref method on Option.
        // It demotes the Option to an Option to a reference to its internals.
        // We could do this ourselves with an explicit match but ugh no. It does
        // mean that we need to do an extra derefence to cut through the extra
        // indirection, but thankfully the . operator handles that for us.
        self.head.as_ref().map(|node| {
            &node.value
        })
    }

    pub fn peek_mut(&mut self) -> Option<&mut T> {
        self.head.as_mut().map(|node| {
            &mut node.value
        })
    }
}

// Implement drop, which basically creates a custom destructor for List.
impl<T> Drop for List<T> {
    fn drop(&mut self) {
        let mut cur_link = self.head.take();

        // `while let` == "do this thing until this pattern doesn't match"
        while let Some(mut boxed_node) = cur_link {
            cur_link = boxed_node.next.take();
            // boxed_node goes out of scope and gets dropped here;
            // but its Node's `next` field has been set to Link::Empty
            // so no unbounded recursion occurs.
        }
    }
}

impl<T> Iterator for IntoIter<T> {
    type Item = T;
    fn next(&mut self) -> Option<Self::Item> {
        // Access fields of a tuple struct numerically.
        self.0.pop()
    }
}

// *Do* have a lifetime here, because Iter does have an associated lifetime
impl<'a, T: 'a> Iterator for Iter<'a, T> {
    // Need it here too, this is a type declaration
    type Item = &'a T;

    // None of this needs to change, handled by the above.
    fn next(&mut self) -> Option<Self::Item> {
        self.next.map(|node| {
            self.next = node.next.as_ref().map(|node| &**node); // double dereference to get to node
            &node.value
        })
    }
}

impl<'a, T: 'a> Iterator for IterMut<'a, T> {
    type Item = &'a mut T;

    fn next(&mut self) -> Option<Self::Item> {
        self.next.take().map(|node| {
            self.next = node.next.as_mut().map(|node| &mut **node);
            &mut node.value
        })
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

    #[test]
    fn peek() {
        let mut list = List::new();
        assert_eq!(list.peek(), None);
        assert_eq!(list.peek_mut(), None);

        list.push(1); list.push(2); list.push(3);

        assert_eq!(list.peek(), Some(&3));
        assert_eq!(list.peek_mut(), Some(&mut 3));
    }

    #[test]
    fn into_iter() {
        let mut list = List::new();
        list.push(1); list.push(2); list.push(3);

        let mut iter = list.into_iter();
        assert_eq!(iter.next(), Some(3));
        assert_eq!(iter.next(), Some(2));
        assert_eq!(iter.next(), Some(1));
    }

    #[test]
    fn iter() {
        let mut list = List::new();
        list.push(1); list.push(2); list.push(3);

        let mut iter = list.iter();
        assert_eq!(iter.next(), Some(&3));
        assert_eq!(iter.next(), Some(&2));
        assert_eq!(iter.next(), Some(&1));
    }

    #[test]
    fn iter_mut() {
        let mut list = List::new();
        list.push(1); list.push(2); list.push(3);

        let mut iter = list.iter_mut();
        assert_eq!(iter.next(), Some(&mut 3));
        assert_eq!(iter.next(), Some(&mut 2));
        assert_eq!(iter.next(), Some(&mut 1));
    }
}