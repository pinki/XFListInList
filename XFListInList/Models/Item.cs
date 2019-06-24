using System.Collections.Generic;

namespace XFListInList.Models {
    public class Item {
        public string Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public ICollection<SubItem> SubItems { get; set; } = new List<SubItem>();
    }
}