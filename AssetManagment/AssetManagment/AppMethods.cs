using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AssetManagment
{
    public class AppMethods
    {
        private LinkedList<CheckedOutItem> list = new LinkedList<CheckedOutItem>();

        //should be called when program is opened
        public void LoadLinkedList(string filePath) 
        {
            string[] fileLines = File.ReadLines(filePath).ToArray();

            foreach (string line in fileLines)
            {
                CheckedOutItem checkedOutItem = CreateCheckedOutItemFromLine(line);
                list.AddLast(checkedOutItem);
            }
        }

        public CheckedOutItem CreateCheckedOutItemFromLine(string line)
        {
            string[] items = line.Split(',');

            CheckedOutItem checkedOutItem = new CheckedOutItem(items[0], items[1], items[2], items[3], items[4], items[5], items[6]);

            return checkedOutItem;
        }

        public void AddCheckedOutItemToList(CheckedOutItem checkedOutItem)
        {
            list.AddLast(checkedOutItem);
        }

        public CheckedOutItem SearchList(string asuriteId)
        {
            foreach (CheckedOutItem listItem in list)
            {
                if (listItem.asuriteId.Equals(asuriteId))
                {
                    return listItem;
                }
            }

            return null;
        }

        public void DeleteCheckedOutItemFromList(string asuriteId)
        {
            list.Remove(SearchList(asuriteId));
        }

        //should be called when program is closed
        public void SaveLinkedList(string filePath) 
        {
            foreach (CheckedOutItem listItem in list)
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine(listItem.ToString(), sw);
                }
            }
        }
    }
}
