using System.Collections.Generic;

namespace XFListInList.Models {
    public class Item : List<SubItem> {
        public Item (IEnumerable<SubItem> subItems = null) {
            if (subItems != null) {
                AddRange(subItems);
            }
        }

        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}