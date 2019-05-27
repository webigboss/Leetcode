//https://www.youtube.com/watch?v=bGC2fNALbNU
        public IList<IList<int>> FindAllSubSets(int[] array)
        {
            Array.Sort(array);
            var result = new List<IList<int>>();
            FindAllSubSetsHelper(array, 0, new List<int>(), result);
            return result;
        }

        private void FindAllSubSetsHelper(int[] array, int index, IList<int> list, IList<IList<int>> result)
        {
            if (index == array.Length)
            {
                result.Add(new List<int>(list));
                return;
            }
            //scenario 1: array[index] won't be added into the subset
            FindAllSubSetsHelper(array, index + 1, list, result);
            //scenario 2: array[index] will be added into the subset
            //note: I don't need to remove this 
            list.Add(array[index]);
            FindAllSubSetsHelper(array, index + 1, list, result);
            list.RemoveAt(list.Count - 1);
        }