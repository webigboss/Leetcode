/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {

    private Stack<NestedInteger> st;
    public NestedIterator(IList<NestedInteger> nestedList) {
        st = new Stack<NestedInteger>();
        for(var i = nestedList.Count - 1; i >= 0; i--)
            st.Push(nestedList[i]);
    }

    public bool HasNext() {
        while(st.Count > 0 && !st.Peek().IsInteger()){
            var nlist  = st.Pop().GetList();
            for(var i = nlist.Count - 1; i >= 0; i--){
                st.Push(nlist[i]);
            }
        }
        return st.Count > 0;
    }

    public int Next() {
        return st.Pop().GetInteger();
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */