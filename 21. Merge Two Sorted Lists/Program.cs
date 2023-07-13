List<int> MergeTwoLists(List<int> list1, List<int> list2)
{
   List<int> result = new List<int>(list1.Count + list2.Count);
    result.AddRange(list1);
    result.AddRange(list2);
    result.Sort();
    return result;
}

