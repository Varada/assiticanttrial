using System.Linq;
using Assisticant.Fields;

namespace AssiticantTrial.Models
{
    public class Selection
    {
        private Observable<Item> _selectedItem = new Observable<Item>();

        public Item SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem.Value = value; }
        }
    }
}
