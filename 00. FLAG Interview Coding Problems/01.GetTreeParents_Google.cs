//https://www.1point3acres.com/bbs/thread-522935-1-1.html
        public int[] GetTreeParent(int level, int[] childs)
        {
            var result = new int[childs.Length];
            var root = (int)Math.Pow(2, level) - 1;
            if (Array.IndexOf(childs, root) > -1)
                result[Array.IndexOf(childs, root)] = -1;
            GetTreeParentHelper(level - 1, 0, root, childs, result);
            return result;
        }

        private void GetTreeParentHelper(int level, int advance, int parent, int[] childs, int[] result)
        {
            if (level == 0)
                return;
            //left
            var left = (int)Math.Pow(2, level) - 1 + advance;
            if (Array.IndexOf(childs, left) > -1)
            {
                result[Array.IndexOf(childs, left)] = parent;
            }
            GetTreeParentHelper(level - 1, advance, left, childs, result);

            //right
            var right = left + (int)Math.Pow(2, level) - 1;
            if (Array.IndexOf(childs, right) > -1)
            {
                result[Array.IndexOf(childs, right)] = parent;
            }
            GetTreeParentHelper(level - 1, left, right, childs, result);
        }